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
        Me.components = New System.ComponentModel.Container()
        Me.btnAgregarDatos = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.lblMostrarDineroAFavor = New System.Windows.Forms.Label()
        Me.lblDineroAFavor = New System.Windows.Forms.Label()
        Me.chkUtilizarDineroAFavor = New System.Windows.Forms.CheckBox()
        Me.txtPrecioFiesta = New System.Windows.Forms.TextBox()
        Me.cboModoPagoSeña = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNroRecibo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboCuotas = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.optPagado = New System.Windows.Forms.RadioButton()
        Me.optSeñar = New System.Windows.Forms.RadioButton()
        Me.cboModoPagoPagado = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPrecioFiesta = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.lblEditandoCliente = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtSeña = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGuardarPrecioFiesta = New System.Windows.Forms.Button()
        Me.btnEditarPrecioFiesta = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarEdicion = New System.Windows.Forms.Button()
        Me.pnlReserva = New System.Windows.Forms.Panel()
        Me.pnlDatosReserva = New System.Windows.Forms.Panel()
        Me.nudCantidadPersonas = New System.Windows.Forms.NumericUpDown()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraComienzo = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHora3 = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Marcado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.llblMotivoReserva3 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva2 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva1 = New System.Windows.Forms.LinkLabel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
        Me.chkServicio = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlCliente.SuspendLayout()
        Me.pnlReserva.SuspendLayout()
        CType(Me.nudCantidadPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.Location = New System.Drawing.Point(459, 423)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(109, 82)
        Me.btnAgregarDatos.TabIndex = 0
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(75, 66)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 105)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(85, 169)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(75, 183)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telefonos"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(75, 146)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 9
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(188, 146)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 12
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(75, 172)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 13
        Me.txtTelefono2.Visible = False
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.lblMostrarDineroAFavor)
        Me.pnlCliente.Controls.Add(Me.lblDineroAFavor)
        Me.pnlCliente.Controls.Add(Me.chkUtilizarDineroAFavor)
        Me.pnlCliente.Controls.Add(Me.txtPrecioFiesta)
        Me.pnlCliente.Controls.Add(Me.cboModoPagoSeña)
        Me.pnlCliente.Controls.Add(Me.Label17)
        Me.pnlCliente.Controls.Add(Me.txtNroRecibo)
        Me.pnlCliente.Controls.Add(Me.Label16)
        Me.pnlCliente.Controls.Add(Me.cboCuotas)
        Me.pnlCliente.Controls.Add(Me.Label15)
        Me.pnlCliente.Controls.Add(Me.optPagado)
        Me.pnlCliente.Controls.Add(Me.optSeñar)
        Me.pnlCliente.Controls.Add(Me.cboModoPagoPagado)
        Me.pnlCliente.Controls.Add(Me.Label14)
        Me.pnlCliente.Controls.Add(Me.lblPrecioFiesta)
        Me.pnlCliente.Controls.Add(Me.btnGuardarCliente)
        Me.pnlCliente.Controls.Add(Me.lblEditandoCliente)
        Me.pnlCliente.Controls.Add(Me.btnVolver)
        Me.pnlCliente.Controls.Add(Me.txtSeña)
        Me.pnlCliente.Controls.Add(Me.Label10)
        Me.pnlCliente.Controls.Add(Me.Label9)
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
        Me.pnlCliente.Controls.Add(Me.btnGuardarPrecioFiesta)
        Me.pnlCliente.Controls.Add(Me.btnEditarPrecioFiesta)
        Me.pnlCliente.Controls.Add(Me.btnEditarCliente)
        Me.pnlCliente.Controls.Add(Me.btnCancelarEdicion)
        Me.pnlCliente.Location = New System.Drawing.Point(1, 1)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(639, 571)
        Me.pnlCliente.TabIndex = 15
        Me.pnlCliente.Visible = False
        '
        'lblMostrarDineroAFavor
        '
        Me.lblMostrarDineroAFavor.AutoSize = True
        Me.lblMostrarDineroAFavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarDineroAFavor.Location = New System.Drawing.Point(126, 211)
        Me.lblMostrarDineroAFavor.Name = "lblMostrarDineroAFavor"
        Me.lblMostrarDineroAFavor.Size = New System.Drawing.Size(44, 18)
        Me.lblMostrarDineroAFavor.TabIndex = 45
        Me.lblMostrarDineroAFavor.Text = "$$$$"
        Me.lblMostrarDineroAFavor.Visible = False
        '
        'lblDineroAFavor
        '
        Me.lblDineroAFavor.AutoSize = True
        Me.lblDineroAFavor.Location = New System.Drawing.Point(50, 214)
        Me.lblDineroAFavor.Name = "lblDineroAFavor"
        Me.lblDineroAFavor.Size = New System.Drawing.Size(77, 13)
        Me.lblDineroAFavor.TabIndex = 44
        Me.lblDineroAFavor.Text = "Dinero a favor:"
        Me.lblDineroAFavor.Visible = False
        '
        'chkUtilizarDineroAFavor
        '
        Me.chkUtilizarDineroAFavor.AutoSize = True
        Me.chkUtilizarDineroAFavor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUtilizarDineroAFavor.Enabled = False
        Me.chkUtilizarDineroAFavor.Location = New System.Drawing.Point(289, 414)
        Me.chkUtilizarDineroAFavor.Name = "chkUtilizarDineroAFavor"
        Me.chkUtilizarDineroAFavor.Size = New System.Drawing.Size(127, 17)
        Me.chkUtilizarDineroAFavor.TabIndex = 43
        Me.chkUtilizarDineroAFavor.Text = "Utilizar Dinero a favor"
        Me.chkUtilizarDineroAFavor.UseVisualStyleBackColor = True
        Me.chkUtilizarDineroAFavor.Visible = False
        '
        'txtPrecioFiesta
        '
        Me.txtPrecioFiesta.Location = New System.Drawing.Point(483, 58)
        Me.txtPrecioFiesta.Name = "txtPrecioFiesta"
        Me.txtPrecioFiesta.Size = New System.Drawing.Size(51, 20)
        Me.txtPrecioFiesta.TabIndex = 41
        Me.txtPrecioFiesta.Visible = False
        '
        'cboModoPagoSeña
        '
        Me.cboModoPagoSeña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoPagoSeña.Enabled = False
        Me.cboModoPagoSeña.FormattingEnabled = True
        Me.cboModoPagoSeña.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cboModoPagoSeña.Location = New System.Drawing.Point(134, 340)
        Me.cboModoPagoSeña.Name = "cboModoPagoSeña"
        Me.cboModoPagoSeña.Size = New System.Drawing.Size(94, 21)
        Me.cboModoPagoSeña.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(51, 343)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Modo de pago:"
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.Enabled = False
        Me.txtNroRecibo.Location = New System.Drawing.Point(370, 308)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(75, 20)
        Me.txtNroRecibo.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(286, 311)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Numero Recibo"
        '
        'cboCuotas
        '
        Me.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuotas.Enabled = False
        Me.cboCuotas.FormattingEnabled = True
        Me.cboCuotas.Items.AddRange(New Object() {"Ninguna", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboCuotas.Location = New System.Drawing.Point(370, 342)
        Me.cboCuotas.Name = "cboCuotas"
        Me.cboCuotas.Size = New System.Drawing.Size(75, 21)
        Me.cboCuotas.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(286, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Cuotas"
        '
        'optPagado
        '
        Me.optPagado.AutoSize = True
        Me.optPagado.Location = New System.Drawing.Point(308, 270)
        Me.optPagado.Name = "optPagado"
        Me.optPagado.Size = New System.Drawing.Size(62, 17)
        Me.optPagado.TabIndex = 33
        Me.optPagado.TabStop = True
        Me.optPagado.Text = "Pagado"
        Me.optPagado.UseVisualStyleBackColor = True
        '
        'optSeñar
        '
        Me.optSeñar.AutoSize = True
        Me.optSeñar.Location = New System.Drawing.Point(134, 270)
        Me.optSeñar.Name = "optSeñar"
        Me.optSeñar.Size = New System.Drawing.Size(53, 17)
        Me.optSeñar.TabIndex = 32
        Me.optSeñar.TabStop = True
        Me.optSeñar.Text = "Señar"
        Me.optSeñar.UseVisualStyleBackColor = True
        '
        'cboModoPagoPagado
        '
        Me.cboModoPagoPagado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoPagoPagado.Enabled = False
        Me.cboModoPagoPagado.FormattingEnabled = True
        Me.cboModoPagoPagado.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cboModoPagoPagado.Location = New System.Drawing.Point(369, 376)
        Me.cboModoPagoPagado.Name = "cboModoPagoPagado"
        Me.cboModoPagoPagado.Size = New System.Drawing.Size(94, 21)
        Me.cboModoPagoPagado.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(286, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Modo de pago:"
        '
        'lblPrecioFiesta
        '
        Me.lblPrecioFiesta.AutoSize = True
        Me.lblPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFiesta.Location = New System.Drawing.Point(480, 58)
        Me.lblPrecioFiesta.Name = "lblPrecioFiesta"
        Me.lblPrecioFiesta.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecioFiesta.TabIndex = 29
        Me.lblPrecioFiesta.Text = "$$$$"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Location = New System.Drawing.Point(262, 62)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(55, 27)
        Me.btnGuardarCliente.TabIndex = 27
        Me.btnGuardarCliente.Text = "Guardar"
        Me.btnGuardarCliente.UseVisualStyleBackColor = True
        Me.btnGuardarCliente.Visible = False
        '
        'lblEditandoCliente
        '
        Me.lblEditandoCliente.AutoSize = True
        Me.lblEditandoCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditandoCliente.Location = New System.Drawing.Point(70, 32)
        Me.lblEditandoCliente.Name = "lblEditandoCliente"
        Me.lblEditandoCliente.Size = New System.Drawing.Size(105, 18)
        Me.lblEditandoCliente.TabIndex = 26
        Me.lblEditandoCliente.Text = "Editar Cliente"
        Me.lblEditandoCliente.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(11, 11)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(37, 23)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "<-"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtSeña
        '
        Me.txtSeña.Enabled = False
        Me.txtSeña.Location = New System.Drawing.Point(133, 306)
        Me.txtSeña.Name = "txtSeña"
        Me.txtSeña.Size = New System.Drawing.Size(94, 20)
        Me.txtSeña.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(89, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Seña: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(392, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Precio de Fiesta: "
        '
        'btnGuardarPrecioFiesta
        '
        Me.btnGuardarPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPrecioFiesta.Location = New System.Drawing.Point(540, 58)
        Me.btnGuardarPrecioFiesta.Name = "btnGuardarPrecioFiesta"
        Me.btnGuardarPrecioFiesta.Size = New System.Drawing.Size(37, 20)
        Me.btnGuardarPrecioFiesta.TabIndex = 42
        Me.btnGuardarPrecioFiesta.Text = "Guardar"
        Me.btnGuardarPrecioFiesta.UseVisualStyleBackColor = True
        Me.btnGuardarPrecioFiesta.Visible = False
        '
        'btnEditarPrecioFiesta
        '
        Me.btnEditarPrecioFiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPrecioFiesta.Location = New System.Drawing.Point(540, 58)
        Me.btnEditarPrecioFiesta.Name = "btnEditarPrecioFiesta"
        Me.btnEditarPrecioFiesta.Size = New System.Drawing.Size(37, 20)
        Me.btnEditarPrecioFiesta.TabIndex = 40
        Me.btnEditarPrecioFiesta.Text = "Editar"
        Me.btnEditarPrecioFiesta.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(196, 62)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(60, 27)
        Me.btnEditarCliente.TabIndex = 21
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        Me.btnEditarCliente.Visible = False
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(196, 62)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(60, 27)
        Me.btnCancelarEdicion.TabIndex = 28
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        Me.btnCancelarEdicion.Visible = False
        '
        'pnlReserva
        '
        Me.pnlReserva.Controls.Add(Me.pnlDatosReserva)
        Me.pnlReserva.Controls.Add(Me.nudCantidadPersonas)
        Me.pnlReserva.Controls.Add(Me.dtpHoraFinal)
        Me.pnlReserva.Controls.Add(Me.dtpHoraComienzo)
        Me.pnlReserva.Controls.Add(Me.Label13)
        Me.pnlReserva.Controls.Add(Me.Label12)
        Me.pnlReserva.Controls.Add(Me.Label11)
        Me.pnlReserva.Controls.Add(Me.lblHora3)
        Me.pnlReserva.Controls.Add(Me.dgvInventario)
        Me.pnlReserva.Controls.Add(Me.lblHora2)
        Me.pnlReserva.Controls.Add(Me.lblHora1)
        Me.pnlReserva.Controls.Add(Me.lblNoHayReservas)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva3)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva2)
        Me.pnlReserva.Controls.Add(Me.llblMotivoReserva1)
        Me.pnlReserva.Controls.Add(Me.lblFecha)
        Me.pnlReserva.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.pnlReserva.Controls.Add(Me.chkServicio)
        Me.pnlReserva.Controls.Add(Me.Label7)
        Me.pnlReserva.Controls.Add(Me.Label6)
        Me.pnlReserva.Controls.Add(Me.cboMotivo)
        Me.pnlReserva.Controls.Add(Me.Label5)
        Me.pnlReserva.Controls.Add(Me.Label4)
        Me.pnlReserva.Controls.Add(Me.btnSiguiente)
        Me.pnlReserva.Controls.Add(Me.Calendario)
        Me.pnlReserva.Controls.Add(Me.PictureBox1)
        Me.pnlReserva.Location = New System.Drawing.Point(1, 1)
        Me.pnlReserva.Name = "pnlReserva"
        Me.pnlReserva.Size = New System.Drawing.Size(639, 571)
        Me.pnlReserva.TabIndex = 16
        '
        'pnlDatosReserva
        '
        Me.pnlDatosReserva.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlDatosReserva.Location = New System.Drawing.Point(32, 465)
        Me.pnlDatosReserva.Name = "pnlDatosReserva"
        Me.pnlDatosReserva.Size = New System.Drawing.Size(225, 198)
        Me.pnlDatosReserva.TabIndex = 54
        Me.pnlDatosReserva.Visible = False
        '
        'nudCantidadPersonas
        '
        Me.nudCantidadPersonas.Location = New System.Drawing.Point(449, 227)
        Me.nudCantidadPersonas.Maximum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.nudCantidadPersonas.Name = "nudCantidadPersonas"
        Me.nudCantidadPersonas.Size = New System.Drawing.Size(38, 20)
        Me.nudCantidadPersonas.TabIndex = 29
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.CustomFormat = "H:mm"
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinal.Location = New System.Drawing.Point(520, 131)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(59, 20)
        Me.dtpHoraFinal.TabIndex = 28
        '
        'dtpHoraComienzo
        '
        Me.dtpHoraComienzo.CustomFormat = "H:mm"
        Me.dtpHoraComienzo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraComienzo.Location = New System.Drawing.Point(404, 121)
        Me.dtpHoraComienzo.Name = "dtpHoraComienzo"
        Me.dtpHoraComienzo.ShowUpDown = True
        Me.dtpHoraComienzo.Size = New System.Drawing.Size(59, 20)
        Me.dtpHoraComienzo.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(413, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Ingresar Datos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(206, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha para realizar reserva:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(386, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cantidad de cosas"
        '
        'lblHora3
        '
        Me.lblHora3.AutoSize = True
        Me.lblHora3.Location = New System.Drawing.Point(150, 372)
        Me.lblHora3.Name = "lblHora3"
        Me.lblHora3.Size = New System.Drawing.Size(45, 13)
        Me.lblHora3.TabIndex = 20
        Me.lblHora3.Text = "Label11"
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AllowUserToResizeColumns = False
        Me.dgvInventario.AllowUserToResizeRows = False
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcado, Me.Descripcion, Me.Cantidad})
        Me.dgvInventario.Location = New System.Drawing.Point(385, 293)
        Me.dgvInventario.MultiSelect = False
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.RowHeadersVisible = False
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(183, 114)
        Me.dgvInventario.TabIndex = 22
        '
        'Marcado
        '
        Me.Marcado.Frozen = True
        Me.Marcado.HeaderText = "-"
        Me.Marcado.Name = "Marcado"
        Me.Marcado.Width = 20
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Location = New System.Drawing.Point(150, 350)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(45, 13)
        Me.lblHora2.TabIndex = 19
        Me.lblHora2.Text = "Label10"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.Location = New System.Drawing.Point(150, 329)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(39, 13)
        Me.lblHora1.TabIndex = 18
        Me.lblHora1.Text = "Label9"
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(47, 314)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(172, 15)
        Me.lblNoHayReservas.TabIndex = 17
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'llblMotivoReserva3
        '
        Me.llblMotivoReserva3.AutoSize = True
        Me.llblMotivoReserva3.Location = New System.Drawing.Point(47, 372)
        Me.llblMotivoReserva3.Name = "llblMotivoReserva3"
        Me.llblMotivoReserva3.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva3.TabIndex = 16
        Me.llblMotivoReserva3.TabStop = True
        Me.llblMotivoReserva3.Text = "LinkLabel3"
        '
        'llblMotivoReserva2
        '
        Me.llblMotivoReserva2.AutoSize = True
        Me.llblMotivoReserva2.Location = New System.Drawing.Point(47, 350)
        Me.llblMotivoReserva2.Name = "llblMotivoReserva2"
        Me.llblMotivoReserva2.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva2.TabIndex = 15
        Me.llblMotivoReserva2.TabStop = True
        Me.llblMotivoReserva2.Text = "LinkLabel2"
        '
        'llblMotivoReserva1
        '
        Me.llblMotivoReserva1.AutoSize = True
        Me.llblMotivoReserva1.Location = New System.Drawing.Point(47, 329)
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
        Me.lblFecha.Location = New System.Drawing.Point(225, 296)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 18)
        Me.lblFecha.TabIndex = 13
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(26, 296)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(199, 18)
        Me.lblFiestasReservadasParaEl.TabIndex = 12
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(436, 423)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(64, 17)
        Me.chkServicio.TabIndex = 10
        Me.chkServicio.Text = "Servicio"
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad de Personas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Motivo"
        '
        'cboMotivo
        '
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Fiesta de 15", "Cumpleaño de niño", "Parrillada", "Graduación", "Otro"})
        Me.cboMotivo.Location = New System.Drawing.Point(412, 172)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.cboMotivo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(509, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de Comienzo"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(389, 492)
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
        Me.Calendario.Location = New System.Drawing.Point(32, 62)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Atila.My.Resources.Resources.Contornos
        Me.PictureBox1.Location = New System.Drawing.Point(518, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 23)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 584)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.pnlReserva)
        Me.Name = "Reservar"
        Me.Text = " "
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlReserva.ResumeLayout(False)
        Me.pnlReserva.PerformLayout()
        CType(Me.nudCantidadPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregarDatos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlCliente As System.Windows.Forms.Panel
    Friend WithEvents pnlReserva As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents chkServicio As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
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
    Friend WithEvents txtSeña As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Marcado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents lblEditandoCliente As System.Windows.Forms.Label
    Friend WithEvents btnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelarEdicion As System.Windows.Forms.Button
    Friend WithEvents lblPrecioFiesta As System.Windows.Forms.Label
    Friend WithEvents cboModoPagoPagado As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents optPagado As System.Windows.Forms.RadioButton
    Friend WithEvents optSeñar As System.Windows.Forms.RadioButton
    Friend WithEvents txtNroRecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboModoPagoSeña As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraComienzo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEditarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents txtPrecioFiesta As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents nudCantidadPersonas As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlDatosReserva As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblMostrarDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents lblDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents chkUtilizarDineroAFavor As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
