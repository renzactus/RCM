Public Class Inventario
    Dim mysql As New MySQL
    'Constructor
    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarInventarioEndgv()
    End Sub
    'Metodos Utilizados
    Private Sub MostrarInventarioEndgv()
        mysql.Consultar("select * from inventario")
        For i = 0 To mysql.Resultado.Rows.Count - 1
            dgvInventario.Rows.Add(mysql.Resultado.Rows(i).Item("descripcion"), mysql.Resultado.Rows(i).Item("cantidad"))
        Next
    End Sub

    Private Sub dgvInventario_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventario.CellMouseEnter
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
            dgvInventario.Rows(e.RowIndex).Cells(2).Value = "..."
        End If
    End Sub

    Private Sub dgvInventario_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventario.CellMouseLeave
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
            dgvInventario.Rows(e.RowIndex).Cells(2).Value = ""
        End If
    End Sub
End Class