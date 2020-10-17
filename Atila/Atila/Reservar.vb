
Public Class Reservar
    Dim booleanTelefonos, booleanClaseConstruida, booleanErrorEndgv, booleanClienteExistente As Boolean
    Dim mysql As New MySQL
    Dim telefonos As String
    Dim Inventario, DatosClientes As DataTable
    Dim cuotas As String
    Dim AutoCompletarCedula As New AutoCompleteStringCollection()
    Private Sub MostrarReservasDelDia()
        lblFecha.Text = Calendario.SelectionRange.Start
        lblNoHayReservas.Visible = True
        llblMotivoReserva1.Visible = False
        llblMotivoReserva2.Visible = False
        llblMotivoReserva3.Visible = False
        lblHora1.Visible = False
        lblHora2.Visible = False
        lblHora3.Visible = False
        mysql.Consultar("select motivo,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "';")
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
                lblHora1.Text = mysql.Resultado.Rows(1).Item("comienzo") & "-" & mysql.Resultado.Rows(1).Item("final")
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
    End Sub
    Private Sub OcultarOtroTelefono()
        txtTelefono2.Visible = False
        btnAgregarTelefonos.Text = "+"
        txtTelefono2.Text = ""
        booleanTelefonos = False
        txtDireccion.Location = New Point(txtDireccion.Location.X, 183)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 169)
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
                End If
            End If
            If booleanClienteExistente = False Then
                booleanClienteExistente = False
                txtNombre.Text = ""
                txtDireccion.Text = ""
                txtTelefono1.Text = ""
                txtTelefono2.Text = ""
                OcultarOtroTelefono()
                DeshabilitarEdicionDatosCliente(True)
            End If
        Next
    End Sub
    Private Sub ActualizarDatosClienteyAutoRellenar()
        mysql.Consultar("select * from clientes")
        If mysql.Consultado = True Then
            DatosClientes = mysql.Resultado
        End If
        For i = 0 To DatosClientes.Rows.Count - 1
            AutoCompletarCedula.Add(DatosClientes.Rows(i).Item("cedula"))
        Next
    End Sub
    Private Sub AvisarSiEstaVacio(ByVal txtBox As TextBox)
        If txtBox.Text = "" Then
            epError.SetError(txtBox, "Porfavor, Complete los datos de " & txtBox.Name.Substring(3))
        Else
            epError.SetError(txtBox, "")
        End If
    End Sub

    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With txtCedula
            .AutoCompleteCustomSource = AutoCompletarCedula
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        Me.BackColor = Color.FromArgb(191, 128, 130)
        Calendario.MinDate = DateAndTime.Today
        Calendario.MaxDate = DateAdd("yyyy", 3, DateAndTime.Today)
        mysql.Consultar("select distinct fecha from reservas")
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

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        If txtCedula.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "" Or txtTelefono1.Text = "" Then
            AvisarSiEstaVacio(txtCedula)
            AvisarSiEstaVacio(txtNombre)
            AvisarSiEstaVacio(txtDireccion)
            AvisarSiEstaVacio(txtTelefono1)
            If btnAgregarTelefonos.Text = "-" Then
                AvisarSiEstaVacio(txtTelefono2)
            End If
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        Else 'Si no hay cuadros incompletos
            If optPagado.Checked = False And optSeñar.Checked = False Then
                epError.SetError(optPagado, "Porfavor, Marque y complete alguna de las dos opciones")
                epError.SetError(optSeñar, "Porfavor, Marque y complete alguna de las dos opciones")
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Else 'Si
                telefonos = vbNull
                cuotas = vbNull
                If cboCuotas.Text = "Ninguna" Then
                    cuotas = vbNull
                Else
                    cuotas = cboCuotas.Text
                End If
                If booleanClienteExistente = False Then
                    If txtTelefono2.Text <> "" Then
                        telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
                    Else
                        telefonos = txtTelefono1.Text
                    End If
                    mysql.InsertarDatos("insert into clientes (cedula,nombre,telefonos,direccion) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" &
                        telefonos & "','" & txtDireccion.Text & "')") 'Agregamos el cliente
                End If
                If optSeñar.Checked = True And txtSeña.Text <> "" And txtSeña.Text <= lblPrecioFiesta.Text Then
                    mysql.InsertarDatos("insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE,FECHA_ACTUALIZACION,ingresodatos,ID_FUNCIONARIO,seña) values ('" &
                        cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dudHoraComienzo.Text & "','" & dudHoraFinal.Text & "'," &
                        dudCantidadPersonas.Text & "," & chkServicio.CheckState & ",(select ID_CLIENTE from clientes where nombre='" & txtNombre.Text & "'),(select max(FECHA_ACTUALIZACION) " &
                        "from costos),current_timestamp,(select ID_FUNCIONARIO from funcionarios where nombre='" & Principal.lblPerfil.Text & "')," & txtSeña.Text & ")") 'Agregamos las reservas con seña
                Else
                    mysql.InsertarDatos("insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE,FECHA_ACTUALIZACION,ingresodatos,ID_FUNCIONARIO) values ('" &
                        cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dudHoraComienzo.Text & "','" & dudHoraFinal.Text & "'," &
                        dudCantidadPersonas.Text & "," & chkServicio.CheckState & ",(select ID_CLIENTE from clientes where nombre='" & txtNombre.Text & "'),(select max(FECHA_ACTUALIZACION) " &
                        "from costos),current_timestamp,(select ID_FUNCIONARIO from funcionarios where nombre='" & Principal.lblPerfil.Text & "'))") 'Agregamos las reservas sin seña
                End If
                If optPagado.Checked = True Then
                    mysql.InsertarDatos("Insert into pagos (NRO_RECIBO,fecha_pago,cuotas,costo,forma,ID_RESERVA) values(" & txtNroRecibo.Text & ",current_date," &
                                        cuotas & "," & lblPrecioFiesta.Text & ",'" & cboModoPago.Text &
                                        "',(select id_reserva from reservas where ingresodatos=(select max(ingresodatos) from reservas)))")
                End If
                'Insertando datos de los inventarios que se utiilizaran
                For i = 0 To Inventario.Rows.Count - 1
                    If dgvInventario.Rows(i).Cells(0).Value = True Then
                        mysql.InsertarDatos("insert into utiliza (ID_RESERVA,ID_INVENTARIO,cantidad,precio) values((select ID_RESERVA from reservas where " &
                                            "ingresodatos=(select max(ingresodatos) from reservas))," & Inventario.Rows(i).Item("ID_INVENTARIO") & "," &
                                            dgvInventario.Rows(i).Cells(2).Value & "," & dgvInventario.Rows(i).Cells(2).Value * Inventario.Rows(i).Item("precio") & ")")
                    End If
                Next
                If mysql.Consultado = True Then
                    Me.Close()
                End If
            End If
        End If


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
        'Si hay algun tipo de problema con dgvInventario devolver booleanErrorEndgv=false para que no se ejecuten los demas chequeos
        booleanErrorEndgv = False
        For i = 0 To dgvInventario.Rows.Count - 1
            If dgvInventario.Rows(i).Cells(0).Value = True Then
                If dgvInventario.Rows(i).Cells(2).Value = "" Then
                    MsgBox("Desmarcar " & Inventario.Rows(i).Item("descripcion") & "o establecerle una cantidad")
                    booleanErrorEndgv = True
                ElseIf dgvInventario.Rows(i).Cells(2).Value > Inventario.Rows(i).Item("cantidad") Then
                    MsgBox("La cantidad de " & Inventario.Rows(i).Item("descripcion") & " tiene que ser menor a su maximo que es " & Inventario.Rows(i).Item("cantidad"))
                    booleanErrorEndgv = True
                    'Seleccionar la celda que esta mal
                    dgvInventario.Rows(i).Cells(2).Selected = True
                    dgvInventario.Select()
                End If
            End If
        Next
        If booleanErrorEndgv = False Then
            mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "'") 'Devuelve la id_reserva si la hora en esa fecha esta ocupada
            If mysql.Consultado = True Then
                If mysql.Resultado.Rows.Count() > 2 Then 'SI SE DEVOLVIERON 3 FILAS O MAS QUIERE DECIR QUE SE SUPERO EL MAXIMO DE RESERVAS EN UN DIA
                    MsgBox("Se supero el maximo de reservas en un día")
                Else
                    mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
                dudHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dudHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dudHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dudHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
                dudHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dudHoraFinal.Text & "'>addtime(final,'1:00:00')));")
                    If mysql.Consultado = True Then
                        If mysql.Resultado.Rows.Count() > 0 Then 'SI SE DEVOLVIO MAS DE UNA FILA QUIERE DECIR QUE YA HAY RESERVA PARA ESA FECHA y hora
                            MessageBox.Show("Horario Ocupado")
                        ElseIf dudHoraComienzo.Text = "" Or dudHoraFinal.Text = "" Or cboMotivo.Text = "Ingresar Motivo" Or dudCantidadPersonas.Text = "" Then
                            MsgBox("Campos Sin completar")

                        Else 'SI TODO LO DEMAS ESTA CORRECTO
                            pnlReserva.Visible = False
                            pnlCliente.Visible = True
                            'Actualizar Precio
                            mysql.Consultar("select * from costos where FECHA_ACTUALIZACION=(select max(FECHA_ACTUALIZACION) from costos)")
                            If mysql.Consultado = True Then
                                If cboMotivo.Text = "Fiesta de 15" Then
                                    lblPrecioFiesta.Text = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
                                ElseIf cboMotivo.Text = "Cumpleaño de niño" Then
                                    lblPrecioFiesta.Text = mysql.Resultado.Rows(0).Item("c_fiesta_infantil")
                                ElseIf cboMotivo.Text = "Parrillada" Then
                                    lblPrecioFiesta.Text = mysql.Resultado.Rows(0).Item("c_otro")
                                ElseIf cboMotivo.Text = "Graduación" Then
                                    lblPrecioFiesta.Text = mysql.Resultado.Rows(0).Item("c_fiesta_con_baile")
                                ElseIf cboMotivo.Text = "Otro" Then
                                    lblPrecioFiesta.Text = mysql.Resultado.Rows(0).Item("c_otro")
                                End If
                                lblPrecioFiesta.Text = lblPrecioFiesta.Text + mysql.Resultado.Rows(0).Item("c_precio_por_persona") * dudCantidadPersonas.Text
                                If Calendario.SelectionRange.Start.DayOfWeek = 5 Or Calendario.SelectionRange.Start.DayOfWeek = 6 Or Calendario.SelectionRange.Start.DayOfWeek = 0 Then
                                    lblPrecioFiesta.Text = lblPrecioFiesta.Text + lblPrecioFiesta.Text / 100 * mysql.Resultado.Rows(0).Item("porcentaje_findesemana")
                                End If
                            End If
                            'Agregar cedulas para autocompletar
                            ActualizarDatosClienteyAutoRellenar()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dudHoraComienz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudHoraComienzo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES
    End Sub

    Private Sub dudHoraFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudHoraFinal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES
    End Sub

    Private Sub dudCantidadPersonas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudCantidadPersonas.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtCedula.Text.Length > 7 Then
            e.Handled = IsNumeric(e.KeyChar)
        End If
    End Sub

    Private Sub txtTelefono1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub txtTelefono2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        MostrarReservasDelDia()
    End Sub

    Private Sub txtSeña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeña.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub dgvInventario_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventario.CellValueChanged
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
            btnAgregarDatos.Enabled = True
            lblEditandoCliente.Visible = False
            btnGuardarCliente.Visible = False
            txtCedula.Enabled = True
            DeshabilitarEdicionDatosCliente(False)
            ActualizarDatosClienteyAutoRellenar()
        End If
    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        AutorellenarCliente()
        btnAgregarDatos.Enabled = True
        lblEditandoCliente.Visible = False
        btnGuardarCliente.Visible = False
        txtCedula.Enabled = True
        DeshabilitarEdicionDatosCliente(False)
    End Sub

    Private Sub optSeñar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSeñar.CheckedChanged
        epError.SetError(optPagado, "")
        epError.SetError(optSeñar, "")
        If optSeñar.Checked = True Then
            txtSeña.Enabled = True
        Else
            txtSeña.Enabled = False
            txtSeña.Text = ""
        End If
    End Sub

    Private Sub optPagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPagado.CheckedChanged
        epError.SetError(optPagado, "")
        epError.SetError(optSeñar, "")
        If optPagado.Checked = True Then
            cboCuotas.Enabled = True
            txtNroRecibo.Enabled = True
        Else
            cboCuotas.Enabled = False
            txtNroRecibo.Enabled = False
            cboCuotas.SelectedIndex = -1
            txtNroRecibo.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Validar cedula
        Dim sumacedula As Integer
        sumacedula = (txtCedula.Text.Substring(0, 1) * 8) + (txtCedula.Text.Substring(1, 1) * 1) + (txtCedula.Text.Substring(2, 1) * 2) + (txtCedula.Text.Substring(3, 1) * 3) + (txtCedula.Text.Substring(4, 1) * 4) + (txtCedula.Text.Substring(5, 1) * 7) + (txtCedula.Text.Substring(6, 1) * 6)
        If txtCedula.Text.Substring(7) = sumacedula Mod 10 Then
            MsgBox("Cedula Correcta")
        Else
            MsgBox("Cedula Incorrecta")
        End If
    End Sub

    
    Private Sub txtCedula_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCedula.Validating
        AvisarSiEstaVacio(txtCedula)
    End Sub

    Private Sub txtTelefono2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono2.Validating
        If btnAgregarTelefonos.Text = "-" Then
            AvisarSiEstaVacio(txtTelefono2)
        End If
    End Sub

    Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        AvisarSiEstaVacio(txtNombre)
    End Sub

    Private Sub txtTelefono1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono1.Validating
        AvisarSiEstaVacio(txtTelefono1)
    End Sub

    Private Sub txtDireccion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        AvisarSiEstaVacio(txtDireccion)
    End Sub
End Class