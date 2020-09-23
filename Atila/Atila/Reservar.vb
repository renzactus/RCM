Public Class Reservar
    Dim booleanTelefonos As Boolean
    Dim mysql As New MySQL
    Dim telefonos As String
    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Probarconexion()
    End Sub

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        If txtTelefono2.Text <> "" Then
            telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            telefonos = txtTelefono1.Text
        End If
        mysql.Consulta = "insert into clientes (cedula,nombre,telefonos,direccion) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" & telefonos & "','" & txtDireccion.Text & "')"
        mysql.Probarconexion()
        mysql.InsertarDatos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        'PARA PONER VISIBLE EL txtTelefonos2 Y MOVER DE LUGAR txtDireccion y lblDireccion
        If booleanTelefonos = False Then
            txtTelefono2.Visible = True
            btnAgregarTelefonos.Text = "-"
            booleanTelefonos = True
            txtDireccion.Location = New Point(txtDireccion.Location.X, txtDireccion.Location.Y + 27)
            lblDireccion.Location = New Point(lblDireccion.Location.X, lblDireccion.Location.Y + 27)
        ElseIf booleanTelefonos = True Then
            txtTelefono2.Visible = False
            btnAgregarTelefonos.Text = "+"
            txtTelefono2.Text = ""
            booleanTelefonos = False
            txtDireccion.Location = New Point(txtDireccion.Location.X, txtDireccion.Location.Y - 27)
            lblDireccion.Location = New Point(lblDireccion.Location.X, lblDireccion.Location.Y - 27)
        End If



    End Sub
End Class