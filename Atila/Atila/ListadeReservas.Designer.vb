<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadeReservas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHora3 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.llblMotivoReserva3 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva2 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva1 = New System.Windows.Forms.LinkLabel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvFiltrarReservas = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvFiltrarReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(444, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtrar por:"
        '
        'lblHora3
        '
        Me.lblHora3.AutoSize = True
        Me.lblHora3.Location = New System.Drawing.Point(172, 346)
        Me.lblHora3.Name = "lblHora3"
        Me.lblHora3.Size = New System.Drawing.Size(45, 13)
        Me.lblHora3.TabIndex = 29
        Me.lblHora3.Text = "Label11"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Location = New System.Drawing.Point(172, 324)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(45, 13)
        Me.lblHora2.TabIndex = 28
        Me.lblHora2.Text = "Label10"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.Location = New System.Drawing.Point(172, 303)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(39, 13)
        Me.lblHora1.TabIndex = 27
        Me.lblHora1.Text = "Label9"
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(100, 288)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(172, 15)
        Me.lblNoHayReservas.TabIndex = 26
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'llblMotivoReserva3
        '
        Me.llblMotivoReserva3.AutoSize = True
        Me.llblMotivoReserva3.Location = New System.Drawing.Point(100, 346)
        Me.llblMotivoReserva3.Name = "llblMotivoReserva3"
        Me.llblMotivoReserva3.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva3.TabIndex = 25
        Me.llblMotivoReserva3.TabStop = True
        Me.llblMotivoReserva3.Text = "LinkLabel3"
        '
        'llblMotivoReserva2
        '
        Me.llblMotivoReserva2.AutoSize = True
        Me.llblMotivoReserva2.Location = New System.Drawing.Point(100, 324)
        Me.llblMotivoReserva2.Name = "llblMotivoReserva2"
        Me.llblMotivoReserva2.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva2.TabIndex = 24
        Me.llblMotivoReserva2.TabStop = True
        Me.llblMotivoReserva2.Text = "LinkLabel2"
        '
        'llblMotivoReserva1
        '
        Me.llblMotivoReserva1.AutoSize = True
        Me.llblMotivoReserva1.Location = New System.Drawing.Point(100, 303)
        Me.llblMotivoReserva1.Name = "llblMotivoReserva1"
        Me.llblMotivoReserva1.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva1.TabIndex = 23
        Me.llblMotivoReserva1.TabStop = True
        Me.llblMotivoReserva1.Text = "LinkLabel1"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFecha.Location = New System.Drawing.Point(278, 270)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 18)
        Me.lblFecha.TabIndex = 22
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(79, 270)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(199, 18)
        Me.lblFiestasReservadasParaEl.TabIndex = 21
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(54, 68)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 30
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(503, 53)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(92, 21)
        Me.cboMes.TabIndex = 31
        Me.cboMes.Visible = False
        '
        'cboFiltrarPor
        '
        Me.cboFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltrarPor.FormattingEnabled = True
        Me.cboFiltrarPor.Items.AddRange(New Object() {"Mes"})
        Me.cboFiltrarPor.Location = New System.Drawing.Point(503, 26)
        Me.cboFiltrarPor.Name = "cboFiltrarPor"
        Me.cboFiltrarPor.Size = New System.Drawing.Size(92, 21)
        Me.cboFiltrarPor.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvFiltrarReservas
        '
        Me.dgvFiltrarReservas.AllowUserToAddRows = False
        Me.dgvFiltrarReservas.AllowUserToDeleteRows = False
        Me.dgvFiltrarReservas.AllowUserToResizeColumns = False
        Me.dgvFiltrarReservas.AllowUserToResizeRows = False
        Me.dgvFiltrarReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFiltrarReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Motivo, Me.Personas})
        Me.dgvFiltrarReservas.Location = New System.Drawing.Point(408, 116)
        Me.dgvFiltrarReservas.MultiSelect = False
        Me.dgvFiltrarReservas.Name = "dgvFiltrarReservas"
        Me.dgvFiltrarReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiltrarReservas.Size = New System.Drawing.Size(287, 114)
        Me.dgvFiltrarReservas.TabIndex = 34
        '
        'Fecha
        '
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 50
        '
        'Motivo
        '
        Me.Motivo.Frozen = True
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.Width = 120
        '
        'Personas
        '
        Me.Personas.HeaderText = "Personas"
        Me.Personas.Name = "Personas"
        Me.Personas.ReadOnly = True
        Me.Personas.Width = 55
        '
        'ListadeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 445)
        Me.Controls.Add(Me.dgvFiltrarReservas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboFiltrarPor)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblHora3)
        Me.Controls.Add(Me.lblHora2)
        Me.Controls.Add(Me.lblHora1)
        Me.Controls.Add(Me.lblNoHayReservas)
        Me.Controls.Add(Me.llblMotivoReserva3)
        Me.Controls.Add(Me.llblMotivoReserva2)
        Me.Controls.Add(Me.llblMotivoReserva1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListadeReservas"
        Me.Text = "ListadeReservas"
        CType(Me.dgvFiltrarReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHora3 As System.Windows.Forms.Label
    Friend WithEvents lblHora2 As System.Windows.Forms.Label
    Friend WithEvents lblHora1 As System.Windows.Forms.Label
    Friend WithEvents lblNoHayReservas As System.Windows.Forms.Label
    Friend WithEvents llblMotivoReserva3 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva2 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblFiestasReservadasParaEl As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvFiltrarReservas As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
