<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadeReservas
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
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblPersonas = New System.Windows.Forms.Label()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.lblMostrarMotivo = New System.Windows.Forms.Label()
        Me.lblMostrarFecha = New System.Windows.Forms.Label()
        Me.lblMostrarHora = New System.Windows.Forms.Label()
        Me.lblMostrarPersonas = New System.Windows.Forms.Label()
        Me.lblMostrarCliente = New System.Windows.Forms.Label()
        Me.lblMostrarSeña = New System.Windows.Forms.Label()
        Me.cboReservasEnElDia = New System.Windows.Forms.ComboBox()
        Me.chkMostrarServicio = New System.Windows.Forms.CheckBox()
        Me.pnlDatosReservas = New System.Windows.Forms.Panel()
        Me.lblMostrarPagado = New System.Windows.Forms.Label()
        Me.lblPagado = New System.Windows.Forms.Label()
        Me.pnlPagar = New System.Windows.Forms.Panel()
        Me.btnInsertarPago = New System.Windows.Forms.Button()
        Me.txtNroRecibo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboCuotas = New System.Windows.Forms.ComboBox()
        Me.cboModoPagoPagado = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPrecioFiesta = New System.Windows.Forms.TextBox()
        Me.lblPrecioFiesta = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGuardarPrecioFiesta = New System.Windows.Forms.Button()
        Me.btnEditarPrecioFiesta = New System.Windows.Forms.Button()
        Me.pnlSiNoSePago = New System.Windows.Forms.Panel()
        Me.btnCancelarReserva = New System.Windows.Forms.Button()
        Me.btnSurgioImprevisto = New System.Windows.Forms.Button()
        Me.pnlDatosReservas.SuspendLayout()
        Me.pnlPagar.SuspendLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSiNoSePago.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(357, 27)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(172, 15)
        Me.lblNoHayReservas.TabIndex = 26
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(535, 9)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(0, 18)
        Me.lblFechaSeleccionada.TabIndex = 22
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(336, 9)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(199, 18)
        Me.lblFiestasReservadasParaEl.TabIndex = 21
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(18, 38)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(28, 11)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(48, 16)
        Me.lblMotivo.TabIndex = 34
        Me.lblMotivo.Text = "Motivo"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(30, 36)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblFecha.TabIndex = 35
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(38, 61)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(38, 16)
        Me.lblHora.TabIndex = 36
        Me.lblHora.Text = "Hora"
        '
        'lblPersonas
        '
        Me.lblPersonas.AutoSize = True
        Me.lblPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonas.Location = New System.Drawing.Point(10, 87)
        Me.lblPersonas.Name = "lblPersonas"
        Me.lblPersonas.Size = New System.Drawing.Size(66, 16)
        Me.lblPersonas.TabIndex = 37
        Me.lblPersonas.Text = "Personas"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(19, 112)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(57, 16)
        Me.lblServicio.TabIndex = 39
        Me.lblServicio.Text = "Servicio"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(28, 138)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(49, 16)
        Me.lblCliente.TabIndex = 40
        Me.lblCliente.Text = "Cliente"
        '
        'lblSeña
        '
        Me.lblSeña.AutoSize = True
        Me.lblSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeña.Location = New System.Drawing.Point(37, 164)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(40, 16)
        Me.lblSeña.TabIndex = 41
        Me.lblSeña.Text = "Seña"
        '
        'lblMostrarMotivo
        '
        Me.lblMostrarMotivo.AutoSize = True
        Me.lblMostrarMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarMotivo.Location = New System.Drawing.Point(96, 11)
        Me.lblMostrarMotivo.Name = "lblMostrarMotivo"
        Me.lblMostrarMotivo.Size = New System.Drawing.Size(48, 16)
        Me.lblMostrarMotivo.TabIndex = 42
        Me.lblMostrarMotivo.Text = "Motivo"
        '
        'lblMostrarFecha
        '
        Me.lblMostrarFecha.AutoSize = True
        Me.lblMostrarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarFecha.Location = New System.Drawing.Point(96, 36)
        Me.lblMostrarFecha.Name = "lblMostrarFecha"
        Me.lblMostrarFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblMostrarFecha.TabIndex = 43
        Me.lblMostrarFecha.Text = "Fecha"
        '
        'lblMostrarHora
        '
        Me.lblMostrarHora.AutoSize = True
        Me.lblMostrarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarHora.Location = New System.Drawing.Point(96, 61)
        Me.lblMostrarHora.Name = "lblMostrarHora"
        Me.lblMostrarHora.Size = New System.Drawing.Size(38, 16)
        Me.lblMostrarHora.TabIndex = 44
        Me.lblMostrarHora.Text = "Hora"
        '
        'lblMostrarPersonas
        '
        Me.lblMostrarPersonas.AutoSize = True
        Me.lblMostrarPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarPersonas.Location = New System.Drawing.Point(96, 87)
        Me.lblMostrarPersonas.Name = "lblMostrarPersonas"
        Me.lblMostrarPersonas.Size = New System.Drawing.Size(66, 16)
        Me.lblMostrarPersonas.TabIndex = 45
        Me.lblMostrarPersonas.Text = "Personas"
        '
        'lblMostrarCliente
        '
        Me.lblMostrarCliente.AutoSize = True
        Me.lblMostrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarCliente.Location = New System.Drawing.Point(96, 138)
        Me.lblMostrarCliente.Name = "lblMostrarCliente"
        Me.lblMostrarCliente.Size = New System.Drawing.Size(49, 16)
        Me.lblMostrarCliente.TabIndex = 48
        Me.lblMostrarCliente.Text = "Cliente"
        '
        'lblMostrarSeña
        '
        Me.lblMostrarSeña.AutoSize = True
        Me.lblMostrarSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarSeña.Location = New System.Drawing.Point(96, 164)
        Me.lblMostrarSeña.Name = "lblMostrarSeña"
        Me.lblMostrarSeña.Size = New System.Drawing.Size(40, 16)
        Me.lblMostrarSeña.TabIndex = 49
        Me.lblMostrarSeña.Text = "Seña"
        '
        'cboReservasEnElDia
        '
        Me.cboReservasEnElDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReservasEnElDia.Enabled = False
        Me.cboReservasEnElDia.FormattingEnabled = True
        Me.cboReservasEnElDia.Location = New System.Drawing.Point(396, 45)
        Me.cboReservasEnElDia.Name = "cboReservasEnElDia"
        Me.cboReservasEnElDia.Size = New System.Drawing.Size(94, 21)
        Me.cboReservasEnElDia.TabIndex = 50
        '
        'chkMostrarServicio
        '
        Me.chkMostrarServicio.AutoSize = True
        Me.chkMostrarServicio.Enabled = False
        Me.chkMostrarServicio.Location = New System.Drawing.Point(110, 114)
        Me.chkMostrarServicio.Name = "chkMostrarServicio"
        Me.chkMostrarServicio.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarServicio.TabIndex = 51
        Me.chkMostrarServicio.UseVisualStyleBackColor = True
        Me.chkMostrarServicio.Visible = False
        '
        'pnlDatosReservas
        '
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarPagado)
        Me.pnlDatosReservas.Controls.Add(Me.lblPagado)
        Me.pnlDatosReservas.Controls.Add(Me.lblMotivo)
        Me.pnlDatosReservas.Controls.Add(Me.chkMostrarServicio)
        Me.pnlDatosReservas.Controls.Add(Me.lblFecha)
        Me.pnlDatosReservas.Controls.Add(Me.lblHora)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarSeña)
        Me.pnlDatosReservas.Controls.Add(Me.lblPersonas)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarCliente)
        Me.pnlDatosReservas.Controls.Add(Me.lblServicio)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarPersonas)
        Me.pnlDatosReservas.Controls.Add(Me.lblCliente)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarHora)
        Me.pnlDatosReservas.Controls.Add(Me.lblSeña)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarFecha)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarMotivo)
        Me.pnlDatosReservas.Location = New System.Drawing.Point(363, 72)
        Me.pnlDatosReservas.Name = "pnlDatosReservas"
        Me.pnlDatosReservas.Size = New System.Drawing.Size(225, 182)
        Me.pnlDatosReservas.TabIndex = 52
        '
        'lblMostrarPagado
        '
        Me.lblMostrarPagado.AutoSize = True
        Me.lblMostrarPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarPagado.Location = New System.Drawing.Point(96, 164)
        Me.lblMostrarPagado.Name = "lblMostrarPagado"
        Me.lblMostrarPagado.Size = New System.Drawing.Size(57, 16)
        Me.lblMostrarPagado.TabIndex = 53
        Me.lblMostrarPagado.Text = "Pagado"
        '
        'lblPagado
        '
        Me.lblPagado.AutoSize = True
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagado.Location = New System.Drawing.Point(20, 164)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(57, 16)
        Me.lblPagado.TabIndex = 52
        Me.lblPagado.Text = "Pagado"
        '
        'pnlPagar
        '
        Me.pnlPagar.Controls.Add(Me.btnInsertarPago)
        Me.pnlPagar.Controls.Add(Me.txtNroRecibo)
        Me.pnlPagar.Controls.Add(Me.Label16)
        Me.pnlPagar.Controls.Add(Me.Label14)
        Me.pnlPagar.Controls.Add(Me.cboCuotas)
        Me.pnlPagar.Controls.Add(Me.cboModoPagoPagado)
        Me.pnlPagar.Controls.Add(Me.Label15)
        Me.pnlPagar.Location = New System.Drawing.Point(363, 72)
        Me.pnlPagar.Name = "pnlPagar"
        Me.pnlPagar.Size = New System.Drawing.Size(225, 182)
        Me.pnlPagar.TabIndex = 54
        Me.pnlPagar.Visible = False
        '
        'btnInsertarPago
        '
        Me.btnInsertarPago.Location = New System.Drawing.Point(118, 138)
        Me.btnInsertarPago.Name = "btnInsertarPago"
        Me.btnInsertarPago.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarPago.TabIndex = 55
        Me.btnInsertarPago.Text = "Pagar Reserva"
        Me.btnInsertarPago.UseVisualStyleBackColor = True
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.Location = New System.Drawing.Point(110, 38)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(75, 20)
        Me.txtNroRecibo.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Numero Recibo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Modo de pago:"
        '
        'cboCuotas
        '
        Me.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuotas.FormattingEnabled = True
        Me.cboCuotas.Items.AddRange(New Object() {"Ninguna", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboCuotas.Location = New System.Drawing.Point(110, 72)
        Me.cboCuotas.Name = "cboCuotas"
        Me.cboCuotas.Size = New System.Drawing.Size(75, 21)
        Me.cboCuotas.TabIndex = 57
        '
        'cboModoPagoPagado
        '
        Me.cboModoPagoPagado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoPagoPagado.FormattingEnabled = True
        Me.cboModoPagoPagado.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cboModoPagoPagado.Location = New System.Drawing.Point(109, 106)
        Me.cboModoPagoPagado.Name = "cboModoPagoPagado"
        Me.cboModoPagoPagado.Size = New System.Drawing.Size(94, 21)
        Me.cboModoPagoPagado.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Cuotas"
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(58, 23)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 23)
        Me.btnPagar.TabIndex = 53
        Me.btnPagar.Text = "Pagar Reserva"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'txtPrecioFiesta
        '
        Me.txtPrecioFiesta.Location = New System.Drawing.Point(97, 3)
        Me.txtPrecioFiesta.Name = "txtPrecioFiesta"
        Me.txtPrecioFiesta.Size = New System.Drawing.Size(51, 20)
        Me.txtPrecioFiesta.TabIndex = 58
        Me.txtPrecioFiesta.Visible = False
        '
        'lblPrecioFiesta
        '
        Me.lblPrecioFiesta.AutoSize = True
        Me.lblPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFiesta.Location = New System.Drawing.Point(94, 3)
        Me.lblPrecioFiesta.Name = "lblPrecioFiesta"
        Me.lblPrecioFiesta.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecioFiesta.TabIndex = 56
        Me.lblPrecioFiesta.Text = "$$$$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Precio de Fiesta: "
        '
        'btnGuardarPrecioFiesta
        '
        Me.btnGuardarPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPrecioFiesta.Location = New System.Drawing.Point(154, 3)
        Me.btnGuardarPrecioFiesta.Name = "btnGuardarPrecioFiesta"
        Me.btnGuardarPrecioFiesta.Size = New System.Drawing.Size(37, 20)
        Me.btnGuardarPrecioFiesta.TabIndex = 59
        Me.btnGuardarPrecioFiesta.Text = "Guardar"
        Me.btnGuardarPrecioFiesta.UseVisualStyleBackColor = True
        Me.btnGuardarPrecioFiesta.Visible = False
        '
        'btnEditarPrecioFiesta
        '
        Me.btnEditarPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPrecioFiesta.Location = New System.Drawing.Point(154, 3)
        Me.btnEditarPrecioFiesta.Name = "btnEditarPrecioFiesta"
        Me.btnEditarPrecioFiesta.Size = New System.Drawing.Size(37, 20)
        Me.btnEditarPrecioFiesta.TabIndex = 57
        Me.btnEditarPrecioFiesta.Text = "Editar"
        Me.btnEditarPrecioFiesta.UseVisualStyleBackColor = True
        '
        'pnlSiNoSePago
        '
        Me.pnlSiNoSePago.Controls.Add(Me.txtPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.lblPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.btnGuardarPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.Label9)
        Me.pnlSiNoSePago.Controls.Add(Me.btnPagar)
        Me.pnlSiNoSePago.Controls.Add(Me.btnEditarPrecioFiesta)
        Me.pnlSiNoSePago.Location = New System.Drawing.Point(363, 260)
        Me.pnlSiNoSePago.Name = "pnlSiNoSePago"
        Me.pnlSiNoSePago.Size = New System.Drawing.Size(212, 48)
        Me.pnlSiNoSePago.TabIndex = 60
        '
        'btnCancelarReserva
        '
        Me.btnCancelarReserva.Location = New System.Drawing.Point(360, 312)
        Me.btnCancelarReserva.Name = "btnCancelarReserva"
        Me.btnCancelarReserva.Size = New System.Drawing.Size(225, 26)
        Me.btnCancelarReserva.TabIndex = 60
        Me.btnCancelarReserva.Text = "Cancelar Reserva"
        Me.btnCancelarReserva.UseVisualStyleBackColor = True
        Me.btnCancelarReserva.Visible = False
        '
        'btnSurgioImprevisto
        '
        Me.btnSurgioImprevisto.Location = New System.Drawing.Point(360, 344)
        Me.btnSurgioImprevisto.Name = "btnSurgioImprevisto"
        Me.btnSurgioImprevisto.Size = New System.Drawing.Size(225, 26)
        Me.btnSurgioImprevisto.TabIndex = 61
        Me.btnSurgioImprevisto.Text = "Surgió imprevisto"
        Me.btnSurgioImprevisto.UseVisualStyleBackColor = True
        Me.btnSurgioImprevisto.Visible = False
        '
        'ListadeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 438)
        Me.Controls.Add(Me.btnSurgioImprevisto)
        Me.Controls.Add(Me.btnCancelarReserva)
        Me.Controls.Add(Me.pnlSiNoSePago)
        Me.Controls.Add(Me.cboReservasEnElDia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblNoHayReservas)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.Controls.Add(Me.pnlDatosReservas)
        Me.Controls.Add(Me.pnlPagar)
        Me.Name = "ListadeReservas"
        Me.Text = "ListadeReservas"
        Me.pnlDatosReservas.ResumeLayout(False)
        Me.pnlDatosReservas.PerformLayout()
        Me.pnlPagar.ResumeLayout(False)
        Me.pnlPagar.PerformLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSiNoSePago.ResumeLayout(False)
        Me.pnlSiNoSePago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoHayReservas As System.Windows.Forms.Label
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents lblFiestasReservadasParaEl As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblPersonas As System.Windows.Forms.Label
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblSeña As System.Windows.Forms.Label
    Friend WithEvents lblMostrarMotivo As System.Windows.Forms.Label
    Friend WithEvents lblMostrarFecha As System.Windows.Forms.Label
    Friend WithEvents lblMostrarHora As System.Windows.Forms.Label
    Friend WithEvents lblMostrarPersonas As System.Windows.Forms.Label
    Friend WithEvents lblMostrarCliente As System.Windows.Forms.Label
    Friend WithEvents lblMostrarSeña As System.Windows.Forms.Label
    Friend WithEvents cboReservasEnElDia As System.Windows.Forms.ComboBox
    Friend WithEvents chkMostrarServicio As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDatosReservas As System.Windows.Forms.Panel
    Friend WithEvents lblMostrarPagado As System.Windows.Forms.Label
    Friend WithEvents lblPagado As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents pnlPagar As System.Windows.Forms.Panel
    Friend WithEvents txtNroRecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents cboModoPagoPagado As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnInsertarPago As System.Windows.Forms.Button
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtPrecioFiesta As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioFiesta As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents btnEditarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents pnlSiNoSePago As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarReserva As System.Windows.Forms.Button
    Friend WithEvents btnSurgioImprevisto As System.Windows.Forms.Button
End Class
