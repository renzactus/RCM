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
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlReserva = New System.Windows.Forms.Panel()
        Me.lblHora3 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.llblMotivoReserva3 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva2 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva1 = New System.Windows.Forms.LinkLabel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
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
        Me.pnlCliente.SuspendLayout()
        Me.pnlReserva.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.Location = New System.Drawing.Point(375, 334)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(91, 23)
        Me.btnAgregarDatos.TabIndex = 0
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(134, 66)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "cuadroCedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "cuadroNombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 105)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(144, 169)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(85, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "cuadroDireccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 183)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "cuadroTelefonos"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(134, 146)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(356, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Habilitar edicion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(240, 146)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 12
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(134, 172)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 13
        Me.txtTelefono2.Visible = False
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.TextBox2)
        Me.pnlCliente.Controls.Add(Me.txtPrecioTotal)
        Me.pnlCliente.Controls.Add(Me.Label10)
        Me.pnlCliente.Controls.Add(Me.Button1)
        Me.pnlCliente.Controls.Add(Me.Label9)
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
        Me.pnlCliente.Location = New System.Drawing.Point(1, 1)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(639, 543)
        Me.pnlCliente.TabIndex = 15
        Me.pnlCliente.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(134, 305)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(134, 271)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioTotal.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Seña: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Precio Total: "
        '
        'pnlReserva
        '
        Me.pnlReserva.Controls.Add(Me.lblHora3)
        Me.pnlReserva.Controls.Add(Me.lblHora2)
        Me.pnlReserva.Controls.Add(Me.lblHora1)
        Me.pnlReserva.Controls.Add(Me.lblNoHayReservas)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva3)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva2)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva1)
        Me.pnlReserva.Controls.Add(Me.lblFecha)
        Me.pnlReserva.Controls.Add(Me.lblFiestasReservadasParaEl)
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
        Me.pnlReserva.Location = New System.Drawing.Point(1, 1)
        Me.pnlReserva.Name = "pnlReserva"
        Me.pnlReserva.Size = New System.Drawing.Size(639, 543)
        Me.pnlReserva.TabIndex = 16
        '
        'lblHora3
        '
        Me.lblHora3.AutoSize = True
        Me.lblHora3.Location = New System.Drawing.Point(125, 334)
        Me.lblHora3.Name = "lblHora3"
        Me.lblHora3.Size = New System.Drawing.Size(45, 13)
        Me.lblHora3.TabIndex = 20
        Me.lblHora3.Text = "Label11"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Location = New System.Drawing.Point(125, 312)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(45, 13)
        Me.lblHora2.TabIndex = 19
        Me.lblHora2.Text = "Label10"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.Location = New System.Drawing.Point(125, 291)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(39, 13)
        Me.lblHora1.TabIndex = 18
        Me.lblHora1.Text = "Label9"
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(53, 276)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(172, 15)
        Me.lblNoHayReservas.TabIndex = 17
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'llblMotivoReserva3
        '
        Me.llblMotivoReserva3.AutoSize = True
        Me.llblMotivoReserva3.Location = New System.Drawing.Point(53, 334)
        Me.llblMotivoReserva3.Name = "llblMotivoReserva3"
        Me.llblMotivoReserva3.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva3.TabIndex = 16
        Me.llblMotivoReserva3.TabStop = True
        Me.llblMotivoReserva3.Text = "LinkLabel3"
        '
        'llblMotivoReserva2
        '
        Me.llblMotivoReserva2.AutoSize = True
        Me.llblMotivoReserva2.Location = New System.Drawing.Point(53, 312)
        Me.llblMotivoReserva2.Name = "llblMotivoReserva2"
        Me.llblMotivoReserva2.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva2.TabIndex = 15
        Me.llblMotivoReserva2.TabStop = True
        Me.llblMotivoReserva2.Text = "LinkLabel2"
        '
        'llblMotivoReserva1
        '
        Me.llblMotivoReserva1.AutoSize = True
        Me.llblMotivoReserva1.Location = New System.Drawing.Point(53, 291)
        Me.llblMotivoReserva1.Name = "llblMotivoReserva1"
        Me.llblMotivoReserva1.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva1.TabIndex = 14
        Me.llblMotivoReserva1.TabStop = True
        Me.llblMotivoReserva1.Text = "LinkLabel1"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFecha.Location = New System.Drawing.Point(231, 258)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 18)
        Me.lblFecha.TabIndex = 13
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(32, 258)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(199, 18)
        Me.lblFiestasReservadasParaEl.TabIndex = 12
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Servicio:"
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(430, 217)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(15, 14)
        Me.chkServicio.TabIndex = 10
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad de Personas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(418, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Motivo"
        '
        'dudCantidadPersonas
        '
        Me.dudCantidadPersonas.Location = New System.Drawing.Point(389, 178)
        Me.dudCantidadPersonas.Name = "dudCantidadPersonas"
        Me.dudCantidadPersonas.Size = New System.Drawing.Size(120, 20)
        Me.dudCantidadPersonas.TabIndex = 7
        Me.dudCantidadPersonas.Text = "0"
        '
        'cboMotivo
        '
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Fiesta de 15", "Cumpleaño de niño", "Parrillada", "Graduación", "Otro"})
        Me.cboMotivo.Location = New System.Drawing.Point(389, 138)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.cboMotivo.TabIndex = 6
        Me.cboMotivo.Text = "Ingresar Motivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de Comienzo"
        '
        'dudHoraFinal
        '
        Me.dudHoraFinal.Location = New System.Drawing.Point(389, 99)
        Me.dudHoraFinal.Name = "dudHoraFinal"
        Me.dudHoraFinal.Size = New System.Drawing.Size(120, 20)
        Me.dudHoraFinal.TabIndex = 3
        Me.dudHoraFinal.Text = "23:59"
        '
        'dudHoraComienzo
        '
        Me.dudHoraComienzo.Location = New System.Drawing.Point(389, 60)
        Me.dudHoraComienzo.Name = "dudHoraComienzo"
        Me.dudHoraComienzo.Size = New System.Drawing.Size(120, 20)
        Me.dudHoraComienzo.TabIndex = 2
        Me.dudHoraComienzo.Text = "0:00"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(348, 292)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(155, 55)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(38, 31)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 556)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.pnlReserva)
        Me.Name = "Reservar"
        Me.Text = " "
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
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents pnlReserva As System.Windows.Forms.Panel
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
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblFiestasReservadasParaEl As System.Windows.Forms.Label
    Friend WithEvents llblMotivoReserva1 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva3 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblNoHayReservas As System.Windows.Forms.Label
    Friend WithEvents lblHora3 As System.Windows.Forms.Label
    Friend WithEvents lblHora2 As System.Windows.Forms.Label
    Friend WithEvents lblHora1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
