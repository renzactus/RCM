Public Class Clientes
    Dim AutoCompletarCedula As New AutoCompleteStringCollection()
    Dim mysql As New MySQL
    Dim booleanTelefonos, booleanClienteExistente As Boolean
    Dim DatosClientes As DataTable
    Dim FilaNumero As Integer
    Dim Telefonoss As String
    'Constructor
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With txtCedula
            .AutoCompleteCustomSource = AutoCompletarCedula
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        actualizarNegritas()
        ActualizarDatosCliente()
        AutoCompletar()
    End Sub

    'Metodos Utilizaedos
    Private Sub actualizarNegritas()
        mysql.Consultar("select distinct fecha from reservas where fecha_cancelacion is null")
        If mysql.Consultado = True Then
            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
        End If
    End Sub
    'AutoCompletar
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
    Private Sub btnAgregarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        If booleanTelefonos = False Then
            MostrarOtroTelefono()
        ElseIf booleanTelefonos = True Then
            OcultarOtroTelefono()
        End If
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

                    End If
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
                DeshabilitarEdicionDatosCliente(True)
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
    'Edicion

    'Eventos
    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        If txtCedula.Text.Length > 7 Then
            If txtCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        AutorellenarCliente()
    End Sub

    Private Sub btnEditarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCliente.Click
        lblEditandoCliente.Visible = True
        btnGuardarCliente.Visible = True
        txtCedula.Enabled = False
        btnCancelarEdicion.Visible = True
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
            txtCedula.Enabled = True
            DeshabilitarEdicionDatosCliente(False)
            ActualizarDatosCliente()
            AutoCompletar()
        End If
    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        AutorellenarCliente()
        lblEditandoCliente.Visible = False
        btnGuardarCliente.Visible = False
        btnCancelarEdicion.Visible = False
        txtCedula.Enabled = True
        DeshabilitarEdicionDatosCliente(False)
    End Sub
End Class