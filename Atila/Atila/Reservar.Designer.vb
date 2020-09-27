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
        Me.pnlReserva = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkServicio = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dudCantidadPersonas = New System.Windows.Forms.DomainUpDown()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dudHoraFinal = New System.Windows.Forms.DomainUpDown()
        Me.dudHoraComienzo = New System.Windows.Forms.DomainUpDown()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        Me.pnlReserva.SuspendLayout()
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
        Me.PictureBox1.Location = New System.Drawing.Point(646, 505)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pnlCliente
        '
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
        Me.pnlCliente.Location = New System.Drawing.Point(47, 12)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(581, 543)
        Me.pnlCliente.TabIndex = 15
        Me.pnlCliente.Visible = False
        '
        'pnlReserva
        '
        Me.pnlReserva.Controls.Add(Me.Label8)
        Me.pnlReserva.Controls.Add(Me.chkServicio)
        Me.pnlReserva.Controls.Add(Me.Label7)
        Me.pnlReserva.Controls.Add(Me.Label6)
        Me.pnlReserva.Controls.Add(Me.dudCantidadPersonas)
        Me.pnlReserva.Controls.Add(Me.cboMotivo)
        Me.pnlReserva.Controls.Add(Me.Label5)
        Me.pnlReserva.Controls.Add(Me.Label4)
        Me.pnlReserva.Controls.Add(Me.dudHoraFinal)
        Me.pnlReserva.Controls.Add(Me.dudHoraComienzo)
        Me.pnlReserva.Controls.Add(Me.btnSiguiente)
        Me.pnlReserva.Controls.Add(Me.Calendario)
        Me.pnlReserva.Location = New System.Drawing.Point(47, 12)
        Me.pnlReserva.Name = "pnlReserva"
        Me.pnlReserva.Size = New System.Drawing.Size(581, 543)
        Me.pnlReserva.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Servicio:"
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(142, 414)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(15, 14)
        Me.chkServicio.TabIndex = 10
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad de Personas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Motivo"
        '
        'dudCantidadPersonas
        '
        Me.dudCantidadPersonas.Location = New System.Drawing.Point(142, 367)
        Me.dudCantidadPersonas.Name = "dudCantidadPersonas"
        Me.dudCantidadPersonas.Size = New System.Drawing.Size(120, 20)
        Me.dudCantidadPersonas.TabIndex = 7
        Me.dudCantidadPersonas.Text = "0"
        '
        'cboMotivo
        '
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Fiesta de 15", "Cumpleaño de niño", "Parrillada", "Graduación", "Otro"})
        Me.cboMotivo.Location = New System.Drawing.Point(142, 321)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.cboMotivo.TabIndex = 6
        Me.cboMotivo.Text = "Ingresar Motivo"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de Comienzo"
        '
        'dudHoraFinal
        '
        Me.dudHoraFinal.Location = New System.Drawing.Point(142, 270)
        Me.dudHoraFinal.Name = "dudHoraFinal"
        Me.dudHoraFinal.Size = New System.Drawing.Size(120, 20)
        Me.dudHoraFinal.TabIndex = 3
        Me.dudHoraFinal.Text = "23:59"
        '
        'dudHoraComienzo
        '
        Me.dudHoraComienzo.Location = New System.Drawing.Point(142, 226)
        Me.dudHoraComienzo.Name = "dudHoraComienzo"
        Me.dudHoraComienzo.Size = New System.Drawing.Size(120, 20)
        Me.dudHoraComienzo.TabIndex = 2
        Me.dudHoraComienzo.Text = "0:00"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(386, 442)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 22)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(60, 23)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(646, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 556)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlReserva)
        Me.Controls.Add(Me.pnlCliente)
        Me.Name = "Reservar"
        Me.Text = "Reservar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlReserva.ResumeLayout(False)
        Me.pnlReserva.PerformLayout()
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
    Friend WithEvents pnlReserva As System.Windows.Forms.Panel
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dudHoraFinal As System.Windows.Forms.DomainUpDown
    Friend WithEvents dudHoraComienzo As System.Windows.Forms.DomainUpDown
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkServicio As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dudCantidadPersonas As System.Windows.Forms.DomainUpDown
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
