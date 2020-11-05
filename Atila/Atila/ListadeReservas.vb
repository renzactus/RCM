Public Class ListadeReservas
    Dim mysql As New MySQL
    Public booleanNroReciboUnico As Boolean
    Public cuotas, Preciototal, FilaNumero As Integer
    Dim razon_cancelacion, ibImprevisto As String
    Dim reservaInvertida As DataTable
    Public datosReserva As DataTable

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstablecerColores()
        PonerEnNegritasDiasConReservas()
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
        btnCancelarReserva.Visible = False

    End Sub
    'Diseño
    Private Sub EstablecerColores()
        Me.BackColor = Principal.colorSecundario
        lblFiestasReservadasParaEl.ForeColor = Principal.colorTitulos
        cboReservasEnElDia.BackColor = Principal.colorTerceario
        lblCosasUtilizar.ForeColor = Principal.colorTitulos
        lblSeleccioneUnaFecha.ForeColor = Principal.colorTitulos
        btnPagar.ForeColor = Principal.colorTitulos
        lblPrecioF.ForeColor = Principal.colorTitulos
        btnGuardarPrecioFiesta.ForeColor = Principal.colorTitulos
        btnEditarPrecioFiesta.ForeColor = Principal.colorTitulos
        btnSurgioImprevisto.ForeColor = Principal.colorTitulos
        btnCancelarReserva.ForeColor = Principal.colorTitulos
        dgvUtiliza.BackgroundColor = Principal.colorTerceario
        btnEditarFecha.ForeColor = Principal.colorTitulos
        btnGuardarFecha.ForeColor = Principal.colorTitulos
        btnCancelarFecha.ForeColor = Principal.colorTitulos
        btnExpandir.ForeColor = Principal.colorTitulos

    End Sub
    'Metodos utilizados
    Public Sub PonerEnNegritasDiasConReservas()
        Calendario.RemoveAllBoldedDates()
        mysql.Consultar("select distinct fecha from reservas where fecha_cancelacion is null")
        If mysql.Consultado = True Then

            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
        End If
    End Sub
    
    Private Sub ActualizarPrecio()
        consultarUltimaActualizacionDeCostos()
        If mysql.Consultado = True Then
            If lblMostrarMotivo.Text = "Fiesta con Baile" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
            ElseIf lblMostrarMotivo.Text = "Fiesta sin Baile" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_fiesta_sin_baile")
            ElseIf lblMostrarMotivo.Text = "Parrillada" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_Parrillada")
            End If
            Preciototal = Preciototal + mysql.Resultado.Rows(0).Item("c_precio_por_persona") * lblMostrarPersonas.Text
            If Calendario.SelectionRange.Start.DayOfWeek = 5 Or Calendario.SelectionRange.Start.DayOfWeek = 6 Or Calendario.SelectionRange.Start.DayOfWeek = 0 Then
                Preciototal = Preciototal + Preciototal / 100 * mysql.Resultado.Rows(0).Item("porcentaje_findesemana")
            End If
            lblPrecioFiesta.Text = PrecioTotal
        End If
    End Sub
    Private Sub consultarUltimaActualizacionDeCostos()
        mysql.Consultar("select * from costos where FECHA_ACTUALIZACION=(select max(FECHA_ACTUALIZACION) from costos)")
    End Sub
    'Mostrando datos
    Public Sub ChequearSiHayMasDeUnaReservaEnElDiaYProceder(ByVal fecha As Date)
        VaciarDatos()
        consultarDatosDeReservaConSuClienteYPrecio(fecha)
        cboReservasEnElDia.Items.Clear()
        lblFechaSeleccionada.Text = fecha
        If mysql.Resultado.Rows.Count > 1 Then
            cboReservasEnElDia.Enabled = True
            cboReservasEnElDia.Visible = True
            lblNoHayReservas.Visible = False
            For i = 0 To mysql.Resultado.Rows.Count - 1
                cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(i).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(i).Item("final").ToString)
            Next
        ElseIf mysql.Resultado.Rows.Count = 1 Then
            lblNoHayReservas.Visible = False
            cboReservasEnElDia.Enabled = True
            cboReservasEnElDia.Visible = True
            cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(0).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(0).Item("final").ToString)
            cboReservasEnElDia.SelectedIndex = 0
            MostrarDatosDeReserva()
        Else
            lblNoHayReservas.Visible = True
            cboReservasEnElDia.Enabled = False
            cboReservasEnElDia.Visible = False
            DeshabilitarOHabilitarDatos(False)
            VaciarDatos()
        End If
    End Sub

    Private Sub consultarDatosDeReservaConSuClienteYPrecio(ByVal fecha As Date)
        mysql.Consultar("select reservas.ID_RESERVA,reservas.ID_CLIENTE,razon_cancelacion,clientes.dinero_a_favor,motivo,nota,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final" &
                        ",cantidad_personas,servicio,nombre,seña as s,costo,imprevisto.descripcion from reservas left join pagos on pagos.id_reserva=reservas.id_reserva" &
                        " inner join clientes on clientes.id_cliente=reservas.id_cliente left join imprevisto on imprevisto.ID_RESERVA=reservas.ID_RESERVA" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null UNION" &
                        " select reservas.ID_RESERVA,reservas.ID_CLIENTE,razon_cancelacion,clientes.dinero_a_favor,motivo,nota,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final," &
                        "cantidad_personas,servicio,nombre,seña as s,costo,imprevisto.descripcion from reservas right join pagos on pagos.id_reserva=reservas.id_reserva" &
                        " inner join clientes on clientes.id_cliente=reservas.id_cliente left join imprevisto on imprevisto.ID_RESERVA=reservas.ID_RESERVA" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        datosReserva = mysql.Resultado
    End Sub
    Private Sub VaciarDatos()
        lblMostrarMotivo.Text = ""
        lblMostrarNota.Text = ""
        lblMostrarFecha.Text = ""
        lblMostrarHora.Text = ""
        lblMostrarPersonas.Text = ""
        chkMostrarServicio.Visible = False
        lblMostrarCliente.Text = ""
        lblMostrarSeña.Text = ""
        lblMostrarPagado.Text = ""
        lblMostrarImprevisto.Text = ""
        lblSeña.Enabled = False
        lblSeña.Visible = False
        lblPagado.Enabled = False
        lblPagado.Visible = False
        pnlSiNoSePago.Visible = False
        btnCancelarReserva.Visible = False
        btnSurgioImprevisto.Visible = False
        btnEditarFecha.Visible = False
        lblImprevisto.Enabled = False
        lblImprevisto.Visible = False
        dgvUtiliza.Rows.Clear()

    End Sub
    Private Sub DeshabilitarOHabilitarDatos(ByVal valor As Boolean)
        lblMotivo.Enabled = valor
        lblNota.Enabled = valor
        lblFecha.Enabled = valor
        lblHora.Enabled = valor
        lblPersonas.Enabled = valor
        lblServicio.Enabled = valor
        lblCliente.Enabled = valor

        lblImprevisto.Enabled = False
        dgvUtiliza.Enabled = valor
    End Sub
    Private Sub DeshabilitarOHabilitarDatosAlEditarFecha(ByVal valor As Boolean)
        Calendario.Enabled = valor
        cboReservasEnElDia.Enabled = valor
        btnPagar.Enabled = valor
        btnExpandir.Enabled = valor
        pnlSiNoSePago.Enabled = valor
    End Sub
    Private Sub DeshabilitarOHabilitarDatosAlEditarPrecio(ByVal valor As Boolean)
        Calendario.Enabled = valor
        cboReservasEnElDia.Enabled = valor
        btnPagar.Enabled = valor
        btnExpandir.Enabled = valor
    End Sub

    Private Sub MostrarDatosDeReserva()

        FilaNumero = cboReservasEnElDia.SelectedIndex
        DeshabilitarOHabilitarDatos(True)
        VaciarDatos()
        If mysql.Consultado = True Then


            lblMostrarMotivo.Text = datosReserva.Rows(FilaNumero).Item("motivo")
            If datosReserva.Rows(FilaNumero).Item("nota").ToString.Length > 15 Then
                btnExpandir.Visible = True
                lblMostrarNota.Text = datosReserva.Rows(FilaNumero).Item("nota").ToString.Substring(0, 15) & "..."
            Else
                btnExpandir.Visible = False
                lblMostrarNota.Text = datosReserva.Rows(FilaNumero).Item("nota")
            End If

            lblMostrarFecha.Text = datosReserva.Rows(FilaNumero).Item("fecha")
            lblMostrarHora.Text = datosReserva.Rows(FilaNumero).Item("comienzo").ToString & " - " & datosReserva.Rows(FilaNumero).Item("final").ToString
            lblMostrarPersonas.Text = datosReserva.Rows(FilaNumero).Item("cantidad_personas")
            chkMostrarServicio.Visible = True
            chkMostrarServicio.Checked = datosReserva.Rows(FilaNumero).Item("servicio")
            lblMostrarCliente.Text = datosReserva.Rows(FilaNumero).Item("nombre")
            If Not IsDBNull(datosReserva.Rows(FilaNumero).Item("descripcion")) Then
                lblMostrarImprevisto.Text = datosReserva.Rows(FilaNumero).Item("descripcion")
                lblImprevisto.Visible = True
                lblImprevisto.Enabled = True
            End If

            mysql.Consultar("select descripcion,utiliza.cantidad from utiliza inner join inventario on utiliza.ID_INVENTARIO=inventario.ID_INVENTARIO where id_reserva=" &
                            datosReserva.Rows(FilaNumero).Item("ID_RESERVA"))
            For i = 0 To mysql.Resultado.Rows.Count - 1
                dgvUtiliza.Rows.Add(mysql.Resultado.Rows(i).Item("descripcion"), mysql.Resultado.Rows(i).Item("cantidad"))
            Next

            If (datosReserva.Rows(FilaNumero).Item("fecha") = mysql.Consultar("select current_date").rows(0).item("current_Date")) And (datosReserva.Rows(FilaNumero).Item("comienzo").ToString < mysql.Consultar("select current_time").rows(0).item("current_time").ToString) Then
                btnSurgioImprevisto.Visible = True
            ElseIf (datosReserva.Rows(FilaNumero).Item("fecha") < mysql.Consultar("select current_date").rows(0).item("current_Date")) Then
                btnSurgioImprevisto.Visible = True
            Else
                btnEditarFecha.Visible = True
                btnCancelarReserva.Visible = True
            End If
            If Not IsDBNull(datosReserva.Rows(FilaNumero).Item("costo")) Then
                lblMostrarPagado.Text = "$" & String.Format("{0:N0}", datosReserva.Rows(FilaNumero).Item("costo"))
                lblPagado.Visible = True
                lblPagado.Enabled = True
            ElseIf Not IsDBNull(datosReserva.Rows(FilaNumero).Item("s")) Then
                lblMostrarSeña.Text = "$" & String.Format("{0:N0}", datosReserva.Rows(FilaNumero).Item("s"))
                lblSeña.Visible = True
                lblSeña.Enabled = True
                pnlSiNoSePago.Visible = True
                ActualizarPrecio()
            End If


        End If
    End Sub

    'Insertando Pagos
    

    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    'Actualizando datos
    Private Sub CancelarReservaSeleccionadaYAgregarDineroAFavor()
        If MsgBox("Desea cancelar la reserva del " & datosReserva.Rows(FilaNumero).Item("fecha"), vbYesNo, "Atención!") = vbYes Then
            'CONTINUAR CONN ESTO
            'razon_cancelacion = InputBox("Ingrese la razon por la cual se cancelo la reserva")
            mysql.InsertarDatos("update reservas set fecha_cancelacion=current_timestamp, razon_cancelacion='" & razon_cancelacion & "' where ID_RESERVA=" &
                        datosReserva.Rows(FilaNumero).Item("ID_RESERVA"))
            If mysql.Consultado = True Then

                If Not IsDBNull(datosReserva.Rows(FilaNumero).Item("costo")) Then
                    mysql.InsertarDatos("update clientes set dinero_a_favor=" & CInt((datosReserva.Rows(FilaNumero).Item("costo") / 100) * 70) + datosReserva.Rows(FilaNumero).Item("dinero_a_favor") & " where ID_CLIENTE=" & datosReserva.Rows(FilaNumero).Item("ID_CLIENTE"))
                End If

                ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
                PonerEnNegritasDiasConReservas()
            End If
        End If
    End Sub
    Public Sub AlmacenarImprevisto(ByVal ID_RESERVA As Integer)
        Principal.booleanImprevistoAlmacenado = False
        mysql.Consultar("select descripcion from imprevisto where ID_RESERVA=" & ID_RESERVA)
        If mysql.Resultado.Rows.Count = 0 Then
            ibImprevisto = InputBox("¿Cual fue el imprevisto?", "Atención!", " ")
        Else
            ibImprevisto = InputBox("¿Cual fue el imprevisto?", "Atención!", mysql.Resultado.Rows(0).Item("descripcion"))
        End If

        If ibImprevisto = " " Then
            MessageBox.Show("Tienes que escribir algun imprevisto para que se guarde")
            Exit Sub
        ElseIf ibImprevisto = "" Then
            Exit Sub
        Else
            Principal.booleanImprevistoAlmacenado = True
            If mysql.Resultado.Rows.Count = 0 Then
                mysql.InsertarDatos("insert into imprevisto (ID_RESERVA,descripcion) values(" & ID_RESERVA & ",'" & ibImprevisto & "')")
            Else
                mysql.InsertarDatos("update imprevisto set descripcion='" & ibImprevisto & "' where ID_RESERVA=" & ID_RESERVA)
            End If


        End If
    End Sub
    Public Sub consultarChequearSiLaHoraEstaOcupada()
        mysql.Consultar("select ID_RESERVA from reservas where comienzo>final and fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        reservaInvertida = mysql.Resultado

        If datosReserva.Rows(FilaNumero).Item("comienzo") < datosReserva.Rows(FilaNumero).Item("final") Then


            If reservaInvertida.Rows.Count = 0 Then
                mysql.Consultar("select id_reserva from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(comienzo,'-1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(final,'1:00:00'))) and " &
                "fecha_cancelacion is null")
            Else
                mysql.Consultar("select id_reserva from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(comienzo,'-1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(final,'1:00:00'))) and " &
                "fecha_cancelacion is null and ID_RESERVA<>" & reservaInvertida.Rows(0).Item("ID_RESERVA"))
                If mysql.Resultado.Rows.Count = 0 Then
                    mysql.Consultar("select id_reserva from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(final,'1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(comienzo,'-1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00'))) and fecha_cancelacion is null")
                End If
            End If



        Else
            If reservaInvertida.Rows.Count = 0 Then
                mysql.Consultar("select ID_RESERVA from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00'))) and fecha_cancelacion is null")
            Else
                mysql.Consultar("select ID_RESERVA from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(final,'1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(comienzo,'-1:00:00'))) and fecha_cancelacion is null and ID_RESERVA<>" & reservaInvertida.Rows(0).Item("ID_RESERVA"))

                If mysql.Resultado.Rows.Count = 0 Then

                    mysql.Consultar("select id_reserva from reservas where fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' and (('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("final") & "'<addtime(final,'1:00:00')) or ('" &
                    datosReserva.Rows(FilaNumero).Item("comienzo") & "'<addtime(comienzo,'-1:00:00') and '" & datosReserva.Rows(FilaNumero).Item("final") & "'>addtime(final,'1:00:00'))) and fecha_cancelacion is null")

                End If
            End If




        End If
    End Sub

    'Eventos
    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        Calendario.SelectionRange = New SelectionRange(Calendario.SelectionStart, Calendario.SelectionStart)
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
    End Sub

    Private Sub cboReservasEnElDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReservasEnElDia.SelectedIndexChanged
        MostrarDatosDeReserva()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Principal.Enabled = False
        Dim pagarreserva As New PagarReserva
        pagarreserva.Show()
        pagarreserva.dtosReserva = datosReserva
        pagarreserva.ptotal = Preciototal
    End Sub

    Private Sub btnInsertarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtNroRecibo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub btnGuardarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPrecioFiesta.Click
        PrecioTotal = txtPrecioFiesta.Text
        txtPrecioFiesta.Visible = False
        btnGuardarPrecioFiesta.Visible = False
        lblPrecioFiesta.Text = PrecioTotal
        btnPagar.Enabled = True
        DeshabilitarOHabilitarDatosAlEditarPrecio(True)
    End Sub

    Private Sub btnEditarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarPrecioFiesta.Click
        txtPrecioFiesta.Visible = True
        btnGuardarPrecioFiesta.Visible = True
        txtPrecioFiesta.Text = Preciototal
        DeshabilitarOHabilitarDatosAlEditarPrecio(False)

    End Sub

    Private Sub btnCancelarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarReserva.Click
        CancelarReservaSeleccionadaYAgregarDineroAFavor()
    End Sub

    Private Sub btnSurgioImprevisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurgioImprevisto.Click
        AlmacenarImprevisto(datosReserva.Rows(FilaNumero).Item("ID_RESERVA"))
    End Sub
    
    Private Sub btnGuardarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFecha.Click
        consultarChequearSiLaHoraEstaOcupada()
        If mysql.Resultado.Rows.Count = 0 Then
            mysql.InsertarDatos("update reservas set fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' where ID_RESERVA=" & datosReserva.Rows(FilaNumero).Item("ID_RESERVA"))
            If mysql.Consultado = True Then
                epError.SetError(dtpFecha, "")
                dtpFecha.Visible = False
                btnEditarFecha.Visible = True
                btnCancelarFecha.Visible = False
                btnGuardarFecha.Visible = False
                ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
                PonerEnNegritasDiasConReservas()
                Calendario.Enabled = True
            End If
        Else
            epError.SetError(dtpFecha, "Fecha ocupada")
        End If
        DeshabilitarOHabilitarDatosAlEditarFecha(True)
    End Sub

    Private Sub btnEditarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarFecha.Click
        dtpFecha.MinDate = mysql.Consultar("select current_date").rows(0).item("current_date")
        Calendario.Enabled = False
        dtpFecha.Value = lblMostrarFecha.Text
        dtpFecha.Visible = True
        btnEditarFecha.Visible = False
        btnCancelarFecha.Visible = True
        btnGuardarFecha.Visible = True
        DeshabilitarOHabilitarDatosAlEditarFecha(False)
    End Sub

    Private Sub btnCancelarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarFecha.Click
        Calendario.Enabled = True
        dtpFecha.Value = lblMostrarFecha.Text
        dtpFecha.Visible = False
        btnEditarFecha.Visible = True
        btnCancelarFecha.Visible = False
        btnGuardarFecha.Visible = False
        DeshabilitarOHabilitarDatosAlEditarFecha(True)
    End Sub

    Private Sub btnExpandir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandir.Click
        MsgBox(datosReserva.Rows(FilaNumero).Item("nota"))
    End Sub

    Private Sub txtPrecioFiesta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioFiesta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

End Class