<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.panDatos = New System.Windows.Forms.Panel()
        Me.pibAnimacion = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panDatos.SuspendLayout()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'panDatos
        '
        Me.panDatos.Controls.Add(Me.pibAnimacion)
        Me.panDatos.Controls.Add(Me.Button1)
        Me.panDatos.Controls.Add(Me.TextBox2)
        Me.panDatos.Controls.Add(Me.TextBox1)
        Me.panDatos.Location = New System.Drawing.Point(0, -1)
        Me.panDatos.Name = "panDatos"
        Me.panDatos.Size = New System.Drawing.Size(325, 373)
        Me.panDatos.TabIndex = 3
        '
        'pibAnimacion
        '
        Me.pibAnimacion.Image = CType(resources.GetObject("pibAnimacion.Image"), System.Drawing.Image)
        Me.pibAnimacion.Location = New System.Drawing.Point(0, 4)
        Me.pibAnimacion.Name = "pibAnimacion"
        Me.pibAnimacion.Size = New System.Drawing.Size(325, 435)
        Me.pibAnimacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pibAnimacion.TabIndex = 3
        Me.pibAnimacion.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 437)
        Me.Controls.Add(Me.panDatos)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.panDatos.ResumeLayout(False)
        Me.panDatos.PerformLayout()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents panDatos As System.Windows.Forms.Panel
    Friend WithEvents pibAnimacion As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
