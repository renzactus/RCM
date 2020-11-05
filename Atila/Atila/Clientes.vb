Public Class Clientes
    Dim CompletarCedula, CompletarNombre, CompletarTelefono As New AutoCompleteStringCollection()
    Dim mysql As New MySQL
    Dim booleanTelefonos, booleanClienteExistente, booleanNoCambiarSeleccion, booleanSiNoCoincideFiltrar, booleanNoActualizarTabla As Boolean
    Dim DatosClientes As DataTable
    Dim FilaNumero, FilaSeleccionada As Integer
    Dim Telefonoss As String
    Dim objetoDatosReservas As Object
    'Constructor
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstablecerColores()
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

        rboCedula.Enabled = True
        rboNombre.Enabled = True
        rboTelefono.Enabled = True
    End Sub
    'Diseño
    Private Sub EstablecerColores()
        Me.BackColor = Principal.colorSecundario
        lblClientes.ForeColor = Principal.colorTitulos
        lblDatos.ForeColor = Principal.colorTitulos
        lblDineroAFavor.ForeColor = Principal.colorTitulos
        lblReservasQueRealizo.ForeColor = Principal.colorTitulos
        lblFIltrarClientePor.ForeColor = Principal.colorTitulos
        btnFiltrarCedula.ForeColor = Principal.colorTitulos
        btnFiltrarNombre.ForeColor = Principal.colorTitulos
        btnFiltrarTelefono.ForeColor = Principal.colorTitulos
        btnEditarCliente.ForeColor = Principal.colorTitulos
        btnCancelarEdicion.ForeColor = Principal.colorTitulos
        btnGuardarCliente.ForeColor = Principal.colorTitulos
        btnEditarDinero.ForeColor = Principal.colorTitulos
        btnCancelarDinero.ForeColor = Principal.colorTitulos
        btnGuardarDinero.ForeColor = Principal.colorTitulos
        dgvClientes.BackgroundColor = Principal.colorTerceario
        dgvReservas.BackgroundColor = Principal.colorTerceario
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
        btnEditarDinero.Enabled = valor
        rboCedula.Enabled = valor
        rboNombre.Enabled = valor
        rboTelefono.Enabled = valor
        dgvReservas.Enabled = valor
        dgvClientes.Enabled = valor
    End Sub
    'actualizando Datos
    Private Sub ActualizarDatosCliente()
        mysql.Consultar("select cedula,nombre,telefonos,direccion,dinero_a_favor,fecha,CLIENTES.id_cliente from clientes" &
                        " inner join reservas on reservas.ID_CLIENTE=clientes.ID_CLIENTE where ingresodatos=any(select" &
                        " max(ingresodatos) from reservas group by id_cliente);")
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
    Private Sub MostrarOtroTelefono()
        pbTelefono2.Visible = True
        txtTelefono2.Visible = True
        btnAgregarTelefonos.Text = "-"
        booleanTelefonos = True
        txtDireccion.Location = New Point(txtDireccion.Location.X, 337)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 337)
        pbDireccion.Location = New Point(pbDireccion.Location.X, 335)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 395)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 392)
        txtDineroAFavor.Location = New Point(txtDineroAFavor.Location.X, 395)
        btnEditarDinero.Location = New Point(btnEditarDinero.Location.X, 395)
        btnGuardarDinero.Location = New Point(btnGuardarDinero.Location.X, 395)
        btnCancelarDinero.Location = New Point(btnCancelarDinero.Location.X, 395)
    End Sub
    Private Sub OcultarOtroTelefono()
        pbTelefono2.Visible = False
        txtTelefono2.Visible = False
        btnAgregarTelefonos.Text = "+"
        txtTelefono2.Text = ""
        booleanTelefonos = False
        txtDireccion.Location = New Point(txtDireccion.Location.X, 297)
        lblDireccion.Location = New Point(lblDireccion.Location.X, 297)
        pbDireccion.Location = New Point(pbDireccion.Location.X, 295)

        lblDineroAFavor.Location = New Point(lblDineroAFavor.Location.X, 349)
        lblMostrarDineroAFavor.Location = New Point(lblMostrarDineroAFavor.Location.X, 346)
        txtDineroAFavor.Location = New Point(txtDineroAFavor.Location.X, 346)
        btnEditarDinero.Location = New Point(btnEditarDinero.Location.X, 349)
        btnGuardarDinero.Location = New Point(btnGuardarDinero.Location.X, 349)
        btnCancelarDinero.Location = New Point(btnCancelarDinero.Location.X, 349)
    End Sub
    
    Private Sub AutoCompletar()
        For i = 0 To DatosClientes.Rows.Count - 1
            CompletarCedula.Add(DatosClientes.Rows(i).Item("cedula"))
        Next
    End Sub
    Private Sub AutorellenarClienteSiLaCedulaCoincide()

        booleanClienteExistente = False
        For i = 0 To DatosClientes.Rows.Count - 1
            If txtCedula.Text <> "" Then


                If txtCedula.Text = DatosClientes.Rows(i).Item("cedula") Then
                    btnEditarDinero.Enabled = True
                    btnGuardarDinero.Enabled = True
                    btnCancelarDinero.Enabled = True
                    booleanNoCambiarSeleccion = True
                    dgvClientes.Rows(i).Selected = True
                    booleanNoCambiarSeleccion = False
                    FilaNumero = i
                    booleanClienteExistente = True
                    DeshabilitarEdicionDatosCliente(False)
                    txtNombre.Text = DatosClientes.Rows(i).Item("nombre")
                    txtDireccion.Text = DatosClientes.Rows(i).Item("direccion")
                    lblMostrarDineroAFavor.Text = String.Format("{0:N0}", DatosClientes.Rows(i).Item("dinero_a_favor"))
                    If booleanNoActualizarTabla = False Then
                        actualizardgvReservas()
                    End If

                    If DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|") <> -1 Then 'Si el usuario tiene dos telefonos
                        MostrarOtroTelefono()
                        txtTelefono1.Text = DatosClientes.Rows(i).Item("telefonos").ToString.Substring(0, DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|"))
                        txtTelefono2.Text = DatosClientes.Rows(i).Item("telefonos").ToString.Substring(DatosClientes.Rows(i).Item("telefonos").ToString.IndexOf("|") + 1)
                    Else
                        txtTelefono1.Text = DatosClientes.Rows(i).Item("telefonos").ToString
                        OcultarOtroTelefono()
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
        dgvReservas.Rows.Clear()
        Dim cancelada As Boolean
        Dim Fecha As String
        Dim datosReservasDeCli As DataTable
        datosReservasDeCli = mysql.Consultar("select ID_RESERVA,motivo,fecha,cantidad_personas,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final,fecha_cancelacion " &
                        "from reservas where ID_CLIENTE=" & DatosClientes.Rows(FilaNumero).Item("ID_CLIENTE") & " order by fecha desc")
        For i = 0 To datosReservasDeCli.Rows.Count - 1
            Fecha = datosReservasDeCli.Rows(i).Item("fecha")
            If IsDBNull(datosReservasDeCli.Rows(i).Item("fecha_cancelacion")) Then
                cancelada = False
            Else
                cancelada = True
            End If
            dgvReservas.Rows.Add(datosReservasDeCli.Rows(i).Item("motivo"), Fecha, datosReservasDeCli.Rows(i).Item("cantidad_personas"),
                                 datosReservasDeCli.Rows(i).Item("comienzo").ToString & " - " & datosReservasDeCli.Rows(i).Item("final").ToString, cancelada)
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
    Private Sub vaciarTodo()
        vaciaryDesmarcarrbo()
        vaciarEditorCliente()
        dgvReservas.Rows.Clear()
        SaberFilaSeleccionada()
        booleanNoCambiarSeleccion = True
        dgvClientes.Rows(FilaSeleccionada).Selected = False
        booleanNoCambiarSeleccion = False
    End Sub

    'Eventos
    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtCedula.Text.Length > 7 Then
            If txtCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        AutorellenarClienteSiLaCedulaCoincide()
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
        vaciarTodo()

        rboNombre.Checked = True
        btnFiltrarNombre.Enabled = True
        txtFiltrarNombre.Enabled = True
    End Sub

    Private Sub rboCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboCedula.Click
        vaciarTodo()

        vaciaryDesmarcarrbo()
        rboCedula.Checked = True
        btnFiltrarCedula.Enabled = True
        txtFiltrarCedula.Enabled = True
    End Sub

    Private Sub rboTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rboTelefono.Click
        vaciarTodo()

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

    Private Sub btnEditarDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarDinero.Click
        btnEditarDinero.Visible = False
        HabilitarTodo(False)
        btnCancelarDinero.Visible = True
        txtDineroAFavor.Text = DatosClientes.Rows(FilaNumero).Item("dinero_a_favor")
        txtDineroAFavor.Visible = True
        btnGuardarDinero.Visible = True
        btnEditarCliente.Enabled = False
        txtCedula.Enabled = False
    End Sub

    Private Sub btnGuardarDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDinero.Click
        mysql.InsertarDatos("update clientes set dinero_a_favor=" & txtDineroAFavor.Text & " where ID_CLIENTE=" & DatosClientes.Rows(FilaNumero).Item("ID_CLIENTE"))
        ActualizarDatosCliente()
        booleanNoCambiarSeleccion = True
        booleanNoCambiarSeleccion = False
        booleanNoActualizarTabla = False
        AutorellenarClienteSiLaCedulaCoincide()
        btnCancelarDinero.Visible = False
        btnGuardarDinero.Visible = False
        txtDineroAFavor.Visible = False
        btnEditarDinero.Visible = True
        btnEditarCliente.Enabled = True
        HabilitarTodo(True)
    End Sub

    Private Sub btnCancelarDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDinero.Click
        btnCancelarDinero.Visible = False
        btnGuardarDinero.Visible = False
        txtDineroAFavor.Visible = False
        btnEditarDinero.Visible = True
        btnEditarCliente.Enabled = True
        HabilitarTodo(True)
    End Sub

    Private Sub txtTelefono1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtTelefono1.Text.Length > 8 Then
            If txtTelefono1.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtTelefono2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
        If txtTelefono2.Text.Length > 8 Then
            If txtTelefono2.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtDineroAFavor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR
    End Sub

    Private Sub btnEditarCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCliente.Click
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
            DeshabilitarEdicionDatosCliente(False)
            HabilitarTodo(True)
            ActualizarDatosCliente()
            booleanNoCambiarSeleccion = True
            actualizardgv()
            booleanNoCambiarSeleccion = False
            AutoCompletar()
        End If
    End Sub

    Private Sub btnCancelarEdicion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        AutorellenarClienteSiLaCedulaCoincide()
        lblEditandoCliente.Visible = False
        btnGuardarCliente.Visible = False
        btnCancelarEdicion.Visible = False
        DeshabilitarEdicionDatosCliente(False)
        HabilitarTodo(True)
    End Sub

    Private Sub btnAgregarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        If booleanTelefonos = False Then
            MostrarOtroTelefono()
        ElseIf booleanTelefonos = True Then
            OcultarOtroTelefono()
        End If
    End Sub

End Class