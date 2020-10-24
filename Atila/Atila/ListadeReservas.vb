Public Class ListadeReservas
    Dim mysql As New MySQL
    Dim booleanNroReciboUnico As Boolean
    Dim cuotas, Preciototal, FilaNumero As Integer
    Dim razon_cancelacion As String
    Dim datosReserva As DataTable
    Dim fecha_actual As Date

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PonerEnNegritasDiasConReservas()
        ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
        btnCancelarReserva.Visible = False

    End Sub
    'Metodos utilizados
    Private Sub PonerEnNegritasDiasConReservas()
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
            If lblMostrarMotivo.Text = "Fiesta de 15" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
            ElseIf lblMostrarMotivo.Text = "Cumpleaño de niño" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_fiesta_infantil")
            ElseIf lblMostrarMotivo.Text = "Parrillada" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_otro")
            ElseIf lblMostrarMotivo.Text = "Graduación" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
            ElseIf lblMostrarMotivo.Text = "Otro" Then
                Preciototal = mysql.Resultado.Rows(0).Item("c_otro")
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
            lblNoHayReservas.Visible = False
            For i = 0 To mysql.Resultado.Rows.Count - 1
                cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(i).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(i).Item("final").ToString)
            Next
        ElseIf mysql.Resultado.Rows.Count = 1 Then
            lblNoHayReservas.Visible = False
            cboReservasEnElDia.Enabled = True
            cboReservasEnElDia.Items.Add(mysql.Resultado.Rows(0).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(0).Item("final").ToString)
            cboReservasEnElDia.SelectedIndex = 0
            MostrarDatosDeReserva()
        Else
            lblNoHayReservas.Visible = True
            cboReservasEnElDia.Enabled = False
            DeshabilitarOHabilitarDatos(False)
            VaciarDatos()
        End If
    End Sub

    Private Sub consultarDatosDeReservaConSuClienteYPrecio(ByVal fecha As Date)
        mysql.Consultar("select reservas.ID_RESERVA,reservas.ID_CLIENTE,clientes.dinero_a_favor,motivo,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final" &
                        ",cantidad_personas,servicio,nombre,seña as s,costo from reservas left join pagos on " &
                        "pagos.id_reserva=reservas.id_reserva inner join clientes on clientes.id_cliente=reservas.id_cliente" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null UNION" &
                        " select reservas.ID_RESERVA,reservas.ID_CLIENTE,clientes.dinero_a_favor,motivo,fecha,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final," &
                        "cantidad_personas,servicio,nombre,seña as s,costo from reservas right join pagos on pagos.id_reserva=reservas.id_reserva" &
                        " inner join clientes on clientes.id_cliente=reservas.id_cliente" &
                        " where fecha='" & Format(fecha, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        datosReserva = mysql.Resultado
    End Sub
    Private Sub VaciarDatos()
        lblMostrarMotivo.Text = ""
        lblMostrarFecha.Text = ""
        lblMostrarHora.Text = ""
        lblMostrarPersonas.Text = ""
        chkMostrarServicio.Visible = False
        lblMostrarCliente.Text = ""
        lblMostrarSeña.Text = ""
        lblMostrarPagado.Text = ""
        lblSeña.Enabled = False
        lblSeña.Visible = False
        lblPagado.Enabled = False
        lblPagado.Visible = False
        pnlSiNoSePago.Visible = False
        btnCancelarReserva.Visible = False

    End Sub
    Private Sub DeshabilitarOHabilitarDatos(ByVal valor As Boolean)
        lblMotivo.Enabled = valor
        lblFecha.Enabled = valor
        lblHora.Enabled = valor
        lblPersonas.Enabled = valor
        lblServicio.Enabled = valor
        lblCliente.Enabled = valor
    End Sub

    Private Sub MostrarDatosDeReserva()
        FilaNumero = cboReservasEnElDia.SelectedIndex
        DeshabilitarOHabilitarDatos(True)
        VaciarDatos()
        If mysql.Consultado = True Then


            lblMostrarMotivo.Text = datosReserva.Rows(FilaNumero).Item("motivo")
            lblMostrarFecha.Text = datosReserva.Rows(FilaNumero).Item("fecha")
            lblMostrarHora.Text = datosReserva.Rows(FilaNumero).Item("comienzo").ToString & " - " & datosReserva.Rows(FilaNumero).Item("final").ToString
            lblMostrarPersonas.Text = datosReserva.Rows(FilaNumero).Item("cantidad_personas")
            chkMostrarServicio.Visible = True
            chkMostrarServicio.Checked = datosReserva.Rows(FilaNumero).Item("servicio")
            lblMostrarCliente.Text = datosReserva.Rows(FilaNumero).Item("nombre")
            btnCancelarReserva.Visible = True
            If Not IsDBNull(datosReserva.Rows(FilaNumero).Item("costo")) Then
                lblMostrarPagado.Text = datosReserva.Rows(FilaNumero).Item("costo")
                lblPagado.Visible = True
                lblPagado.Enabled = True
            ElseIf Not IsDBNull(datosReserva.Rows(FilaNumero).Item("s")) Then
                lblMostrarSeña.Text = datosReserva.Rows(FilaNumero).Item("s")
                lblSeña.Visible = True
                lblSeña.Enabled = True
                pnlSiNoSePago.Visible = True
                ActualizarPrecio()
            End If


        End If
    End Sub

    'Insertando Pagos
    Private Sub ChequearSiHayCamposVaciosYProceder()
        chequearQueNroReciboSeaUnico()
        If txtNroRecibo.Text = "" Or cboCuotas.SelectedIndex = -1 Or cboModoPagoPagado.SelectedIndex = -1 Then
            avisarSiEstaVacio(txtNroRecibo)
            avisarSiEstaVacio(cboCuotas)
            avisarSiEstaVacio(cboModoPagoPagado)
            avisarSiEstaVacio(cboModoPagoPagado)
            Reservar.sonidoError()
        ElseIf booleanNroReciboUnico = False Then
            epError.SetError(txtNroRecibo, "Ya existe un numero de recibo igual, ingrese otro")
            Reservar.sonidoError()
        Else
            insertarPago()
        End If
    End Sub
    Private Sub chequearQueNroReciboSeaUnico()
        If txtNroRecibo.Text <> "" Then
            booleanNroReciboUnico = True
            mysql.Consultar("select nro_recibo from pagos")
            If mysql.Consultado = True Then
                For i = 0 To mysql.Resultado.Rows.Count - 1
                    If mysql.Resultado.Rows(i).Item("nro_recibo") = txtNroRecibo.Text Then
                        booleanNroReciboUnico = False
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    Private Sub insertarPago()
        If cboCuotas.Text = "Ninguna" Then
            cuotas = 1
        Else
            cuotas = cboCuotas.Text
        End If
        mysql.InsertarDatos("insert into pagos (NRO_RECIBO,cuotas,fecha_pago,costo,forma,ID_RESERVA) values(" & txtNroRecibo.Text & "," & cuotas & ",current_date," &
                            Preciototal + datosReserva.Rows(FilaNumero).Item("s") & ",'" & cboModoPagoPagado.Text & "'," & datosReserva.Rows(FilaNumero).Item("ID_RESERVA") & ")")
        If mysql.Consultado = True Then
            MsgBox("Pagado Correctamente")
            pnlPagar.Visible = False
            pnlDatosReservas.Visible = True
            btnInsertarPago.Text = "Pagar"
            ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
        End If
    End Sub
    'Actualizando datos
    Private Sub CancelarReservaSeleccionada()
        If MsgBox("Desea cancelar la reserva del " & datosReserva.Rows(FilaNumero).Item("fecha"), vbYesNo, "Atención!") = vbYes Then
            'CONTINUAR CONN ESTO
            'razon_cancelacion = InputBox("Ingrese la razon por la cual se cancelo la reserva")
            mysql.InsertarDatos("update reservas set fecha_cancelacion=current_timestamp, razon_cancelacion='" & razon_cancelacion & "' where ID_RESERVA=" &
                        datosReserva.Rows(FilaNumero).Item("ID_RESERVA"))
            If mysql.Consultado = True Then

                If mysql.Consultado = True Then
                    If Not IsDBNull(datosReserva.Rows(FilaNumero).Item("costo")) Then
                        mysql.InsertarDatos("update clientes set dinero_a_favor=" & CInt((datosReserva.Rows(FilaNumero).Item("costo") / 100) * 70) + datosReserva.Rows(FilaNumero).Item("dinero_a_favor") & " where ID_CLIENTE=" & datosReserva.Rows(FilaNumero).Item("ID_CLIENTE"))
                    End If
                End If

                ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionRange.Start)
                PonerEnNegritasDiasConReservas()
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
        If pnlPagar.Visible = False Then
            btnPagar.Text = "Cancelar"
            pnlDatosReservas.Visible = False
            pnlPagar.Visible = True
            cboReservasEnElDia.Enabled = False
        Else
            btnPagar.Text = "Pagar"
            txtNroRecibo.Text = ""
            cboCuotas.SelectedIndex = -1
            cboModoPagoPagado.SelectedIndex = -1
            pnlDatosReservas.Visible = True
            pnlPagar.Visible = False
            cboReservasEnElDia.Enabled = True
        End If
    End Sub

    Private Sub btnInsertarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarPago.Click
        ChequearSiHayCamposVaciosYProceder()
    End Sub

    Private Sub txtNroRecibo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRecibo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub txtNroRecibo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroRecibo.Validating
        avisarSiEstaVacio(txtNroRecibo)
    End Sub

    Private Sub cboCuotas_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCuotas.Validating
        epError.SetError(cboCuotas, "")
        avisarSiEstaVacio(cboCuotas)
    End Sub

    Private Sub cboModoPagoPagado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboModoPagoPagado.Validating
        epError.SetError(cboModoPagoPagado, "")
        avisarSiEstaVacio(cboCuotas)
    End Sub

    Private Sub btnGuardarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPrecioFiesta.Click
        PrecioTotal = txtPrecioFiesta.Text
        txtPrecioFiesta.Visible = False
        btnGuardarPrecioFiesta.Visible = False
        lblPrecioFiesta.Text = PrecioTotal
        btnPagar.Enabled = True
    End Sub

    Private Sub btnEditarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarPrecioFiesta.Click
        txtPrecioFiesta.Visible = True
        btnGuardarPrecioFiesta.Visible = True
        txtPrecioFiesta.Text = PrecioTotal
        btnPagar.Enabled = False
    End Sub

    Private Sub btnCancelarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarReserva.Click
        CancelarReservaSeleccionada()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    
End Class