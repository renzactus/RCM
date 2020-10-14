Imports MySql.Data.MySqlClient

Public Class MySQL

    Public Resultado As New DataTable
    Public Consultado As Boolean
    Dim Conexion As MySqlConnection
    Public Sub InsertarDatos(ByVal Consulta As String, Optional ByVal StringdeConexion As String = "server=localhost;database=atila;user=admin;password=contraadmin;") 'INSERTAR DATOS EN UNA TABLA DE LA BASE DE DATOS
        Dim ComandoSql As New MySqlCommand
        Conexion = New MySqlConnection(StringdeConexion)
        ComandoSql = New MySqlCommand(Consulta)
        Try
            Conexion.Open()
            ComandoSql.Connection = Conexion
            ComandoSql.ExecuteNonQuery()
            Conexion.Close()
            Consulta = vbNull
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa" & ex.ToString)
        End Try
    End Sub
    Sub Consultar(ByVal Consulta As String, Optional ByVal StringdeConexion As String = "server=localhost;database=atila;user=admin;password=contraadmin;")
        Dim adapter As New MySqlDataAdapter
        Dim commandbuild As New MySqlCommandBuilder
        Conexion = New MySqlConnection(StringdeConexion)
        adapter = New MySqlDataAdapter(Consulta, Conexion)
        Consultado = True
        Resultado = New DataTable
        Try
            commandbuild = New MySqlCommandBuilder(adapter)
            adapter.Fill(Resultado)
            'MsgBox(Data.Rows(0).Item("id_usuario"))
            Conexion.Close()
            Consulta = vbNull
        Catch ex As Exception
            Conexion.Close()
            Consultado = False
            MsgBox("Error al consultar o de conexion" & ex.ToString, 48)
        End Try
    End Sub

End Class
