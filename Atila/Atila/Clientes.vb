Public Class Clientes
    Dim CompletarCedula, CompletarNombre, CompletarTelefono As New AutoCompleteStringCollection()
    Dim mysql As New MySQL
    Dim booleanTelefonos, booleanClienteExistente, booleanNoCambiarSeleccion, booleanSiNoCoincideFiltrar As Boolean
    Dim DatosClientes As DataTable
    Dim FilaNumero, FilaSeleccionada As Integer
    Dim Telefonoss As String
    Dim objetoDatosReservas As Object
    'Constructor
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        booleanNoCambiarSeleccion = True
        With txtCedula
            .AutoCompleteCustomSource = CompletarCedula
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        ActualizarDatosCliente()
        actualizardgv()
        AutoCompletar()
        autocompletarFiltrarNombre()
        autocompletarFiltrarCedula()
        autocompletarFiltrarTelefono()
        booleanNoCambiarSeleccion = False
    End Sub

    'Otro
    Private Sub SaberFilaSeleccionada()
        FilaSeleccionada = vbNull
        If dgvClientes.SelectedRows.Count > 0 Then
            FilaSeleccionada = dgvClientes.CurrentRow.Index
        End If
    End Sub
    Private Sub HabilitarTodo(ByVal valor As Boolean)
        If rboNombre.Checked = True Then
            btnFiltrarNombre.Enabled = valor
            txtFiltrarNombre.Enabled = valor
        ElseIf rboCedula.Checked = True Then
            btnFiltrarCedula.Enabled = valor
            txtFiltrarCedula.Enabled = valor
        ElseIf rboTelefono.Checked = True Then
            btnFiltrarTelefono.Enabled = valor
            txtFiltrarTelefono.Enabled = valor
        End If
        rboCedula.Enabled = valor
        rboNombre.Enabled = valor
        rboTelefono.Enabled = valor
        dgvReservas.Enabled = valor
        dgvClientes.Enabled = valor
    End Sub
    'actualizando Datos
    Private Sub ActualizarDatosCliente()
        mysql.Consultar("select cedula,nombre,telefonos,direccion,dinero_a_favor,fecha,CLIENTES.id_cliente from clientes inner join reservas on reservas.ID_CLIENTE=clientes.ID_CLIENTE where ingresodatos=any(select max(ingresodatos) from reservas group by id_cliente);")
        If mysql.Consultado = True Then
            DatosClientes = mysql.Resultado
        End If
    End Sub
    Private Sub actualizardgv()
        Dim Fecha As String
        dgvClientes.Rows.Clear()
        For i = 0 To DatosClientes.Rows.Count - 1
            Fecha = DatosClientes.Rows(i).Item("fecha")
            dgvClientes.Rows.Add(DatosClientes.Rows(i).Item("cedula"), DatosClientes.Rows(i).Item("nombre"), DatosClientes.Rows(i).Item("telefonos"),
                                 DatosClientes.Rows(i).Item("direccion"), DatosClientes.Rows(i).Item("dinero_a_favor"), Fecha)
        Next
        dgvClientes.Rows(0).Selected = False
    End Sub

    'AutoCompletar y editar
    Private Sub OcultarOtroTelefono()
        txtTelefono2.Visible = False
        btnAgregarTelefonos.Text = "+"
        txtTelefono2.Text = ""
        booleanTelefonos = False
        txtDireccion.Location = New Point(txtDireccion.Location.X, 195)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 181)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 226)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 226)
    End Sub
    Private Sub MostrarOtroTelefono()
        txtTelefono2.Visible = True
        btnAgregarTelefonos.Text = "-"
        booleanTelefonos = True
        txtDireccion.Location = New Point(txtDireccion.Location.X, 224)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 210)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 250)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 250)
    End Sub
    
    Private Sub AutoCompletar()
        For i = 0 To DatosClientes.Rows.Count - 1
            CompletarCedula.Add(DatosClientes.Rows(i).Item("cedula"))
        Next
    End Sub
    Private Sub btnAgregarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        If booleanTelefonos = False Then
            MostrarOtroTelefono()
        ElseIf booleanTelefonos = True Then
            OcultarOtroTelefono()
        End If
    End Sub
    Private Sub AutorellenarClienteSiLaCedulaCoincide()

        booleanClienteExistente = False
        For i = 0 To DatosClientes.Rows.Count - 1
            If txtCedula.Text <> "" Then


                If txtCedula.Text = DatosClientes.Rows(i).Item("cedula") Then

                    booleanNoCambiarSeleccion = True
                    dgvClientes.Rows(i).Selected = True
                    booleanNoCambiarSeleccion = False
                    FilaNumero = i
                    booleanClienteExistente = True
                    DeshabilitarEdicionDatosCliente(False)
                    txtNombre.Text = DatosClientes.Rows(i).Item("nombre")
                    txtDireccion.Text = DatosClientes.Rows(i).Item("direccion")

                    actualizardgvReservas()

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
                        lblMostrarDineroAFavor.Text = DatosClientes.Rows(i).Item("dinero_a_favor")
                    Else
                        lblDineroAFavor.Visible = False
                        lblMostrarDineroAFavor.Visible = False
                        lblMostrarDineroAFavor.Text = ""
                    End If
                Else


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
                OcultarOtroTelefono()
                booleanNoCambiarSeleccion = True
                dgvReservas.Rows.Clear()
                dgvClientes.Rows(FilaNumero).Selected = False
                booleanNoCambiarSeleccion = False
            End If
        Next
    End Sub
    Private Sub DeshabilitarEdicionDatosCliente(ByVal estado As Boolean)
        txtDireccion.Enabled = estado
        txtNombre.Enabled = estado
        txtTelefono1.Enabled = estado
        txtTelefono2.Enabled = estado
        btnAgregarTelefonos.Enabled = estado
        btnEditarCliente.Visible = Not estado
    End Sub
    Private Sub actualizardgvReservas()
        Dim cancelada As Boolean
        Dim Fecha As String
        mysql.Consultar("select ID_RESERVA,motivo,fecha,cantidad_personas,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final,fecha_cancelacion " &
                        "from reservas where ID_CLIENTE=" & DatosClientes.Rows(FilaNumero).Item("ID_CLIENTE"))
        For i = 0 To mysql.Resultado.Rows.Count - 1
            Fecha = mysql.Resultado.Rows(i).Item("fecha")
            If IsDBNull(mysql.Resultado.Rows(i).Item("fecha_cancelacion")) Then
                cancelada = False
            Else
                cancelada = True
            End If
            dgvReservas.Rows.Add(mysql.Resultado.Rows(i).Item("motivo"), Fecha, mysql.Resultado.Rows(i).Item("cantidad_personas"),
                                 mysql.Resultado.Rows(FilaNumero).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(FilaNumero).Item("final").ToString, cancelada)
        Next
    End Sub

    Private Sub autocompletarFiltrarNombre()
        With txtFiltrarNombre
            .AutoCompleteCustomSource = CompletarNombre
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        For i = 0 To DatosClientes.Rows.Count - 1
            CompletarNombre.Add(DatosClientes.Rows(i).Item("nombre"))
        Next
    End Sub
    Private Sub autocompletarFiltrarCedula()
        With txtFiltrarCedula
            .AutoCompleteCustomSource = CompletarCedula
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub
    Private Sub autocompletarFiltrarTelefono()
        Dim telefonos As String
        With txtFiltrarTelefono
            .AutoCompleteCustomSource = CompletarTelefono
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        For i = 0 To DatosClientes.Rows.Count - 1
            telefonos = DatosClientes.Rows(i).Item("telefonos")
            If telefonos.IndexOf("|") = -1 Then
                CompletarTelefono.Add(telefonos)
            Else
                CompletarTelefono.Add(telefonos.Substring(0, telefonos.IndexOf("|")))
                CompletarTelefono.Add(telefonos.Substring(telefonos.IndexOf("|") + 1))
            End If

        Next
    End Sub
    'Filtrar por
    Private Sub FiltrarPorNombreoCedula(ByVal txtbox As TextBox, ByVal dato As String)
        If txtbox.Text <> "" Then
            booleanSiNoCoincideFiltrar = False
            For i = 0 To DatosClientes.Rows.Count - 1
                If txtbox.Text = DatosClientes.Rows(i).Item(dato) Then
                    epError.SetError(txtbox, "")
                    txtCedula.Text = DatosClientes.Rows(i).Item("cedula")
                    AutorellenarClienteSiLaCedulaCoincide()
                    booleanSiNoCoincideFiltrar = True
                    FilaNumero = i
                End If
            Next
            If booleanSiNoCoincideFiltrar = False Then
                epError.SetError(txtbox, "No se encuentra")
                Reservar.sonidoError()
                booleanNoCambiarSeleccion = True
                vaciarEditorCliente()
                booleanNoCambiarSeleccion = False
            End If
        Else
            epError.SetError(txtbox, "Completa el cuadro")
        End If
        
    End Sub
    Private Sub FiltrarPorTelefono()
        Dim telefonos As String
        booleanSiNoCoincideFiltrar = False
        For i = 0 To DatosClientes.Rows.Count - 1
            telefonos = DatosClientes.Rows(i).Item("telefonos")
            If telefonos.IndexOf("|") = -1 Then


                If txtFiltrarTelefono.Text = telefonos Then
                    epError.SetError(txtFiltrarTelefono, "")
                    txtCedula.Text = DatosClientes.Rows(i).Item("cedula")
                    AutorellenarClienteSiLaCedulaCoincide()
                    booleanSiNoCoincideFiltrar = True
                    FilaNumero = i
                End If


            Else


                If txtFiltrarTelefono.Text = telefonos Or txtFiltrarTelefono.Text = telefonos.Substring(0, telefonos.IndexOf("|")) Or txtFiltrarTelefono.Text = telefonos.Substring(telefonos.IndexOf("|") + 1) Then
                    epError.SetError(txtFiltrarTelefono, "")
                    txtCedula.Text = DatosClientes.Rows(i).Item("cedula")
                    AutorellenarClienteSiLaCedulaCoincide()
                    booleanSiNoCoincideFiltrar = True
                    FilaNumero = i
                End If


            End If
        Next
        If booleanSiNoCoincideFiltrar = False Then
            epError.SetError(txtFiltrarTelefono, "No se encuentra")
            Reservar.sonidoError()
            booleanNoCambiarSeleccion = True
            vaciarEditorCliente()
            booleanNoCambiarSeleccion = False
        End If
    end sub
    Private Sub vaciarEditorCliente()
        btnEditarCliente.Visible = False
        lblEditandoCliente.Visible = False
        dgvClientes.Rows(FilaNumero).Selected = False
        txtNombre.Text = ""
        txtCedula.Text = ""
        txtDireccion.Text = ""
        txtTelefono1.Text = ""
        txtTelefono2.Text = ""
        lblMostrarDineroAFavor.Text = ""
        lblDineroAFavor.Visible = False

        dgvReservas.Rows.Clear()
    End Sub
    Private Sub vaciaryDesmarcarrbo()
        epError.SetError(txtFiltrarCedula, "")
        rboCedula.Checked = False
        txtFiltrarCedula.Text = ""
        txtFiltrarCedula.Enabled = False
        btnFiltrarCedula.Enabled = False
        epError.SetError(txtFiltrarNombre, "")
        rboNombre.Checked = False
        txtFiltrarNombre.Text = ""
        txtFiltrarNombre.Enabled = False
        btnFiltrarNombre.Enabled = False
        epError.SetError(txtFiltrarTelefono, "")
        rboTelefono.Checked = False
        txtFiltrarTelefono.Text = ""
        txtFiltrarTelefono.Enabled = False
        btnFiltrarTelefono.Enabled = False

    End Sub
    'Eventos
    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtCedula.Text.Length > 7 Then
            If txtCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        AutorellenarClienteSiLaCedulaCoincide()
    End Sub

    Private Sub btnEditarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCliente.Click
        lblEditandoCliente.Visible = True
        btnGuardarCliente.Visible = True
        txtCedula.Enabled = False
        btnCancelarEdicion.Visible = True
        HabilitarTodo(False)
        DeshabilitarEdicionDatosCliente(True)
    End Sub

    Private Sub btnGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCliente.Click
        If txtTelefono2.Text <> "" Then
            Telefonoss = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            Telefonoss = txtTelefono1.Text
        End If
        mysql.InsertarDatos("update clientes set nombre='" & txtNombre.Text & "', telefonos='" & Telefonoss & "', direccion='" & txtDireccion.Text & "' where cedula=" & txtCedula.Text)
        If mysql.Consultado = True Then
            If btnAgregarTelefonos.Text = "-" And txtTelefono2.Text = "" Then
                OcultarOtroTelefono()
            End If
            lblEditandoCliente.Visible = False
            btnGuardarCliente.Visible = False
            btnCancelarEdicion.Visible = False
            txtCedula.Enabled = True
            DeshabilitarEdicionDatosCliente(False)
            HabilitarTodo(True)
            ActualizarDatosCliente()
            booleanNoCambiarSeleccion = True
            actualizardgv()
            booleanNoCambiarSeleccion = False
            AutoCompletar()
        End If
    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        AutorellenarClienteSiLaCedulaCoincide()
        lblEditandoCliente.Visible = False
        btnGuardarCliente.Visible = False
        btnCancelarEdicion.Visible = False
        txtCedula.Enabled = True
        DeshabilitarEdicionDatosCliente(False)
        HabilitarTodo(True)
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If booleanNoCambiarSeleccion = False Then
            SaberFilaSeleccionada()
            txtCedula.Text = dgvClientes.Rows(FilaSeleccionada).Cells(0).Value
            AutorellenarClienteSiLaCedulaCoincide()
            vaciaryDesmarcarrbo()
        End If

    End Sub

    Private Sub btnFiltrarNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarNombre.Click
        booleanNoCambiarSeleccion = True
        FiltrarPorNombreoCedula(txtFiltrarNombre, "nombre")
        booleanNoCambiarSeleccion = False
    End Sub

    Private Sub rboNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboNombre.Click
        vaciaryDesmarcarrbo()
        rboNombre.Checked = True
        btnFiltrarNombre.Enabled = True
        txtFiltrarNombre.Enabled = True

    End Sub

    Private Sub rboCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboCedula.Click
        vaciaryDesmarcarrbo()
        rboCedula.Checked = True
        btnFiltrarCedula.Enabled = True
        txtFiltrarCedula.Enabled = True
    End Sub

    Private Sub rboTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboTelefono.Click
        vaciaryDesmarcarrbo()
        rboTelefono.Checked = True
        btnFiltrarTelefono.Enabled = True
        txtFiltrarTelefono.Enabled = True
    End Sub

    Private Sub btnFiltrarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarCedula.Click
        FiltrarPorNombreoCedula(txtFiltrarCedula, "cedula")
    End Sub

    Private Sub btnFiltrarTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarTelefono.Click
        FiltrarPorTelefono()
    End Sub

    Private Sub txtFiltrarTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltrarTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtFiltrarTelefono.Text.Length > 8 Then
            If txtFiltrarTelefono.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtFiltrarCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltrarCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtFiltrarCedula.Text.Length > 7 Then
            If txtFiltrarCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

End Class