Public Class ListadeReservas
    Dim mysql As New MySQL
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Format(Calendario.SelectionRange.Start, "yyyy-MM-dd"))

    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        mysql.Consulta = "select motivo from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null;"
        mysql.Cons()
        If mysql.Data.Rows.Count() > 0 Then
            MsgBox(mysql.Data.Rows(0).Item("motivo"))
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mysql.Consulta = "select nombre from clientes"
        mysql.Cons()
        MsgBox(mysql.Data.Rows(0).Item("nombre"))
    End Sub
End Class