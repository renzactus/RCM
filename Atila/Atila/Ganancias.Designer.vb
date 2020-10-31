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
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Grafica.Location = New System.Drawing.Point(42, 77)
        Me.Grafica.Name = "Grafica"
        Me.Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Me.Grafica.Size = New System.Drawing.Size(1103, 499)
        Me.Grafica.TabIndex = 0
        Me.Grafica.Text = "eqw"
        '
        'cboSeleccionar
        '
        Me.cboSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeleccionar.FormattingEnabled = True
        Me.cboSeleccionar.Items.AddRange(New Object() {"Reservas Anuales", "Ganancias Mensuales", "Reservas Mensuales", "Ganancias Anuales"})
        Me.cboSeleccionar.Location = New System.Drawing.Point(177, 12)
        Me.cboSeleccionar.Name = "cboSeleccionar"
        Me.cboSeleccionar.Size = New System.Drawing.Size(122, 21)
        Me.cboSeleccionar.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 18)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Mostrar:"
        '
        'cboAño
        '
        Me.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Location = New System.Drawing.Point(132, 50)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(75, 21)
        Me.cboAño.TabIndex = 40
        Me.cboAño.Visible = False
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(100, 53)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(26, 13)
        Me.lblAño.TabIndex = 41
        Me.lblAño.Text = "Año"
        Me.lblAño.Visible = False
        '
        'btnAlternar
        '
        Me.btnAlternar.Location = New System.Drawing.Point(42, 77)
        Me.btnAlternar.Name = "btnAlternar"
        Me.btnAlternar.Size = New System.Drawing.Size(52, 22)
        Me.btnAlternar.TabIndex = 42
        Me.btnAlternar.Text = "Alternar"
        Me.btnAlternar.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(250, 53)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(27, 13)
        Me.lblMes.TabIndex = 44
        Me.lblMes.Text = "Mes"
        Me.lblMes.Visible = False
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Enabled = False
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboMes.Location = New System.Drawing.Point(283, 50)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(90, 21)
        Me.cboMes.TabIndex = 43
        Me.cboMes.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(858, 42)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 24)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "Total"
        '
        'lblMostrarTotal
        '
        Me.lblMostrarTotal.AutoSize = True
        Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarTotal.Location = New System.Drawing.Point(915, 42)
        Me.lblMostrarTotal.Name = "lblMostrarTotal"
        Me.lblMostrarTotal.Size = New System.Drawing.Size(51, 24)
        Me.lblMostrarTotal.TabIndex = 47
        Me.lblMostrarTotal.Text = "Total"
        '
        'Ganancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 669)
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
        Me.Name = "Ganancias"
        Me.Text = "Ganancias"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
