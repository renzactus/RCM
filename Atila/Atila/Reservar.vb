
Public Class Reservar
    Dim booleanTelefonos, booleanClaseConstruida, booleanErrorEndgv, booleanClienteExistente, booleanNroReciboUnico, booleanSeñaMayorQuePrecioTotal, booleanDaParaPagarTodo, booleanPagoVacio As Boolean
    Dim mysql As New MySQL
    Dim telefonos, PagarModo As String
    Dim Inventario, DatosClientes, reservaInvertida As DataTable
    Dim ReservasEnElDiaSeleccionado, sumaCedula, PrecioTotal, FilaNumero As Integer
    Public ReservasEntreEsaHora As Integer
    Dim cuotas As String
    Dim AutoCompletarCedula As New AutoCompleteStringCollection()
    Dim objetoDatosReservas As Object
    Dim listadereservas As ListadeReservas = New ListadeReservas
    'Constructor
    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With txtCedula
            .AutoCompleteCustomSource = AutoCompletarCedula
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        Me.BackColor = Color.FromArgb(191, 128, 130)
        Calendario.MinDate = DateAndTime.Today
        Calendario.MaxDate = DateAdd("yyyy", 3, DateAndTime.Today)
        mysql.Consultar("select distinct fecha from reservas where fecha_cancelacion is null")
        If mysql.Consultado = True Then
            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
            MostrarReservasDelDia()
        End If
        mysql.Consultar("select * from inventario")
        Inventario = mysql.Resultado
        If mysql.Consultado = True Then
            For i = 0 To Inventario.Rows.Count - 1
                dgvInventario.Rows.Add(False, Inventario.Rows(i).Item("descripcion") & " (" & Inventario.Rows(i).Item("cantidad") & ")")
            Next
        End If
        booleanClaseConstruida = True
    End Sub
    'Otro
    Private Sub MostrarReservasDelDia()
        lblFecha.Text = Calendario.SelectionRange.Start
        lblNoHayReservas.Visible = True
        llblMotivoReserva1.Visible = False
        llblMotivoReserva2.Visible = False
        llblMotivoReserva3.Visible = False
        lblHora1.Visible = False
        lblHora2.Visible = False
        lblHora3.Visible = False
        mysql.Consultar("select motivo,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        If mysql.Consultado = True Then
            If mysql.Resultado.Rows.Count() = 1 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                lblHora1.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
            ElseIf mysql.Resultado.Rows.Count() = 2 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                llblMotivoReserva2.Visible = True
                lblHora1.Visible = True
                lblHora2.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                llblMotivoReserva2.Text = mysql.Resultado.Rows(1).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
                lblHora2.Text = mysql.Resultado.Rows(1).Item("comienzo") & "-" & mysql.Resultado.Rows(1).Item("final")
            ElseIf mysql.Resultado.Rows.Count() = 3 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                llblMotivoReserva2.Visible = True
                llblMotivoReserva3.Visible = True
                lblHora1.Visible = True
                lblHora2.Visible = True
                lblHora3.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                llblMotivoReserva2.Text = mysql.Resultado.Rows(1).Item("motivo")
                llblMotivoReserva3.Text = mysql.Resultado.Rows(2).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
                lblHora2.Text = mysql.Resultado.Rows(1).Item("comienzo") & "-" & mysql.Resultado.Rows(1).Item("final")
                lblHora3.Text = mysql.Resultado.Rows(2).Item("comienzo") & "-" & mysql.Resultado.Rows(2).Item("final")
            End If
        End If
    End Sub
    Private Sub MostrarOtroTelefono()
        txtTelefono2.Visible = True
        btnAgregarTelefonos.Text = "-"
        booleanTelefonos = True
        txtDireccion.Location = New Point(txtDireccion.Location.X, 210)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 196)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 235)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 235)
    End Sub
    Private Sub OcultarOtroTelefono()
        txtTelefono2.Visible = False
        btnAgregarTelefonos.Text = "+"
        txtTelefono2.Text = ""
        booleanTelefonos = False
        txtDireccion.Location = New Point(txtDireccion.Location.X, 183)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 169)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 211)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 211)
    End Sub
    Private Sub DeshabilitarEdicionDatosCliente(ByVal estado As Boolean)
        txtDireccion.Enabled = estado
        txtNombre.Enabled = estado
        txtTelefono1.Enabled = estado
        txtTelefono2.Enabled = estado
        btnAgregarTelefonos.Enabled = estado
        btnEditarCliente.Visible = Not estado
    End Sub
    Private Sub AutorellenarCliente()

        booleanClienteExistente = False
        For i = 0 To DatosClientes.Rows.Count - 1
            If txtCedula.Text <> "" Then
                If txtCedula.Text = DatosClientes.Rows(i).Item("cedula") Then
                    FilaNumero = i
                    booleanClienteExistente = True
                    DeshabilitarEdicionDatosCliente(False)
                    txtNombre.Text = DatosClientes.Rows(i).Item("nombre")
                    txtDireccion.Text = DatosClientes.Rows(i).Item("direccion")
                    If DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|") <> -1 Then 'Si el usuario tiene dos telefonos
                        MostrarOtroTelefono()
                        txtTelefono1.Text = DatosClientes.Rows(i).Item("telefonos").ToString.Substring(0, DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|"))
                        txtTelefono2.Text = DatosClientes.Rows(i).Item("telefonos").ToString.Substring(DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|") + 1)

                    Else

                        txtTelefono1.Text = DatosClientes.Rows(i).Item("telefonos").ToString
                        OcultarOtroTelefono()
                    End If
                    If DatosClientes.Rows(i).Item("dinero_a_favor") <> 0 Then
                        lblDineroAFavor.Visible = True
                        lblMostrarDineroAFavor.Visible = True
                        chkUtilizarDineroAFavor.Visible = True
                        chkUtilizarDineroAFavor.Text = "Utilizar Dinero " & vbNewLine & " a Favor (" &
                            DatosClientes.Rows(i).Item("dinero_a_favor") & ")"
                        lblMostrarDineroAFavor.Text = DatosClientes.Rows(i).Item("dinero_a_favor")
                    End If
                    AvisarSiHayDatosDeClientesVacios()
                End If

            End If
            If booleanClienteExistente = False And txtNombre.Enabled = False Then
                booleanClienteExistente = False
                txtNombre.Text = ""
                txtDireccion.Text = ""
                txtTelefono1.Text = ""
                txtTelefono2.Text = ""
                lblDineroAFavor.Visible = False
                lblMostrarDineroAFavor.Visible = False
                lblMostrarDineroAFavor.Text = ""
                chkUtilizarDineroAFavor.Visible = False
                chkUtilizarDineroAFavor.Checked = False
                chkDineroAFavorCambiovalor()
                OcultarOtroTelefono()
                DeshabilitarEdicionDatosCliente(True)
            End If
        Next
    End Sub
    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    Public Sub sonidoError()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
    End Sub
    Private Sub AbrirMenuConDatosReservas(ByVal lbl As LinkLabel)
        If pnlDatosReserva.Controls.Count > 0 Then
            pnlDatosReserva.Controls.RemoveAt(0)
            pnlDatosReserva.Visible = False
        Else
            pnlDatosReserva.Location = New Point(lbl.Location.X, lbl.Location.Y + 13)
            pnlDatosReserva.Visible = True
            ObtenerPanelDeClaseListadeReservaConLosDatos(lbl.Name.Substring(17))
        End If
    End Sub
    Private Sub ObtenerPanelDeClaseListadeReservaConLosDatos(ByVal nroFila As Integer)

        listadereservas.ChequearSiHayMasDeUnaReservaEnElDiaYProceder(Calendario.SelectionStart)
        listadereservas.cboReservasEnElDia.SelectedIndex = nroFila - 1
        objetoDatosReservas = listadereservas.pnlDatosReservas
        objetoDatosReservas.Dock = DockStyle.Fill
        pnlDatosReserva.Controls.Add(objetoDatosReservas)
        pnlDatosReserva.Tag = objetoDatosReservas
        objetoDatosReservas.Show()
    End Sub
    Private Sub chkDineroAFavorCambiovalor()
        booleanDaParaPagarTodo = False
        If chkUtilizarDineroAFavor.Checked = True Then
            btnEditarPrecioFiesta.Enabled = False
            If DatosClientes.Rows(FilaNumero).Item("dinero_a_favor") >= PrecioTotal Then
                cboCuotas.Enabled = False
                cboModoPagoPagado.Enabled = False
                lblPrecioFiesta.Text = 0
                booleanDaParaPagarTodo = True
            Else
                lblPrecioFiesta.Text = PrecioTotal - DatosClientes.Rows(FilaNumero).Item("dinero_a_favor")
            End If
        Else
            btnEditarPrecioFiesta.Enabled = True
            If PrecioTotal = 0 Then
                ActualizarPrecio()
            End If
            cboCuotas.Enabled = True
            cboModoPagoPagado.Enabled = True
            lblPrecioFiesta.Text = PrecioTotal
        End If
    End Sub


    'Usados al pasar al segundo panel

    Private Sub ChequearAntesDeSiguiente()

        chequeardgvInventario()
        consultarCantidadDeReservasEnElDiaSeleccionado()
        ReservasEnElDiaSeleccionado = mysql.Resultado.Rows.Count()
        If mysql.Consultado = True Then
            consultarChequearSiLaHoraEstaOcupada()
            ReservasEntreEsaHora = mysql.Resultado.Rows.Count()
            If mysql.Consultado = True Then


                If dtpHoraComienzo.Text = "" Or dtpHoraFinal.Text = "" Or cboMotivo.SelectedIndex = -1 Or nudCantidadPersonas.Text = "" Or nudCantidadPersonas.Text = "0" Then
                    AvisarSiHayDatosDeReservasVacios()
                ElseIf ReservasEnElDiaSeleccionado > 2 Then
                    epError.SetError(Calendario, "Se supero el maximo de reservas en un día")
                    sonidoError()
                ElseIf ReservasEntreEsaHora > 0 Then
                    MsgBox("Horario Ocupado")
                    sonidoError()
                ElseIf dtpHoraComienzo.Text = dtpHoraFinal.Text Then
                    epError.SetError(dtpHoraComienzo, "La Hora de comienzo de fiesta no puede ser la misma que la hora final")
                    epError.SetError(dtpHoraFinal, "La Hora de comienzo de fiesta no puede ser la misma que la hora final")
                    sonidoError()
                ElseIf booleanErrorEndgv = True Then
                    sonidoError()
                ElseIf booleanErrorEndgv = False Then 'Si no hay errores
                    PasarAlSiguientePanel()
                    ActualizarDatosCliente()
                    AutoCompletar()
                    ActualizarPrecio()
                End If


            End If
        End If
    End Sub

    Private Sub chequeardgvInventario()
        booleanErrorEndgv = False
        For i = 0 To dgvInventario.Rows.Count - 1
            If dgvInventario.Rows(i).Cells(0).Value = True Then
                If dgvInventario.Rows(i).Cells(2).Value = "" Then
                    dgvInventario.Rows(i).Cells(2).ErrorText = "Desmarcar " & Inventario.Rows(i).Item("descripcion") &
                        " o establecerle una cantidad"
                    booleanErrorEndgv = True
                ElseIf dgvInventario.Rows(i).Cells(2).Value > Inventario.Rows(i).Item("cantidad") Then
                    dgvInventario.Rows(i).Cells(2).ErrorText = "La cantidad de " & Inventario.Rows(i).Item("descripcion") &
                        " tiene que ser menor a su maximo que es " & Inventario.Rows(i).Item("cantidad")
                    dgvInventario.Rows(i).Cells(2).Selected = True
                    dgvInventario.Select()
                    booleanErrorEndgv = True
                Else
                    dgvInventario.Rows(i).Cells(2).ErrorText = ""
                End If
            Else
                dgvInventario.Rows(i).Cells(2).ErrorText = ""
            End If
        Next
    End Sub
    Private Sub consultarCantidadDeReservasEnElDiaSeleccionado()
        mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null") 'Devuelve la id_reserva si la hora en esa fecha esta ocupada
    End Sub
    Private Sub consultarChequearSiLaHoraEstaOcupada()
        mysql.Consultar("select ID_RESERVA from reservas where comienzo>final and fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        reservaInvertida = mysql.Resultado

        If dtpHoraComienzo.Value < dtpHoraFinal.Value Then


            If reservaInvertida.Rows.Count = 0 Then
                mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                dtpHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dtpHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dtpHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(final,'1:00:00'))) and " &
                "fecha_cancelacion is null")
            Else
                mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                dtpHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dtpHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dtpHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(final,'1:00:00'))) and " &
                "fecha_cancelacion is null and ID_RESERVA<>" & reservaInvertida.Rows(0).Item("ID_RESERVA"))
                If mysql.Resultado.Rows.Count = 0 Then
                    mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                    dtpHoraComienzo.Text & "'<addtime(final,'1:00:00')) or ('" &
                    dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dtpHoraFinal.Text & "'<addtime(final,'1:00:00'))) and fecha_cancelacion is null")
                End If
            End If



        Else
            If reservaInvertida.Rows.Count = 0 Then
                mysql.Consultar("select ID_RESERVA from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                    dtpHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraComienzo.Text & "'>addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00'))) and fecha_cancelacion is null")
            Else
                mysql.Consultar("select ID_RESERVA from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                    dtpHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraComienzo.Text & "'>addtime(final,'1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(comienzo,'-1:00:00'))) and fecha_cancelacion is null and ID_RESERVA<>" & reservaInvertida.Rows(0).Item("ID_RESERVA"))

                If mysql.Resultado.Rows.Count = 0 Then
                    MsgBox("ver si esta al reves en la base de datos")

                    mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                    dtpHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                    dtpHoraFinal.Text & "'<addtime(final,'1:00:00')) or ('" &
                    dtpHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dtpHoraFinal.Text & "'>addtime(final,'1:00:00'))) and fecha_cancelacion is null")

                End If
            End If




        End If
    End Sub
    Private Sub AvisarSiHayDatosDeReservasVacios()
        avisarSiEstaVacio(dtpHoraComienzo)
        avisarSiEstaVacio(dtpHoraFinal)
        avisarSiEstaVacio(cboMotivo)
        avisarSiEstaVacio(nudCantidadPersonas)
        If nudCantidadPersonas.Text = "0" Then
            epError.SetError(nudCantidadPersonas, "Porfavor, ingrese un numero distinto a 0 en " & nudCantidadPersonas.Name.Substring(3))
            sonidoError()
        Else
            epError.SetError(nudCantidadPersonas, "")
        End If
    End Sub
    Private Sub PasarAlSiguientePanel()
        pnlReserva.Visible = False
        pnlCliente.Visible = True
    End Sub
    Private Sub ActualizarDatosCliente()
        mysql.Consultar("select * from clientes")
        If mysql.Consultado = True Then
            DatosClientes = mysql.Resultado
        End If
    End Sub
    Private Sub AutoCompletar()
        For i = 0 To DatosClientes.Rows.Count - 1
            AutoCompletarCedula.Add(DatosClientes.Rows(i).Item("cedula"))
        Next
    End Sub
    Private Sub ActualizarPrecio()
        consultarUltimaActualizacionDeCostos()
        If mysql.Consultado = True Then
            If cboMotivo.Text = "Fiesta de 15" Then
                PrecioTotal = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
            ElseIf cboMotivo.Text = "Cumpleaño de niño" Then
                PrecioTotal = mysql.Resultado.Rows(0).Item("c_fiesta_infantil")
            ElseIf cboMotivo.Text = "Parrillada" Then
                PrecioTotal = mysql.Resultado.Rows(0).Item("c_otro")
            ElseIf cboMotivo.Text = "Graduación" Then
                PrecioTotal = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
            ElseIf cboMotivo.Text = "Otro" Then
                PrecioTotal = mysql.Resultado.Rows(0).Item("c_otro")
            End If
            PrecioTotal = PrecioTotal + mysql.Resultado.Rows(0).Item("c_precio_por_persona") * nudCantidadPersonas.Text
            If Calendario.SelectionRange.Start.DayOfWeek = 5 Or Calendario.SelectionRange.Start.DayOfWeek = 6 Or Calendario.SelectionRange.Start.DayOfWeek = 0 Then
                PrecioTotal = PrecioTotal + PrecioTotal / 100 * mysql.Resultado.Rows(0).Item("porcentaje_findesemana")
            End If
            lblPrecioFiesta.Text = PrecioTotal
        End If
    End Sub
    Private Sub consultarUltimaActualizacionDeCostos()
        mysql.Consultar("select * from costos where FECHA_ACTUALIZACION=(select max(FECHA_ACTUALIZACION) from costos)")
    End Sub

    'Agregar datos
    Private Sub ChequearCamposAntesDeContinuar()
        telefonos = vbNull
        cuotas = vbNull
        SiLaCedulaTiene8CaracteresEstablecersumaCedula()
        chequearSiSeñaMayorQuePrecioTotal()
        chequearQueNroReciboSeaUnico()
        chequearValoresDePago()
        If txtCedula.Text.Length < 8 Then
            epError.SetError(txtCedula, "Cedula Incompleta")
            sonidoError()
        ElseIf txtCedula.Text = "" Or txtNombre.Text = "" Or txtTelefono1.Text = "" Then 'Cliente
            AvisarSiHayDatosDeClientesVacios()
            sonidoError()
        ElseIf btnAgregarTelefonos.Text = "-" And txtTelefono2.Text = "" Then
            avisarSiEstaVacio(txtTelefono2)
            sonidoError()
        ElseIf txtCedula.Text.Substring(7) <> sumaCedula Mod 10 Then
            epError.SetError(txtCedula, "Porfavor, Ingrese una cedula valida")
            sonidoError()
        ElseIf optSeñar.Checked = False And optPagado.Checked = False Then
            epError.SetError(optPagado, "Porfavor, Marque y complete alguna de las dos opciones")
            epError.SetError(optSeñar, "Porfavor, Marque y complete alguna de las dos opciones")
            sonidoError()
        ElseIf booleanSeñaMayorQuePrecioTotal = True Then
            epError.SetError(txtSeña, "La seña no puede ser mayor al precio total")
            sonidoError()
        ElseIf optSeñar.Checked = True And (txtSeña.Text = "" Or cboModoPagoSeña.SelectedIndex = -1) Then 'Señar
            avisarSiEstaVacio(txtSeña)
            avisarSiEstaVacio(cboModoPagoSeña)
            sonidoError()
        ElseIf booleanPagoVacio = True Then
            avisarSiEstaVacio(txtNroRecibo)
            If booleanDaParaPagarTodo = False Then
                avisarSiEstaVacio(cboCuotas)
                avisarSiEstaVacio(cboModoPagoPagado)
            End If
            sonidoError()
        ElseIf booleanNroReciboUnico = False And txtNroRecibo.Text <> "" Then 'Si no hay cuadros incompletos
            epError.SetError(txtNroRecibo, "Ya existe un numero de recibo igual, ingrese otro")
        Else
            insertarDatos()
        End If
    End Sub

    Private Sub SiLaCedulaTiene8CaracteresEstablecersumaCedula()
        If txtCedula.Text <> "" And txtCedula.Text.Length = 8 Then
            sumaCedula = (txtCedula.Text.Substring(0, 1) * 8) + (txtCedula.Text.Substring(1, 1) * 1) + (txtCedula.Text.Substring(2, 1) * 2) +
                (txtCedula.Text.Substring(3, 1) * 3) + (txtCedula.Text.Substring(4, 1) * 4) + (txtCedula.Text.Substring(5, 1) * 7) + (txtCedula.Text.Substring(6, 1) * 6)
        End If
    End Sub
    Private Sub chequearSiSeñaMayorQuePrecioTotal()
        booleanSeñaMayorQuePrecioTotal = False
        If optSeñar.Checked = True And txtSeña.Text <> "" Then
            If txtSeña.Text > PrecioTotal Then
                booleanSeñaMayorQuePrecioTotal = True
            End If
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
    Private Sub chequearValoresDePago()
        If optPagado.Checked = True And (cboCuotas.SelectedIndex = -1 Or cboModoPagoPagado.SelectedIndex = -1) Then
            If booleanDaParaPagarTodo = False Then
                booleanPagoVacio = True
                avisarSiEstaVacio(cboCuotas)
                avisarSiEstaVacio(cboModoPagoPagado)
            End If
        ElseIf optPagado.Checked = True And txtNroRecibo.Text = "" Then
            booleanPagoVacio = True
        End If
    End Sub
    Private Sub AvisarSiHayDatosDeClientesVacios()
        avisarSiEstaVacio(txtCedula)
        avisarSiEstaVacio(txtNombre)
        avisarSiEstaVacio(txtTelefono1)
        If btnAgregarTelefonos.Text = "-" Then
            avisarSiEstaVacio(txtTelefono2)
        End If
    End Sub
    

    Private Sub insertarDatos()

        If cboCuotas.Text = "Ninguna" Then
            cuotas = 1
        ElseIf cboCuotas.SelectedIndex = -1 Then
            cuotas = 1
        Else
            cuotas = cboCuotas.Text
        End If

        If booleanClienteExistente = False Then
            DarFormatoAtelefonos()
            insertarCliente()
        End If

        If optSeñar.Checked = True Then
            insertarReservasConSeña()
        Else
            insertarReservasSinSeña()
        End If

        If optPagado.Checked = True Then
            If chkUtilizarDineroAFavor.Checked = True Then
                If lblPrecioFiesta.Text = 0 Then
                    mysql.InsertarDatos("update clientes set dinero_a_favor=dinero_a_favor-" & PrecioTotal &
                                        " where ID_CLIENTE=" & DatosClientes.Rows(FilaNumero).Item("ID_CLIENTE"))
                Else
                    mysql.InsertarDatos("update clientes set dinero_a_favor=0 where ID_CLIENTE=" &
                                        DatosClientes.Rows(FilaNumero).Item("ID_CLIENTE"))
                End If
            End If
            insertarPago()

        End If

        insertarInventario()
        Me.Hide()
    End Sub
    Private Sub DarFormatoAtelefonos()
        If txtTelefono2.Text <> "" Then
            telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            telefonos = txtTelefono1.Text
        End If
    End Sub
    Private Sub insertarCliente()
        mysql.InsertarDatos("insert into clientes (cedula,nombre,telefonos,direccion) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" &
                                telefonos & "','" & txtDireccion.Text & "')")
    End Sub
    Private Sub insertarReservasConSeña()
        mysql.InsertarDatos("insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE,FECHA_ACTUALIZACION,ingresodatos,ID_FUNCIONARIO,seña,formaseña) values ('" &
                    cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dtpHoraComienzo.Text & "','" & dtpHoraFinal.Text & "'," &
                    nudCantidadPersonas.Text & "," & Int(chkServicio.CheckState) & ",(select ID_CLIENTE from clientes where cedula='" & txtCedula.Text & "'),(select max(FECHA_ACTUALIZACION) " &
                    "from costos),current_timestamp,(select ID_FUNCIONARIO from funcionarios where nombre='" & Principal.lblPerfil.Text & "')," & txtSeña.Text & ",'" & cboModoPagoSeña.Text & "')")
    End Sub
    Private Sub insertarReservasSinSeña()
        mysql.InsertarDatos("insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE,FECHA_ACTUALIZACION,ingresodatos,ID_FUNCIONARIO) values ('" &
                cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dtpHoraComienzo.Text & "','" & dtpHoraFinal.Text & "'," &
                nudCantidadPersonas.Text & "," & Int(chkServicio.CheckState) & ",(select ID_CLIENTE from clientes where cedula='" & txtCedula.Text & "'),(select max(FECHA_ACTUALIZACION) " &
                "from costos),current_timestamp,(select ID_FUNCIONARIO from funcionarios where nombre='" & Principal.lblPerfil.Text & "'))")
    End Sub
    Private Sub insertarPago()
        If cboModoPagoPagado.Text = "" Then
            If lblPrecioFiesta.Text = 0 Then
                PagarModo = "dfu:" & DatosClientes.Rows(FilaNumero).Item("dinero_a_favor") - lblPrecioFiesta.Text
            End If
        Else
            If chkUtilizarDineroAFavor.Checked = True Then
                PagarModo = "dfu:" & DatosClientes.Rows(FilaNumero).Item("dinero_a_favor") &
                    "r:" & cboModoPagoPagado.Text
            Else
                PagarModo = cboModoPagoPagado.Text
            End If
        End If
        mysql.InsertarDatos("Insert into pagos (NRO_RECIBO,fecha_pago,cuotas,costo,forma,ID_RESERVA) values(" & txtNroRecibo.Text & ",current_date," &
                                    cuotas & "," & lblPrecioFiesta.Text & ",'" & PagarModo &
                                    "',(select id_reserva from reservas where ingresodatos=(select max(ingresodatos) from reservas where fecha_cancelacion is null)))")
    End Sub
    Private Sub insertarInventario()
        For i = 0 To Inventario.Rows.Count - 1
            If dgvInventario.Rows(i).Cells(0).Value = True Then
                mysql.InsertarDatos("insert into utiliza (ID_RESERVA,ID_INVENTARIO,cantidad) values((select ID_RESERVA from reservas where " &
                                                    "ingresodatos=(select max(ingresodatos) from reservas where fecha_cancelacion is null))," & Inventario.Rows(i).Item("ID_INVENTARIO") & "," &
                                                    dgvInventario.Rows(i).Cells(2).Value & ")")
            End If
        Next


    End Sub

    'Eventos
    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        ChequearCamposAntesDeContinuar()
    End Sub

    Private Sub btnAgregarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        'PARA PONER VISIBLE EL txtTelefonos2 Y MOVER DE LUGAR txtDireccion y lblDireccion
        If booleanTelefonos = False Then
            MostrarOtroTelefono()
        ElseIf booleanTelefonos = True Then
            OcultarOtroTelefono()
        End If
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        ChequearAntesDeSiguiente()
    End Sub

    Private Sub dudHoraComienz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES

    End Sub

    Private Sub dtpHoraFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpHoraFinal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtCedula.Text.Length > 7 Then
            If txtCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtTelefono1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub txtTelefono2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        Calendario.SelectionRange = New SelectionRange(Calendario.SelectionStart, Calendario.SelectionStart)
        MostrarReservasDelDia()
        epError.SetError(Calendario, "")
    End Sub

    Private Sub txtSeña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeña.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
        epError.SetError(txtSeña, "")
    End Sub

    Private Sub dgvInventario_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventario.CellValueChanged
        chequeardgvInventario()
        epError.SetError(dgvInventario, "")
        If booleanClaseConstruida = True Then
            If dgvInventario.Rows(e.RowIndex).Cells(0).Value = True Then
                dgvInventario.Rows(e.RowIndex).Cells(2).ReadOnly = False
            Else
                dgvInventario.Rows(e.RowIndex).Cells(2).ReadOnly = True
                dgvInventario.Rows(e.RowIndex).Cells(2).Value = ""
            End If

        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        pnlCliente.Visible = False
        pnlReserva.Visible = True
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        AutorellenarCliente()
    End Sub

    Private Sub btnEditarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCliente.Click
        btnAgregarDatos.Enabled = False
        lblEditandoCliente.Visible = True
        btnGuardarCliente.Visible = True
        txtCedula.Enabled = False
        btnCancelarEdicion.Visible = True
        DeshabilitarEdicionDatosCliente(True)
    End Sub

    Private Sub btnGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCliente.Click
        If txtTelefono2.Text <> "" Then
            telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            telefonos = txtTelefono1.Text
        End If
        mysql.InsertarDatos("update clientes set nombre='" & txtNombre.Text & "', telefonos='" & telefonos & "', direccion='" & txtDireccion.Text & "' where cedula=" & txtCedula.Text)
        If mysql.Consultado = True Then
            If btnAgregarTelefonos.Text = "-" And txtTelefono2.Text = "" Then
                OcultarOtroTelefono()
            End If
            btnAgregarDatos.Enabled = True
            lblEditandoCliente.Visible = False
            btnGuardarCliente.Visible = False
            txtCedula.Enabled = True
            DeshabilitarEdicionDatosCliente(False)
            ActualizarDatosCliente()
            AutoCompletar()
        End If
    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        AutorellenarCliente()
        btnAgregarDatos.Enabled = True
        lblEditandoCliente.Visible = False
        btnGuardarCliente.Visible = False
        btnCancelarEdicion.Visible = False
        txtCedula.Enabled = True
        DeshabilitarEdicionDatosCliente(False)
    End Sub

    Private Sub optSeñar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSeñar.CheckedChanged
        epError.SetError(optPagado, "")
        epError.SetError(optSeñar, "")
        epError.SetError(cboModoPagoSeña, "")
        epError.SetError(txtSeña, "")
        If optSeñar.Checked = True Then
            txtSeña.Enabled = True
            cboModoPagoSeña.Enabled = True
        Else
            txtSeña.Enabled = False
            cboModoPagoSeña.Enabled = False
            cboModoPagoSeña.SelectedIndex = -1
            txtSeña.Text = ""
        End If
    End Sub

    Private Sub optPagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPagado.CheckedChanged
        epError.SetError(optPagado, "")
        epError.SetError(optSeñar, "")
        epError.SetError(cboModoPagoPagado, "")
        epError.SetError(cboCuotas, "")
        epError.SetError(txtNroRecibo, "")
        If optPagado.Checked = True Then
            cboCuotas.Enabled = True
            txtNroRecibo.Enabled = True
            cboModoPagoPagado.Enabled = True
            chkUtilizarDineroAFavor.Enabled = True
        Else
            cboModoPagoPagado.Enabled = False
            cboModoPagoPagado.SelectedIndex = -1
            cboCuotas.Enabled = False
            txtNroRecibo.Enabled = False
            cboCuotas.SelectedIndex = -1
            txtNroRecibo.Text = ""
            chkUtilizarDineroAFavor.Checked = False
            chkUtilizarDineroAFavor.Enabled = False
        End If
    End Sub

    Private Sub txtCedula_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCedula.Validating
        avisarSiEstaVacio(txtCedula)
    End Sub

    Private Sub txtTelefono2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono2.Validating
        If btnAgregarTelefonos.Text = "-" Then
            avisarSiEstaVacio(txtTelefono2)
        End If
    End Sub

    Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        avisarSiEstaVacio(txtNombre)
    End Sub

    Private Sub txtTelefono1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono1.Validating
        avisarSiEstaVacio(txtTelefono1)
    End Sub

    Private Sub txtDireccion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        'avisarSiEstaVacio(txtDireccion)
    End Sub

    Private Sub txtNroRecibo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroRecibo.Validating
        avisarSiEstaVacio(txtNroRecibo)
    End Sub

    Private Sub cboCuotas_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCuotas.Validating
        avisarSiEstaVacio(cboCuotas)
    End Sub

    Private Sub cboModoPagoPagado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboModoPagoPagado.Validating
        avisarSiEstaVacio(cboModoPagoPagado)
    End Sub

    Private Sub dtpHoraComienzo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        avisarSiEstaVacio(dtpHoraComienzo)
    End Sub

    Private Sub dtpHoraFinal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpHoraFinal.Validating
        avisarSiEstaVacio(dtpHoraFinal)
    End Sub

    Private Sub cboMotivo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboMotivo.Validating
        avisarSiEstaVacio(cboMotivo)
    End Sub

    Private Sub dtpHoraComienzo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraComienzo.ValueChanged
        epError.SetError(dtpHoraComienzo, "")
        epError.SetError(dtpHoraFinal, "")

    End Sub

    Private Sub dtpHoraFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraFinal.ValueChanged
        epError.SetError(dtpHoraComienzo, "")
        epError.SetError(dtpHoraFinal, "")
    End Sub

    Private Sub cboModoPagoSeña_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModoPagoSeña.SelectedIndexChanged
        epError.SetError(cboModoPagoSeña, "")
    End Sub

    Private Sub btnEditarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarPrecioFiesta.Click
        txtPrecioFiesta.Visible = True
        btnGuardarPrecioFiesta.Visible = True
        txtPrecioFiesta.Text = PrecioTotal
        btnAgregarDatos.Enabled = False
    End Sub

    Private Sub btnGuardarPrecioFiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPrecioFiesta.Click
        PrecioTotal = txtPrecioFiesta.Text
        txtPrecioFiesta.Visible = False
        btnGuardarPrecioFiesta.Visible = False
        lblPrecioFiesta.Text = PrecioTotal
        btnAgregarDatos.Enabled = True
    End Sub

    Private Sub txtPrecioFiesta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioFiesta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub

    Private Sub nudCantidadPersonas_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nudCantidadPersonas.Validating
        avisarSiEstaVacio(nudCantidadPersonas)
    End Sub

    Private Sub nudCantidadPersonas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudCantidadPersonas.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
        If nudCantidadPersonas.Text.Length > 2 Then
            e.Handled = True And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txtNroRecibo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRecibo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(cboCuotas.Text)
    End Sub

    Private Sub llblMotivoReserva1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblMotivoReserva1.LinkClicked
        AbrirMenuConDatosReservas(llblMotivoReserva1)
    End Sub

    Private Sub llblMotivoReserva2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblMotivoReserva2.LinkClicked
        AbrirMenuConDatosReservas(llblMotivoReserva2)
    End Sub

    Private Sub llblMotivoReserva3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblMotivoReserva3.LinkClicked
        AbrirMenuConDatosReservas(llblMotivoReserva3)
    End Sub

    Private Sub chkUtilizarDineroAFavor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUtilizarDineroAFavor.CheckedChanged
        chkDineroAFavorCambiovalor()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mysql.Consultar("select ID_RESERVA from reservas where comienzo>final and fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "'")
        reservaInvertida = mysql.Resultado
        MsgBox(reservaInvertida.Rows(0).Item("ID_RESERVA"))
    End Sub

End Class