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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cboCuotas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(71, 74)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(590, 356)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'cboCuotas
        '
        Me.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuotas.Enabled = False
        Me.cboCuotas.FormattingEnabled = True
        Me.cboCuotas.Items.AddRange(New Object() {"Ganancias del mes", "Fiestas de este Mes", "Fiestas en el año"})
        Me.cboCuotas.Location = New System.Drawing.Point(177, 12)
        Me.cboCuotas.Name = "cboCuotas"
        Me.cboCuotas.Size = New System.Drawing.Size(75, 21)
        Me.cboCuotas.TabIndex = 36
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
        'Ganancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 495)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboCuotas)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Ganancias"
        Me.Text = "Ganancias"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cboCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
