Public Class ListadeReservas
    Dim mysql As New MySQL
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Format(Calendario.SelectionRange.Start, "yyyy-MM-dd"))

    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        mysql.Consulta = "select motivo from reservas where fecha='2020-09-29' and fecha_cancelacion is null;"
        '"select motivo from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null;"
        mysql.tabla = "reservas"
        mysql.Consultar()

    End Sub
End Class