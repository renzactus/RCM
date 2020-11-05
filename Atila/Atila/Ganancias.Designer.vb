<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ganancias
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cboSeleccionar = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.btnAlternar = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMostrarTotal = New System.Windows.Forms.Label()
        Me.lblGananciasEstadisticas = New System.Windows.Forms.Label()
        Me.pbFiltrarCedula = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbMes = New System.Windows.Forms.PictureBox()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFiltrarCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grafica
        '
        Me.Grafica.BackColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Grafica.Legends.Add(Legend1)
        Me.Grafica.Location = New System.Drawing.Point(70, 160)
        Me.Grafica.Name = "Grafica"
        Me.Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Me.Grafica.Size = New System.Drawing.Size(1122, 579)
        Me.Grafica.TabIndex = 0
        Me.Grafica.Text = "eqw"
        '
        'cboSeleccionar
        '
        Me.cboSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeleccionar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeleccionar.FormattingEnabled = True
        Me.cboSeleccionar.Items.AddRange(New Object() {"Reservas Anuales", "Ganancias Mensuales", "Reservas Mensuales", "Ganancias Anuales"})
        Me.cboSeleccionar.Location = New System.Drawing.Point(187, 56)
        Me.cboSeleccionar.Name = "cboSeleccionar"
        Me.cboSeleccionar.Size = New System.Drawing.Size(163, 26)
        Me.cboSeleccionar.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(103, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 22)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Mostrar:"
        '
        'cboAño
        '
        Me.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Location = New System.Drawing.Point(220, 97)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(67, 26)
        Me.cboAño.TabIndex = 40
        Me.cboAño.Visible = False
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lblAño.Location = New System.Drawing.Point(165, 100)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(49, 22)
        Me.lblAño.TabIndex = 41
        Me.lblAño.Text = "Año:"
        Me.lblAño.Visible = False
        '
        'btnAlternar
        '
        Me.btnAlternar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlternar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlternar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlternar.Location = New System.Drawing.Point(55, 177)
        Me.btnAlternar.Name = "btnAlternar"
        Me.btnAlternar.Size = New System.Drawing.Size(60, 25)
        Me.btnAlternar.TabIndex = 42
        Me.btnAlternar.Text = "Alternar"
        Me.btnAlternar.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lblMes.Location = New System.Drawing.Point(330, 97)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(51, 22)
        Me.lblMes.TabIndex = 44
        Me.lblMes.Text = "Mes:"
        Me.lblMes.Visible = False
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Enabled = False
        Me.cboMes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboMes.Location = New System.Drawing.Point(387, 97)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(109, 26)
        Me.cboMes.TabIndex = 43
        Me.cboMes.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(901, 92)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(60, 24)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "Total:"
        '
        'lblMostrarTotal
        '
        Me.lblMostrarTotal.AutoSize = True
        Me.lblMostrarTotal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarTotal.Location = New System.Drawing.Point(959, 91)
        Me.lblMostrarTotal.Name = "lblMostrarTotal"
        Me.lblMostrarTotal.Size = New System.Drawing.Size(62, 27)
        Me.lblMostrarTotal.TabIndex = 47
        Me.lblMostrarTotal.Text = "Total"
        '
        'lblGananciasEstadisticas
        '
        Me.lblGananciasEstadisticas.AutoSize = True
        Me.lblGananciasEstadisticas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGananciasEstadisticas.Location = New System.Drawing.Point(37, 9)
        Me.lblGananciasEstadisticas.Name = "lblGananciasEstadisticas"
        Me.lblGananciasEstadisticas.Size = New System.Drawing.Size(268, 24)
        Me.lblGananciasEstadisticas.TabIndex = 71
        Me.lblGananciasEstadisticas.Text = "Ganancias y estadísticas:"
        '
        'pbFiltrarCedula
        '
        Me.pbFiltrarCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbFiltrarCedula.Location = New System.Drawing.Point(185, 54)
        Me.pbFiltrarCedula.Name = "pbFiltrarCedula"
        Me.pbFiltrarCedula.Size = New System.Drawing.Size(167, 30)
        Me.pbFiltrarCedula.TabIndex = 101
        Me.pbFiltrarCedula.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(218, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 30)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'pbMes
        '
        Me.pbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbMes.Location = New System.Drawing.Point(385, 95)
        Me.pbMes.Name = "pbMes"
        Me.pbMes.Size = New System.Drawing.Size(113, 30)
        Me.pbMes.TabIndex = 103
        Me.pbMes.TabStop = False
        Me.pbMes.Visible = False
        '
        'Ganancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 768)
        Me.Controls.Add(Me.lblGananciasEstadisticas)
        Me.Controls.Add(Me.lblMostrarTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.btnAlternar)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.cboAño)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboSeleccionar)
        Me.Controls.Add(Me.Grafica)
        Me.Controls.Add(Me.pbFiltrarCedula)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbMes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ganancias"
        Me.Text = "Ganancias"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFiltrarCedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cboSeleccionar As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboAño As System.Windows.Forms.ComboBox
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents btnAlternar As System.Windows.Forms.Button
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
    Friend WithEvents lblGananciasEstadisticas As System.Windows.Forms.Label
    Friend WithEvents pbFiltrarCedula As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbMes As System.Windows.Forms.PictureBox
End Class
