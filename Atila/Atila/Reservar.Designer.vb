<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservar
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
        Me.btnAgregarDatos = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.pnlFechaHora = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DomainUpDown3 = New System.Windows.Forms.DomainUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        Me.pnlFechaHora.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.Location = New System.Drawing.Point(150, 194)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(91, 23)
        Me.btnAgregarDatos.TabIndex = 0
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(109, 33)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "cuadroCedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "cuadroNombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(109, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(18, 153)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(85, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "cuadroDireccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(109, 150)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "cuadroTelefonos"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(109, 113)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(144, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Habilitar edicion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(215, 113)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 12
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(109, 139)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 13
        Me.txtTelefono2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Atila.My.Resources.Resources.LOGO_RCM
        Me.PictureBox1.Location = New System.Drawing.Point(674, 430)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.pnl)
        Me.pnlCliente.Controls.Add(Me.CheckBox1)
        Me.pnlCliente.Controls.Add(Me.txtCedula)
        Me.pnlCliente.Controls.Add(Me.txtTelefono2)
        Me.pnlCliente.Controls.Add(Me.btnAgregarDatos)
        Me.pnlCliente.Controls.Add(Me.Label1)
        Me.pnlCliente.Controls.Add(Me.btnAgregarTelefonos)
        Me.pnlCliente.Controls.Add(Me.txtNombre)
        Me.pnlCliente.Controls.Add(Me.Label2)
        Me.pnlCliente.Controls.Add(Me.Label3)
        Me.pnlCliente.Controls.Add(Me.txtDireccion)
        Me.pnlCliente.Controls.Add(Me.txtTelefono1)
        Me.pnlCliente.Controls.Add(Me.lblDireccion)
        Me.pnlCliente.Location = New System.Drawing.Point(26, 52)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(450, 354)
        Me.pnlCliente.TabIndex = 15
        '
        'pnlFechaHora
        '
        Me.pnlFechaHora.Controls.Add(Me.Label5)
        Me.pnlFechaHora.Controls.Add(Me.Label4)
        Me.pnlFechaHora.Controls.Add(Me.DomainUpDown2)
        Me.pnlFechaHora.Controls.Add(Me.DomainUpDown1)
        Me.pnlFechaHora.Controls.Add(Me.Siguiente)
        Me.pnlFechaHora.Controls.Add(Me.MonthCalendar1)
        Me.pnlFechaHora.Location = New System.Drawing.Point(26, 52)
        Me.pnlFechaHora.Name = "pnlFechaHora"
        Me.pnlFechaHora.Size = New System.Drawing.Size(450, 354)
        Me.pnlFechaHora.TabIndex = 16
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(60, 23)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(298, 250)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 22)
        Me.Siguiente.TabIndex = 1
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(142, 226)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 2
        Me.DomainUpDown1.Text = "0:00"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.Location = New System.Drawing.Point(142, 270)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown2.TabIndex = 3
        Me.DomainUpDown2.Text = "23:59"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de Comienzo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora Final"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Label8)
        Me.pnl.Controls.Add(Me.CheckBox2)
        Me.pnl.Controls.Add(Me.Label7)
        Me.pnl.Controls.Add(Me.Label6)
        Me.pnl.Controls.Add(Me.DomainUpDown3)
        Me.pnl.Controls.Add(Me.ComboBox1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(450, 354)
        Me.pnl.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fiesta de 15", "Cumpleaño de niño", "Parrillada", "Graduación", "Otro"})
        Me.ComboBox1.Location = New System.Drawing.Point(187, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DomainUpDown3
        '
        Me.DomainUpDown3.Location = New System.Drawing.Point(187, 68)
        Me.DomainUpDown3.Name = "DomainUpDown3"
        Me.DomainUpDown3.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown3.TabIndex = 1
        Me.DomainUpDown3.Text = "DomainUpDown3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Motivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cantidad de Personas"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(194, 115)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Servicio:"
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 478)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.pnlFechaHora)
        Me.Name = "Reservar"
        Me.Text = "Reservar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlFechaHora.ResumeLayout(False)
        Me.pnlFechaHora.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregarDatos As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents pnlFechaHora As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown2 As System.Windows.Forms.DomainUpDown
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DomainUpDown3 As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
