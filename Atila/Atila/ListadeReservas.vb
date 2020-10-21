Public Class ListadeReservas
    Dim mysql As New MySQL

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PonerEnNegritasDiasConReservas()
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
    End Sub
    'Metodos utilizados
    Private Sub PonerEnNegritasDiasConReservas()
        mysql.Consultar("select distinct fecha from reservas where fecha_cancelacion is null")
        If mysql.Consultado = True Then
            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
        End If
    End Sub
    Private Sub MostrarDatosDeReserva(ByVal FilaNumero As Integer)
        DeshabilitarOHabilitarDatos(True)
        VaciarDatos()
        If mysql.Consultado = True Then


            lblMostrarMotivo.Text = mysql.Resultado.Rows(FilaNumero).Item("motivo")
            lblMostrarFecha.Text = mysql.Resultado.Rows(FilaNumero).Item("fecha")
            lblMostrarHora.Text = mysql.Resultado.Rows(FilaNumero).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(FilaNumero).Item("final").ToString
            lblMostrarPersonas.Text = mysql.Resultado.Rows(FilaNumero).Item("cantidad_personas")
            chkMostrarServicio.Visible = True
            chkMostrarServicio.Checked = mysql.Resultado.Rows(FilaNumero).Item("servicio")
            lblMostrarCliente.Text = mysql.Resultado.Rows(FilaNumero).Item("nombre")
            If Not IsDBNull(mysql.Resultado.Rows(FilaNumero).Item("s")) Then
                lblMostrarSeña.Text = mysql.Resultado.Rows(FilaNumero).Item("s")
                lblSeña.Visible = True
                lblSeña.Enabled = True
            ElseIf Not IsDBNull(mysql.Resultado.Rows(FilaNumero).Item("costo")) Then
                lblMostrarPrecio.Text = mysql.Resultado.Rows(FilaNumero).Item("costo")
                lblPrecio.Visible = True
                lblPrecio.Enabled = True
            End If


        End If
    End Sub

    Public Sub ChequearSiHayMasDeUnaReservaEnElDiaYProceder(ByVal fecha As Date)
        VaciarDatos()
        consultarDatosDeReservaConSuClienteYPrecio(fecha)
        cboReservasEnElDia.Items.Clear()
        lblFechaSeleccionada.Text = fecha
        If mysql.Resultado.Rows.Count > 1 Then
            cboReservasEnElDia.Enabled = True
            lblNoHayReservas.Visible = False
            For i = 0 To mysql.Resultado.Rows.Count - 1
                cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(i).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(i).Item("final").ToString)
            Next
        ElseIf mysql.Resultado.Rows.Count = 1 Then
            lblNoHayReservas.Visible = False
            cboReservasEnElDia.Enabled = True
            cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(0).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(0).Item("final").ToString)
            cboReservasEnElDia.SelectedIndex = 0
            MostrarDatosDeReserva(cboReservasEnElDia.SelectedIndex)
        Else
            lblNoHayReservas.Visible = True
            cboReservasEnElDia.Enabled = False
            DeshabilitarOHabilitarDatos(False)
            VaciarDatos()
        End If
    End Sub

    Private Sub consultarDatosDeReservaConSuClienteYPrecio(ByVal fecha As Date)
        mysql.Consultar("select motivo,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final" &
                        ",cantidad_personas,servicio,nombre,seña as s,costo from reservas left join pagos on " &
                        "pagos.id_reserva=reservas.id_reserva inner join clientes on clientes.id_cliente=reservas.id_cliente" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null UNION" &
                        " select motivo,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final," &
                        "cantidad_personas,servicio,nombre,seña as s,costo from reservas right join pagos on pagos.id_reserva=reservas.id_reserva" &
                        " inner join clientes on clientes.id_cliente=reservas.id_cliente" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
    End Sub
    Private Sub VaciarDatos()
        lblMostrarMotivo.Text = ""
        lblMostrarFecha.Text = ""
        lblMostrarHora.Text = ""
        lblMostrarPersonas.Text = ""
        chkMostrarServicio.Visible = False
        lblMostrarCliente.Text = ""
        lblMostrarSeña.Text = ""
        lblMostrarPrecio.Text = ""
        lblSeña.Enabled = False
        lblSeña.Visible = False
        lblPrecio.Enabled = False
        lblPrecio.Visible = False
    End Sub
    Private Sub DeshabilitarOHabilitarDatos(ByVal valor As Boolean)
        lblMotivo.Enabled = valor
        lblFecha.Enabled = valor
        lblHora.Enabled = valor
        lblPersonas.Enabled = valor
        lblServicio.Enabled = valor
        lblCliente.Enabled = valor
        lblSeña.Enabled = valor
        lblPrecio.Enabled = valor
    End Sub

    'Eventos
    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        Calendario.SelectionRange = New SelectionRange(Calendario.SelectionStart, Calendario.SelectionStart)
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
    End Sub

    Private Sub cboReservasEnElDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReservasEnElDia.SelectedIndexChanged
        MostrarDatosDeReserva(cboReservasEnElDia.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class