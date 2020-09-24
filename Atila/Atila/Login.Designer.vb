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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.panDatos = New System.Windows.Forms.Panel()
        Me.pibAnimacion = New System.Windows.Forms.PictureBox()
        Me.tmrCambiandoOpacidad = New System.Windows.Forms.Timer(Me.components)
        Me.panDatos.SuspendLayout()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(59, 136)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(99, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Iniciar Sesion"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(24, 31)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(24, 75)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 2
        '
        'panDatos
        '
        Me.panDatos.Controls.Add(Me.pibAnimacion)
        Me.panDatos.Controls.Add(Me.btnLogin)
        Me.panDatos.Controls.Add(Me.txtContraseña)
        Me.panDatos.Controls.Add(Me.txtCedula)
        Me.panDatos.Location = New System.Drawing.Point(0, -1)
        Me.panDatos.Name = "panDatos"
        Me.panDatos.Size = New System.Drawing.Size(325, 373)
        Me.panDatos.TabIndex = 3
        '
        'pibAnimacion
        '
        Me.pibAnimacion.Image = CType(resources.GetObject("pibAnimacion.Image"), System.Drawing.Image)
        Me.pibAnimacion.Location = New System.Drawing.Point(-3, -28)
        Me.pibAnimacion.Name = "pibAnimacion"
        Me.pibAnimacion.Size = New System.Drawing.Size(325, 325)
        Me.pibAnimacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pibAnimacion.TabIndex = 3
        Me.pibAnimacion.TabStop = False
        '
        'tmrCambiandoOpacidad
        '
        Me.tmrCambiandoOpacidad.Interval = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 292)
        Me.Controls.Add(Me.panDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.panDatos.ResumeLayout(False)
        Me.panDatos.PerformLayout()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents panDatos As System.Windows.Forms.Panel
    Friend WithEvents pibAnimacion As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCambiandoOpacidad As System.Windows.Forms.Timer
End Class
