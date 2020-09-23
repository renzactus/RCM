Imports MySql.Data.MySqlClient
Public Class MySQL
    Public Consulta As String
    Private ComandoSql As New MySqlCommand
    Dim MysqlConnString As String = "server=localhost;port=3307;database=Atila;user=root;password=root;"
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
        ComandoSql()
        ComandoSql.ExecuteNonQuery()
        Conexion.Close()

    End Sub
End Class
