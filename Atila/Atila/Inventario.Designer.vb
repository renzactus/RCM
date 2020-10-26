<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conf = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AllowUserToResizeColumns = False
        Me.dgvInventario.AllowUserToResizeRows = False
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad, Me.conf})
        Me.dgvInventario.Location = New System.Drawing.Point(63, 48)
        Me.dgvInventario.MultiSelect = False
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.RowHeadersVisible = False
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(327, 114)
        Me.dgvInventario.TabIndex = 23
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'conf
        '
        Me.conf.Frozen = True
        Me.conf.HeaderText = ""
        Me.conf.Name = "conf"
        Me.conf.ReadOnly = True
        Me.conf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.conf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.conf.Width = 40
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 353)
        Me.Controls.Add(Me.dgvInventario)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conf As System.Windows.Forms.DataGridViewButtonColumn
End Class
