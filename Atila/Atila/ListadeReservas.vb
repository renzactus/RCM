Public Class ListadeReservas
    Dim mysql As New MySQL
    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        mysql.Consultar("select motivo from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null;")
        If mysql.Resultado.Rows.Count() > 0 Then
            MsgBox(mysql.Resultado.Rows(0).Item("motivo"))
        End If
    End Sub
    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class