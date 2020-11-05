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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.btnEditarCantidad = New System.Windows.Forms.Button()
        Me.btnAgregarDatos = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInventario = New System.Windows.Forms.Label()
        Me.pbDescripcion = New System.Windows.Forms.PictureBox()
        Me.pbCantidad = New System.Windows.Forms.PictureBox()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AllowUserToResizeColumns = False
        Me.dgvInventario.AllowUserToResizeRows = False
        Me.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventario.ColumnHeadersHeight = 35
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventario.EnableHeadersVisualStyles = False
        Me.dgvInventario.Location = New System.Drawing.Point(206, 247)
        Me.dgvInventario.MultiSelect = False
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventario.RowTemplate.Height = 30
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(494, 235)
        Me.dgvInventario.TabIndex = 23
        '
        'btnEditarCantidad
        '
        Me.btnEditarCantidad.Enabled = False
        Me.btnEditarCantidad.FlatAppearance.BorderSize = 0
        Me.btnEditarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCantidad.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCantidad.Location = New System.Drawing.Point(808, 288)
        Me.btnEditarCantidad.Name = "btnEditarCantidad"
        Me.btnEditarCantidad.Size = New System.Drawing.Size(105, 43)
        Me.btnEditarCantidad.TabIndex = 24
        Me.btnEditarCantidad.Text = "Editar Seleccionado"
        Me.btnEditarCantidad.UseVisualStyleBackColor = True
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.FlatAppearance.BorderSize = 0
        Me.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDatos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDatos.Location = New System.Drawing.Point(671, 148)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(77, 43)
        Me.btnAgregarDatos.TabIndex = 25
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(296, 175)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(168, 27)
        Me.txtDescripcion.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(531, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cantidad:"
        '
        'nudCantidad
        '
        Me.nudCantidad.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidad.Location = New System.Drawing.Point(540, 175)
        Me.nudCantidad.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(65, 27)
        Me.nudCantidad.TabIndex = 32
        Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(808, 375)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(105, 43)
        Me.btnBorrar.TabIndex = 33
        Me.btnBorrar.Text = "Borrar Seleccionado"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 150
        '
        'lblInventario
        '
        Me.lblInventario.AutoSize = True
        Me.lblInventario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventario.Location = New System.Drawing.Point(82, 62)
        Me.lblInventario.Name = "lblInventario"
        Me.lblInventario.Size = New System.Drawing.Size(110, 22)
        Me.lblInventario.TabIndex = 34
        Me.lblInventario.Text = "Inventario:"
        '
        'pbDescripcion
        '
        Me.pbDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbDescripcion.Location = New System.Drawing.Point(294, 173)
        Me.pbDescripcion.Name = "pbDescripcion"
        Me.pbDescripcion.Size = New System.Drawing.Size(172, 31)
        Me.pbDescripcion.TabIndex = 69
        Me.pbDescripcion.TabStop = False
        '
        'pbCantidad
        '
        Me.pbCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCantidad.Location = New System.Drawing.Point(538, 173)
        Me.pbCantidad.Name = "pbCantidad"
        Me.pbCantidad.Size = New System.Drawing.Size(69, 31)
        Me.pbCantidad.TabIndex = 70
        Me.pbCantidad.TabStop = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 768)
        Me.Controls.Add(Me.lblInventario)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnAgregarDatos)
        Me.Controls.Add(Me.btnEditarCantidad)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.pbDescripcion)
        Me.Controls.Add(Me.pbCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditarCantidad As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDatos As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInventario As System.Windows.Forms.Label
    Friend WithEvents pbDescripcion As System.Windows.Forms.PictureBox
    Friend WithEvents pbCantidad As System.Windows.Forms.PictureBox
End Class
