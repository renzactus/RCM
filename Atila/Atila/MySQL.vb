Imports MySql.Data.MySqlClient
Public Class MySQL
    Public respuesta As MySqlDataReader
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
        Dim cmd As New MySqlCommand(Consulta, Conexion)
        Try
            DataAdapter = New MySqlDataAdapter(Consulta, Conexion)
            DataSet.Clear()
            DataAdapter.Fill(DataSet, tabla)
        Catch ex As Exception
            Consultado = False
            MsgBox("Error de conexion", 48)

        End Try
    End Sub

    Public Sub Co()
        Conexion.Open()

        Dim Myadaptar As New MySqlDataAdapter
        Dim command As New MySqlCommand("select motivo from reservas where fecha='2020-09-29' and fecha_cancelacion is null;")
        command.Connection = Conexion
        command.CommandText = Consulta
        Myadaptar.SelectCommand = command


    End Sub
End Class
