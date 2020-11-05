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
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.chkRecordarSesion = New System.Windows.Forms.CheckBox()
        Me.timerChequearMayusculaActivada = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBarra = New System.Windows.Forms.Panel()
        Me.lblInicioDeSesion = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblnroCedula = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.pboMayusculas = New System.Windows.Forms.PictureBox()
        Me.pibAnimacion = New System.Windows.Forms.PictureBox()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.pboLogoAtila = New System.Windows.Forms.PictureBox()
        Me.pnlBarra.SuspendLayout()
        CType(Me.pboMayusculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboLogoAtila, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(84, 516)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(217, 41)
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
        Me.txtCedula.Location = New System.Drawing.Point(219, 306)
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
        'txtContraseña
        '
        Me.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.LightGray
        Me.txtContraseña.Location = New System.Drawing.Point(219, 377)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(290, 45)
        Me.txtContraseña.TabIndex = 9
        Me.txtContraseña.Text = "Contraseña"
        '
        'chkRecordarSesion
        '
        Me.chkRecordarSesion.AutoSize = True
        Me.chkRecordarSesion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordarSesion.Location = New System.Drawing.Point(219, 439)
        Me.chkRecordarSesion.Name = "chkRecordarSesion"
        Me.chkRecordarSesion.Size = New System.Drawing.Size(196, 22)
        Me.chkRecordarSesion.TabIndex = 22
        Me.chkRecordarSesion.Text = "Recordar mi contraseña"
        Me.chkRecordarSesion.UseVisualStyleBackColor = True
        '
        'timerChequearMayusculaActivada
        '
        Me.timerChequearMayusculaActivada.Enabled = True
        Me.timerChequearMayusculaActivada.Interval = 10
        '
        'pnlBarra
        '
        Me.pnlBarra.Controls.Add(Me.lblInicioDeSesion)
        Me.pnlBarra.Controls.Add(Me.btnAyuda)
        Me.pnlBarra.Controls.Add(Me.btnCerrar)
        Me.pnlBarra.Controls.Add(Me.btnMinimizar)
        Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(656, 43)
        Me.pnlBarra.TabIndex = 24
        '
        'lblInicioDeSesion
        '
        Me.lblInicioDeSesion.AutoSize = True
        Me.lblInicioDeSesion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicioDeSesion.ForeColor = System.Drawing.Color.White
        Me.lblInicioDeSesion.Location = New System.Drawing.Point(67, 10)
        Me.lblInicioDeSesion.Name = "lblInicioDeSesion"
        Me.lblInicioDeSesion.Size = New System.Drawing.Size(158, 17)
        Me.lblInicioDeSesion.TabIndex = 25
        Me.lblInicioDeSesion.Text = "Inicio de sesión en Atila"
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(345, 516)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(217, 41)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblnroCedula
        '
        Me.lblnroCedula.AutoSize = True
        Me.lblnroCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnroCedula.Location = New System.Drawing.Point(69, 321)
        Me.lblnroCedula.Name = "lblnroCedula"
        Me.lblnroCedula.Size = New System.Drawing.Size(148, 19)
        Me.lblnroCedula.TabIndex = 26
        Me.lblnroCedula.Text = "Número de cédula"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(115, 389)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(98, 19)
        Me.lblContraseña.TabIndex = 27
        Me.lblContraseña.Text = "Contraseña"
        '
        'pboMayusculas
        '
        Me.pboMayusculas.Image = Global.Atila.My.Resources.Resources.Icono_Mayusculas
        Me.pboMayusculas.Location = New System.Drawing.Point(515, 389)
        Me.pboMayusculas.Name = "pboMayusculas"
        Me.pboMayusculas.Size = New System.Drawing.Size(24, 24)
        Me.pboMayusculas.TabIndex = 23
        Me.pboMayusculas.TabStop = False
        '
        'pibAnimacion
        '
        Me.pibAnimacion.Image = Global.Atila.My.Resources.Resources.Portada1
        Me.pibAnimacion.Location = New System.Drawing.Point(0, 0)
        Me.pibAnimacion.Name = "pibAnimacion"
        Me.pibAnimacion.Size = New System.Drawing.Size(656, 655)
        Me.pibAnimacion.TabIndex = 28
        Me.pibAnimacion.TabStop = False
        '
        'btnAyuda
        '
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Image = Global.Atila.My.Resources.Resources.LOGO_PEQUEÑITO
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(3, 3)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(51, 36)
        Me.btnAyuda.TabIndex = 24
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(607, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(49, 43)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Atila.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(562, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 43)
        Me.btnMinimizar.TabIndex = 21
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'pboLogoAtila
        '
        Me.pboLogoAtila.Image = Global.Atila.My.Resources.Resources.LOGO_ATILA_PRINCIPAL
        Me.pboLogoAtila.Location = New System.Drawing.Point(233, 121)
        Me.pboLogoAtila.Name = "pboLogoAtila"
        Me.pboLogoAtila.Size = New System.Drawing.Size(195, 137)
        Me.pboLogoAtila.TabIndex = 7
        Me.pboLogoAtila.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 655)
        Me.Controls.Add(Me.pibAnimacion)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblnroCedula)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.pboMayusculas)
        Me.Controls.Add(Me.chkRecordarSesion)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlBarra)
        Me.Controls.Add(Me.pboLogoAtila)
        Me.Controls.Add(Me.txtCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        CType(Me.pboMayusculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pibAnimacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboLogoAtila, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents tmrCambiandoOpacidad As System.Windows.Forms.Timer
    Friend WithEvents pboLogoAtila As System.Windows.Forms.PictureBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chkRecordarSesion As System.Windows.Forms.CheckBox
    Friend WithEvents timerChequearMayusculaActivada As System.Windows.Forms.Timer
    Friend WithEvents pboMayusculas As System.Windows.Forms.PictureBox
    Friend WithEvents pnlBarra As System.Windows.Forms.Panel
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents lblInicioDeSesion As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblnroCedula As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents pibAnimacion As System.Windows.Forms.PictureBox
End Class
