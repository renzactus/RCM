<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.btnRealizarunareserva = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnListadereservas = New System.Windows.Forms.Button()
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.btnNotificaciones = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCuadroNotificaciones = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlN = New System.Windows.Forms.Panel()
        Me.pnllPlantillaNotificacion = New System.Windows.Forms.Panel()
        Me.btnPlantillaAceptar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.pnlArriba.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCuadroNotificaciones.SuspendLayout()
        Me.pnllPlantillaNotificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRealizarunareserva
        '
        Me.btnRealizarunareserva.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRealizarunareserva.Location = New System.Drawing.Point(461, 90)
        Me.btnRealizarunareserva.Name = "btnRealizarunareserva"
        Me.btnRealizarunareserva.Size = New System.Drawing.Size(320, 55)
        Me.btnRealizarunareserva.TabIndex = 0
        Me.btnRealizarunareserva.Text = "Realizar una Reserva"
        Me.btnRealizarunareserva.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnListadereservas
        '
        Me.btnListadereservas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnListadereservas.Location = New System.Drawing.Point(461, 142)
        Me.btnListadereservas.Name = "btnListadereservas"
        Me.btnListadereservas.Size = New System.Drawing.Size(320, 55)
        Me.btnListadereservas.TabIndex = 16
        Me.btnListadereservas.Text = "Lista de Reservas"
        Me.btnListadereservas.UseVisualStyleBackColor = True
        '
        'pnlArriba
        '
        Me.pnlArriba.Controls.Add(Me.btnNotificaciones)
        Me.pnlArriba.Controls.Add(Me.btnAyuda)
        Me.pnlArriba.Controls.Add(Me.lblPerfil)
        Me.pnlArriba.Controls.Add(Me.btnMinimizar)
        Me.pnlArriba.Controls.Add(Me.btnCerrar)
        Me.pnlArriba.Controls.Add(Me.btnMaximizar)
        Me.pnlArriba.Controls.Add(Me.btnRestaurar)
        Me.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArriba.Location = New System.Drawing.Point(0, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(1300, 52)
        Me.pnlArriba.TabIndex = 17
        '
        'btnNotificaciones
        '
        Me.btnNotificaciones.Location = New System.Drawing.Point(958, 8)
        Me.btnNotificaciones.Name = "btnNotificaciones"
        Me.btnNotificaciones.Size = New System.Drawing.Size(30, 26)
        Me.btnNotificaciones.TabIndex = 24
        Me.btnNotificaciones.Text = "🔔"
        Me.btnNotificaciones.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.Location = New System.Drawing.Point(12, 9)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(22, 23)
        Me.btnAyuda.TabIndex = 23
        Me.btnAyuda.Text = "?"
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.Location = New System.Drawing.Point(1006, 9)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(130, 18)
        Me.lblPerfil.TabIndex = 21
        Me.lblPerfil.Text = "Ana Liz Mazzarino"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Atila.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1171, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 25)
        Me.btnMinimizar.TabIndex = 19
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
        Me.btnCerrar.Location = New System.Drawing.Point(1255, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 25)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Atila.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1213, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(45, 25)
        Me.btnMaximizar.TabIndex = 20
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Atila.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1213, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(45, 25)
        Me.btnRestaurar.TabIndex = 22
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(984, 618)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(914, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 252)
        Me.Panel1.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(461, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(320, 55)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Configuracion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(1200, 650)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.Location = New System.Drawing.Point(461, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(320, 55)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Inventario"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Contacto"
        '
        'pnlCuadroNotificaciones
        '
        Me.pnlCuadroNotificaciones.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlCuadroNotificaciones.Controls.Add(Me.Label1)
        Me.pnlCuadroNotificaciones.Location = New System.Drawing.Point(157, 310)
        Me.pnlCuadroNotificaciones.Name = "pnlCuadroNotificaciones"
        Me.pnlCuadroNotificaciones.Size = New System.Drawing.Size(300, 267)
        Me.pnlCuadroNotificaciones.TabIndex = 23
        Me.pnlCuadroNotificaciones.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No hay notificaciones"
        '
        'pnlN
        '
        Me.pnlN.AllowDrop = True
        Me.pnlN.AutoScroll = True
        Me.pnlN.Location = New System.Drawing.Point(497, 333)
        Me.pnlN.Name = "pnlN"
        Me.pnlN.Size = New System.Drawing.Size(297, 190)
        Me.pnlN.TabIndex = 20
        '
        'pnllPlantillaNotificacion
        '
        Me.pnllPlantillaNotificacion.Controls.Add(Me.btnPlantillaAceptar)
        Me.pnllPlantillaNotificacion.Location = New System.Drawing.Point(923, 115)
        Me.pnllPlantillaNotificacion.Name = "pnllPlantillaNotificacion"
        Me.pnllPlantillaNotificacion.Size = New System.Drawing.Size(280, 100)
        Me.pnllPlantillaNotificacion.TabIndex = 23
        '
        'btnPlantillaAceptar
        '
        Me.btnPlantillaAceptar.Location = New System.Drawing.Point(94, 61)
        Me.btnPlantillaAceptar.Name = "btnPlantillaAceptar"
        Me.btnPlantillaAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnPlantillaAceptar.TabIndex = 27
        Me.btnPlantillaAceptar.Text = "btnPlantillaAceptar"
        Me.btnPlantillaAceptar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(936, 274)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1114, 242)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.pnllPlantillaNotificacion)
        Me.Controls.Add(Me.pnlN)
        Me.Controls.Add(Me.pnlCuadroNotificaciones)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnListadereservas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRealizarunareserva)
        Me.Controls.Add(Me.pnlArriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Principal"
        Me.pnlArriba.ResumeLayout(False)
        Me.pnlArriba.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCuadroNotificaciones.ResumeLayout(False)
        Me.pnlCuadroNotificaciones.PerformLayout()
        Me.pnllPlantillaNotificacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRealizarunareserva As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnListadereservas As System.Windows.Forms.Button
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNotificaciones As System.Windows.Forms.Button
    Friend WithEvents pnlCuadroNotificaciones As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlN As System.Windows.Forms.Panel
    Friend WithEvents pnllPlantillaNotificacion As System.Windows.Forms.Panel
    Friend WithEvents btnPlantillaAceptar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
