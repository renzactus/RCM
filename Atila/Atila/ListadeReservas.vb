Public Class ListadeReservas
    Dim mysql As New MySQL

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PonerEnNegritasDiasConReservas()
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder()
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
            lblMostrarHora.Text = mysql.Resultado.Rows(FilaNumero).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(0).Item("final").ToString
            lblMostrarPersonas.Text = mysql.Resultado.Rows(FilaNumero).Item("cantidad_personas")
            chkMostrarServicio.Checked = mysql.Resultado.Rows(FilaNumero).Item("servicio")
            lblMostrarCliente.Text = mysql.Resultado.Rows(FilaNumero).Item("nombre")
            If Not IsDBNull(mysql.Resultado.Rows(FilaNumero).Item("s")) Then
                lblMostrarSeña.Text = mysql.Resultado.Rows(FilaNumero).Item("s")
                lblSeña.Enabled = True
            End If


        End If
    End Sub

    Private Sub ChequearSiHayMasDeUnaReservaEnElDiaYProceder()
        VaciarDatos()
        consultarDatosDeReservaConSuCliente()
        cboReservasEnElDia.Items.Clear()
        lblFechaSeleccionada.Text = Calendario.SelectionRange.Start
        If mysql.Resultado.Rows.Count > 1 Then
            cboReservasEnElDia.Enabled = True
            lblNoHayReservas.Visible = False
            For i = 0 To mysql.Resultado.Rows.Count - 1
                cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(i).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(i).Item("final").ToString)
            Next
        ElseIf mysql.Resultado.Rows.Count = 1 Then
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

    Private Sub consultarDatosDeReservaConSuCliente()
        mysql.Consultar("select motivo,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final,cantidad_personas,servicio,nombre,seña as s from reservas inner join " &
                        "clientes on reservas.id_cliente=clientes.id_cliente where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "'")
    End Sub
    Private Sub VaciarDatos()
        lblMostrarMotivo.Text = ""
        lblMostrarFecha.Text = ""
        lblMostrarHora.Text = ""
        lblMostrarPersonas.Text = ""
        chkMostrarServicio.Checked = False
        lblMostrarCliente.Text = ""
        lblMostrarSeña.Text = ""
        lblSeña.Enabled = False
        lblSeña.Visible = False
    End Sub
    Private Sub DeshabilitarOHabilitarDatos(ByVal valor As Boolean)
        lblMotivo.Enabled = valor
        lblFecha.Enabled = valor
        lblHora.Enabled = valor
        lblPersonas.Enabled = valor
        lblServicio.Enabled = valor
        lblCliente.Enabled = valor
        lblSeña.Enabled = valor
    End Sub

    'Eventos
    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder()
    End Sub

    Private Sub cboReservasEnElDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReservasEnElDia.SelectedIndexChanged
        MostrarDatosDeReserva(cboReservasEnElDia.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblCliente.Enabled = False
    End Sub
End Class