Imports MySql.Data.MySqlClient
Public Class MySQL
    Public Consulta As String
    Public ComandoSql As New MySqlCommand
    Dim MysqlConnString As String = "server=localhost;database=Atila1;user=root;password=root;" 'port=3307;
    Public Conexion As MySqlConnection = New MySqlConnection(MysqlConnString)
    Public Sub Probarconexion() 'PROBAR CONEXION DE UNA TABLA
        Try
            Conexion.Open()
            MsgBox("la conexión fue exitosa")
            Conexion.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub
    Public Sub InsertarDatos() 'INSERTAR DATOS EN UNA TABLA DE LA BASE DE DATOS
        ComandoSql = New MySqlCommand(Consulta)
        Conexion.Open()
        ComandoSql.Connection = Conexion
        ComandoSql.ExecuteNonQuery()
        Conexion.Close()

    End Sub
End Class
