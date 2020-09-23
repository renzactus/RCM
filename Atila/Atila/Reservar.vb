Public Class Reservar
    Dim mysql As New MySQL
    Private Sub cuadroNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuadroNombre.TextChanged

    End Sub

    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql.Probarconexion()
    End Sub

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonAgregarDatos.Click
        mysql.Consulta = "insert into inventario (descripcion,precio,cantidad) values('item1',200,2)"
        mysql.Probarconexion()
        mysql.InsertarDatos()
    End Sub
End Class