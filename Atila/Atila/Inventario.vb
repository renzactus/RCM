Public Class Inventario
    Dim mysql As New MySQL
    Dim ibImprevisto As String
    Dim booleanSeleccionada As Boolean
    Dim FilaSeleccionada As Integer
    Dim datosInventario As DataTable
    'Constructor
    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstablecerColores()
        MostrarInventarioEndgv()
        btnEditarCantidad.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Private Sub EstablecerColores()
        Me.BackColor = Principal.colorSecundario
        lblInventario.ForeColor = Principal.colorTitulos
        btnAgregarDatos.ForeColor = Principal.colorTitulos
        btnEditarCantidad.ForeColor = Principal.colorTitulos
        btnBorrar.ForeColor = Principal.colorTitulos
        dgvInventario.BackgroundColor = Principal.colorTerceario
    End Sub
    'Metodos Utilizados
    Private Sub MostrarInventarioEndgv()
        dgvInventario.Rows.Clear()
        mysql.Consultar("select * from inventario")
        datosInventario = mysql.Resultado
        For i = 0 To datosInventario.Rows.Count - 1
            dgvInventario.Rows.Add(datosInventario.Rows(i).Item("descripcion"), datosInventario.Rows(i).Item("cantidad"))
        Next
        dgvInventario.Rows(0).Selected = False
        btnBorrar.Enabled = False
        btnEditarCantidad.Enabled = False
    End Sub
    Private Sub SaberFilaSeleccionada()
        FilaSeleccionada = vbNull
        If dgvInventario.SelectedRows.Count > 0 Then
            FilaSeleccionada = dgvInventario.CurrentRow.Index
        End If
    End Sub
    'Agregar Inventario
    Private Sub ChequearYAgregarInventario()
        If txtDescripcion.Text = "" Then
            avisarSiEstaVacio(txtDescripcion)
            avisarSiEstaVacio(nudCantidad)
        Else
            mysql.InsertarDatos("insert into inventario (descripcion,cantidad) values ('" & txtDescripcion.Text & "'," & nudCantidad.Value & ")")
            MostrarInventarioEndgv()
        End If
    End Sub
    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    'Borrar inventarios
    Private Sub borrarInventario()
        SaberFilaSeleccionada()
        mysql.Consultar("select ID_INVENTARIO from utiliza where ID_INVENTARIO=" & datosInventario.Rows(FilaSeleccionada).Item("ID_INVENTARIO"))
        If mysql.Resultado.Rows.Count > 0 Then
            epError.SetError(dgvInventario, "Este Inventario no se puede eliminar porque se ha utilizado")
            Reservar.sonidoError()
        Else
            mysql.InsertarDatos("delete from inventario where ID_INVENTARIO=" & datosInventario.Rows(FilaSeleccionada).Item("ID_INVENTARIO"))
            MostrarInventarioEndgv()
        End If
    End Sub

    'Enventos

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

    Private Sub dgvInventario_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvInventario.CellMouseClick
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
        End If
    End Sub

    Private Sub btnEditarCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCantidad.Click
        SaberFilaSeleccionada()
        ibImprevisto = InputBox("Editar Cantidad de " & datosInventario.Rows(FilaSeleccionada).Item("descripcion"),
                                "Atención!", datosInventario.Rows(FilaSeleccionada).Item("cantidad"))
        If ibImprevisto = "" Then

        ElseIf Not IsNumeric(ibImprevisto) Then
            MsgBox("La cantidad tiene que ser numérica")
        ElseIf ibImprevisto = datosInventario.Rows(FilaSeleccionada).Item("cantidad") Then

        ElseIf IsNumeric(ibImprevisto) Then
            mysql.InsertarDatos("update inventario set cantidad=" & ibImprevisto & " where ID_INVENTARIO=" &
                                datosInventario.Rows(FilaSeleccionada).Item("ID_INVENTARIO"))
            MostrarInventarioEndgv()
        Else
            MsgBox("Error al editar el inventario")
        End If

    End Sub

    Private Sub dgvInventario_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvInventario.SelectionChanged
        btnEditarCantidad.Enabled = True
        btnBorrar.Enabled = True

    End Sub

    Private Sub btnAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        ChequearYAgregarInventario()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borrarInventario()
    End Sub

    Private Sub btnBorrar_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles btnBorrar.Validating
        epError.SetError(dgvInventario, "")
    End Sub

    Private Sub txtDescripcion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        epError.SetError(txtDescripcion, "")
    End Sub

    Private Sub nudCantidad_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nudCantidad.Validating
        epError.SetError(nudCantidad, "")
    End Sub

End Class