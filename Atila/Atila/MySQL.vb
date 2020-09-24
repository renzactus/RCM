Imports MySql.Data.MySqlClient
Public Class MySQL
    Public DataSet As New DataSet
    Public Consultado As Boolean
    Public Consulta, consultaInsert As String
    Public ComandoSql As New MySqlCommand
    Public tabla As String
    Dim MysqlConnString As String = "server=localhost;port=3307;database=Atila;user=root;password=root;"
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
            ComandoSql = New MySqlCommand(consultaInsert)
            Conexion.Open()
            ComandoSql.Connection = Conexion
            ComandoSql.ExecuteNonQuery()
            Conexion.Close()
            consultaInsert = vbNull
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub
    Public Sub Consultar()
        Consultado = True
        Dim DataAdapter As New MySqlDataAdapter
        Try
            DataAdapter = New MySqlDataAdapter(Consulta, Conexion)
            DataSet.Clear()
            DataAdapter.Fill(DataSet, tabla)
        Catch ex As Exception
            Consultado = False
            MsgBox("Error de conexion")

        End Try
    End Sub
End Class
