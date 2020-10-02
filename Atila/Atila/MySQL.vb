Imports MySql.Data.MySqlClient

Public Class MySQL

    Public Data As New DataTable
    Public Consultado As Boolean
    Public Consulta As String
    Public ComandoSql As New MySqlCommand
    Dim MysqlConnString As String = "server=localhost;database=atila1;user=root;password=root;" 'port=3307;
    Public Conexion As MySqlConnection = New MySqlConnection(MysqlConnString)
    Public Sub Probarconexion() 'PROBAR CONEXION CON LA BASE DE DATOS
        Try
            Conexion.Open()
            MsgBox("la conexión fue exitosa")
            Conexion.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub
    Public Sub InsertarDatos() 'INSERTAR DATOS EN UNA TABLA DE LA BASE DE DATOS
        Try
            ComandoSql = New MySqlCommand(Consulta)
            Conexion.Open()
            ComandoSql.Connection = Conexion
            ComandoSql.ExecuteNonQuery()
            Conexion.Close()
            Consulta = vbNull
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub
    Sub Consultar()
        Consultado = True
        Dim adapter As New MySqlDataAdapter
        Dim commandbuild As New MySqlCommandBuilder
        Data = New DataTable
        Try
            adapter = New MySqlDataAdapter(Consulta, Conexion)
            commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Data)
            'MsgBox(Data.Rows(0).Item("id_usuario"))
            Conexion.Close()
            Consulta = vbNull
        Catch ex As Exception
            Conexion.Close()
            Consultado = False
            MsgBox("Error al consultar o de conexion", 48)
        End Try
    End Sub

End Class
