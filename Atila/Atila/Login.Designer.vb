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
        Me.tmrCambiandoOpacidad = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.chkRecordarSesion = New System.Windows.Forms.CheckBox()
        Me.timerChequearMayusculaActivada = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pboLogoAtila = New System.Windows.Forms.PictureBox()
        Me.pibAnimacion = New System.Windows.Forms.PictureBox()
        Me.pboMayusculas = New System.Windows.Forms.PictureBox()
        CType(Me.pboLogoAtila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboMayusculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(106, 350)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(238, 51)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.LightGray
        Me.txtCedula.Location = New System.Drawing.Point(80, 160)
        Me.txtCedula.Multiline = True
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(290, 45)
        Me.txtCedula.TabIndex = 1
        Me.txtCedula.Text = "Cédula"
        '
        'tmrCambiandoOpacidad
        '
        Me.tmrCambiandoOpacidad.Interval = 10
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(450, 460)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 80
        Me.LineShape1.X2 = 369
        Me.LineShape1.Y1 = 278
        Me.LineShape1.Y2 = 278
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 80
        Me.LineShape2.X2 = 369
        Me.LineShape2.Y1 = 207
        Me.LineShape2.Y2 = 207
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.LightGray
        Me.txtContraseña.Location = New System.Drawing.Point(80, 231)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(290, 45)
        Me.txtContraseña.TabIndex = 9
        Me.txtContraseña.Text = "Contraseña"
        '
        'chkRecordarSesion
        '
        Me.chkRecordarSesion.AutoSize = True
        Me.chkRecordarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordarSesion.Location = New System.Drawing.Point(80, 298)
        Me.chkRecordarSesion.Name = "chkRecordarSesion"
        Me.chkRecordarSesion.Size = New System.Drawing.Size(129, 20)
        Me.chkRecordarSesion.TabIndex = 22
        Me.chkRecordarSesion.Text = "Recordar Sesión"
        Me.chkRecordarSesion.UseVisualStyleBackColor = True
        '
        'timerChequearMayusculaActivada
        '
        Me.timerChequearMayusculaActivada.Enabled = True
        Me.timerChequearMayusculaActivada.Interval = 10
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Atila.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(363, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 25)
        Me.btnMinimizar.TabIndex = 21
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(405, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 25)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pboLogoAtila
        '
        Me.pboLogoAtila.Image = Global.Atila.My.Resources.Resources.LOGO_ATILA
        Me.pboLogoAtila.Location = New System.Drawing.Point(145, 21)
        Me.pboLogoAtila.Name = "pboLogoAtila"
        Me.pboLogoAtila.Size = New System.Drawing.Size(160, 129)
        Me.pboLogoAtila.TabIndex = 7
        Me.pboLogoAtila.TabStop = False
        '
        'pibAnimacion
        '
        Me.pibAnimacion.Image = CType(resources.GetObject("pibAnimacion.Image"), System.Drawing.Image)
        Me.pibAnimacion.Location = New System.Drawing.Point(-10, -5)
        Me.pibAnimacion.Name = "pibAnimacion"
        Me.pibAnimacion.Size = New System.Drawing.Size(460, 470)
        Me.pibAnimacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pibAnimacion.TabIndex = 3
        Me.pibAnimacion.TabStop = False
        '
        'pboMayusculas
        '
        Me.pboMayusculas.Image = Global.Atila.My.Resources.Resources.Icono_Mayusculas
        Me.pboMayusculas.Location = New System.Drawing.Point(329, 243)
        Me.pboMayusculas.Name = "pboMayusculas"
        Me.pboMayusculas.Size = New System.Drawing.Size(24, 24)
        Me.pboMayusculas.TabIndex = 23
        Me.pboMayusculas.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 460)
        Me.Controls.Add(Me.pibAnimacion)
        Me.Controls.Add(Me.pboMayusculas)
        Me.Controls.Add(Me.chkRecordarSesion)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.pboLogoAtila)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pboLogoAtila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboMayusculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents pibAnimacion As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCambiandoOpacidad As System.Windows.Forms.Timer
    Friend WithEvents pboLogoAtila As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chkRecordarSesion As System.Windows.Forms.CheckBox
    Friend WithEvents timerChequearMayusculaActivada As System.Windows.Forms.Timer
    Friend WithEvents pboMayusculas As System.Windows.Forms.PictureBox
End Class
