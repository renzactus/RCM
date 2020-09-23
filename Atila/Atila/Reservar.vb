Public Class Reservar
    Dim contadorTelefonos As Integer
    Dim mysql As New MySQL
    Private Sub cuadroNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Probarconexion()
        contadorTelefonos = 0
    End Sub

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        mysql.Consulta = "insert into clientes (nombre,telefonos,direccion) values('" & txtNombre.Text & "',200,2)"
        mysql.Probarconexion()
        mysql.InsertarDatos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        '
        If contadorTelefonos = 0 Then
            txtTelefono2.Visible = True
            btnRestarTelefonos.Visible = True
            contadorTelefonos = contadorTelefonos + 1
        ElseIf contadorTelefonos = 1 Then
            txtTelefono3.Visible = True
            btnAgregarTelefonos.Enabled = False
            contadorTelefonos = contadorTelefonos + 1
        End If

    End Sub

    Private Sub botonRestarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestarTelefonos.Click
        If contadorTelefonos = 1 Then
            txtTelefono2.Visible = False
            btnAgregarTelefonos.Enabled = True
            contadorTelefonos = contadorTelefonos - 1
        ElseIf contadorTelefonos = 2 Then
            txtTelefono3.Visible = False
            btnAgregarTelefonos.Enabled = True
            contadorTelefonos = 0
            contadorTelefonos = contadorTelefonos - 1
        End If
    End Sub
End Class