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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblIngreseLosDatosDelCliente = New System.Windows.Forms.Label()
        Me.lblAgadu = New System.Windows.Forms.Label()
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
        Me.pbCedula = New System.Windows.Forms.PictureBox()
        Me.pbNombre = New System.Windows.Forms.PictureBox()
        Me.pbTelefonos1 = New System.Windows.Forms.PictureBox()
        Me.pbTelefono2 = New System.Windows.Forms.PictureBox()
        Me.pbDireccion = New System.Windows.Forms.PictureBox()
        Me.pbSeña = New System.Windows.Forms.PictureBox()
        Me.pbModoPago = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbCuotas = New System.Windows.Forms.PictureBox()
        Me.pbModoPago1 = New System.Windows.Forms.PictureBox()
        Me.pnlReserva = New System.Windows.Forms.Panel()
        Me.nudCantidadPersonas = New System.Windows.Forms.NumericUpDown()
        Me.pbCantidadPersonas = New System.Windows.Forms.PictureBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.pbMotivo = New System.Windows.Forms.PictureBox()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.pbHoraFinal = New System.Windows.Forms.PictureBox()
        Me.dtpHoraComienzo = New System.Windows.Forms.DateTimePicker()
        Me.pbHoraComienzo = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlDatosReserva = New System.Windows.Forms.Panel()
        Me.lblIngresarDatos = New System.Windows.Forms.Label()
        Me.lblFechaParaReservar = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.pbNotacion = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlCliente.SuspendLayout()
        CType(Me.pbCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelefonos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelefono2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModoPago1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReserva.SuspendLayout()
        CType(Me.nudCantidadPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCantidadPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHoraFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHoraComienzo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNotacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarDatos.FlatAppearance.BorderSize = 0
        Me.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDatos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDatos.Location = New System.Drawing.Point(977, 680)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(179, 82)
        Me.btnAgregarDatos.TabIndex = 0
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(220, 145)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(203, 29)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtNombre.Location = New System.Drawing.Point(220, 203)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 29)
        Me.txtNombre.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(107, 321)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(105, 24)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(220, 318)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(203, 29)
        Me.txtDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telefonos:"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtTelefono1.Location = New System.Drawing.Point(220, 261)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(203, 29)
        Me.txtTelefono1.TabIndex = 9
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarTelefonos.FlatAppearance.BorderSize = 0
        Me.btnAgregarTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefonos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(426, 261)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(31, 29)
        Me.btnAgregarTelefonos.TabIndex = 12
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtTelefono2.Location = New System.Drawing.Point(220, 300)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(203, 29)
        Me.txtTelefono2.TabIndex = 13
        Me.txtTelefono2.Visible = False
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.lblIngreseLosDatosDelCliente)
        Me.pnlCliente.Controls.Add(Me.lblAgadu)
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
        Me.pnlCliente.Controls.Add(Me.txtCedula)
        Me.pnlCliente.Controls.Add(Me.pbCedula)
        Me.pnlCliente.Controls.Add(Me.pbNombre)
        Me.pnlCliente.Controls.Add(Me.pbTelefonos1)
        Me.pnlCliente.Controls.Add(Me.pbTelefono2)
        Me.pnlCliente.Controls.Add(Me.pbDireccion)
        Me.pnlCliente.Controls.Add(Me.pbSeña)
        Me.pnlCliente.Controls.Add(Me.pbModoPago)
        Me.pnlCliente.Controls.Add(Me.PictureBox2)
        Me.pnlCliente.Controls.Add(Me.pbCuotas)
        Me.pnlCliente.Controls.Add(Me.pbModoPago1)
        Me.pnlCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCliente.Location = New System.Drawing.Point(1, 1)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(1221, 807)
        Me.pnlCliente.TabIndex = 15
        Me.pnlCliente.Visible = False
        '
        'lblIngreseLosDatosDelCliente
        '
        Me.lblIngreseLosDatosDelCliente.AutoSize = True
        Me.lblIngreseLosDatosDelCliente.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseLosDatosDelCliente.Location = New System.Drawing.Point(80, 62)
        Me.lblIngreseLosDatosDelCliente.Name = "lblIngreseLosDatosDelCliente"
        Me.lblIngreseLosDatosDelCliente.Size = New System.Drawing.Size(299, 24)
        Me.lblIngreseLosDatosDelCliente.TabIndex = 69
        Me.lblIngreseLosDatosDelCliente.Text = "Ingrese los datos del cliente:"
        '
        'lblAgadu
        '
        Me.lblAgadu.AutoSize = True
        Me.lblAgadu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgadu.Location = New System.Drawing.Point(717, 237)
        Me.lblAgadu.Name = "lblAgadu"
        Me.lblAgadu.Size = New System.Drawing.Size(248, 17)
        Me.lblAgadu.TabIndex = 46
        Me.lblAgadu.Text = "El cliente tiene que pagar a AGADU..."
        Me.lblAgadu.Visible = False
        '
        'lblMostrarDineroAFavor
        '
        Me.lblMostrarDineroAFavor.AutoSize = True
        Me.lblMostrarDineroAFavor.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarDineroAFavor.Location = New System.Drawing.Point(250, 365)
        Me.lblMostrarDineroAFavor.Name = "lblMostrarDineroAFavor"
        Me.lblMostrarDineroAFavor.Size = New System.Drawing.Size(69, 30)
        Me.lblMostrarDineroAFavor.TabIndex = 45
        Me.lblMostrarDineroAFavor.Text = "$$$$"
        Me.lblMostrarDineroAFavor.Visible = False
        '
        'lblDineroAFavor
        '
        Me.lblDineroAFavor.AutoSize = True
        Me.lblDineroAFavor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroAFavor.Location = New System.Drawing.Point(107, 370)
        Me.lblDineroAFavor.Name = "lblDineroAFavor"
        Me.lblDineroAFavor.Size = New System.Drawing.Size(150, 24)
        Me.lblDineroAFavor.TabIndex = 44
        Me.lblDineroAFavor.Text = "Dinero a favor:"
        Me.lblDineroAFavor.Visible = False
        '
        'chkUtilizarDineroAFavor
        '
        Me.chkUtilizarDineroAFavor.AutoSize = True
        Me.chkUtilizarDineroAFavor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUtilizarDineroAFavor.Enabled = False
        Me.chkUtilizarDineroAFavor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUtilizarDineroAFavor.Location = New System.Drawing.Point(540, 747)
        Me.chkUtilizarDineroAFavor.Name = "chkUtilizarDineroAFavor"
        Me.chkUtilizarDineroAFavor.Size = New System.Drawing.Size(237, 28)
        Me.chkUtilizarDineroAFavor.TabIndex = 43
        Me.chkUtilizarDineroAFavor.Text = "Utilizar Dinero a favor:"
        Me.chkUtilizarDineroAFavor.UseVisualStyleBackColor = True
        Me.chkUtilizarDineroAFavor.Visible = False
        '
        'txtPrecioFiesta
        '
        Me.txtPrecioFiesta.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioFiesta.Location = New System.Drawing.Point(862, 175)
        Me.txtPrecioFiesta.Name = "txtPrecioFiesta"
        Me.txtPrecioFiesta.Size = New System.Drawing.Size(90, 35)
        Me.txtPrecioFiesta.TabIndex = 41
        Me.txtPrecioFiesta.Visible = False
        '
        'cboModoPagoSeña
        '
        Me.cboModoPagoSeña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoPagoSeña.Enabled = False
        Me.cboModoPagoSeña.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModoPagoSeña.FormattingEnabled = True
        Me.cboModoPagoSeña.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cboModoPagoSeña.Location = New System.Drawing.Point(236, 573)
        Me.cboModoPagoSeña.Name = "cboModoPagoSeña"
        Me.cboModoPagoSeña.Size = New System.Drawing.Size(123, 32)
        Me.cboModoPagoSeña.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(83, 581)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(149, 24)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Modo de pago:"
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.Enabled = False
        Me.txtNroRecibo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRecibo.Location = New System.Drawing.Point(761, 521)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(133, 32)
        Me.txtNroRecibo.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(536, 524)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 24)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Numero de Recibo:"
        '
        'cboCuotas
        '
        Me.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuotas.Enabled = False
        Me.cboCuotas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuotas.FormattingEnabled = True
        Me.cboCuotas.Items.AddRange(New Object() {"Ninguna", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboCuotas.Location = New System.Drawing.Point(761, 588)
        Me.cboCuotas.Name = "cboCuotas"
        Me.cboCuotas.Size = New System.Drawing.Size(105, 32)
        Me.cboCuotas.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(536, 598)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 24)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Cuotas:"
        '
        'optPagado
        '
        Me.optPagado.AutoSize = True
        Me.optPagado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPagado.Location = New System.Drawing.Point(660, 454)
        Me.optPagado.Name = "optPagado"
        Me.optPagado.Size = New System.Drawing.Size(100, 28)
        Me.optPagado.TabIndex = 33
        Me.optPagado.TabStop = True
        Me.optPagado.Text = "Pagado"
        Me.optPagado.UseVisualStyleBackColor = True
        '
        'optSeñar
        '
        Me.optSeñar.AutoSize = True
        Me.optSeñar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSeñar.Location = New System.Drawing.Point(280, 454)
        Me.optSeñar.Name = "optSeñar"
        Me.optSeñar.Size = New System.Drawing.Size(84, 28)
        Me.optSeñar.TabIndex = 32
        Me.optSeñar.TabStop = True
        Me.optSeñar.Text = "Señar"
        Me.optSeñar.UseVisualStyleBackColor = True
        '
        'cboModoPagoPagado
        '
        Me.cboModoPagoPagado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoPagoPagado.Enabled = False
        Me.cboModoPagoPagado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModoPagoPagado.FormattingEnabled = True
        Me.cboModoPagoPagado.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cboModoPagoPagado.Location = New System.Drawing.Point(761, 664)
        Me.cboModoPagoPagado.Name = "cboModoPagoPagado"
        Me.cboModoPagoPagado.Size = New System.Drawing.Size(133, 32)
        Me.cboModoPagoPagado.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(536, 672)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 24)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Modo de pago:"
        '
        'lblPrecioFiesta
        '
        Me.lblPrecioFiesta.AutoSize = True
        Me.lblPrecioFiesta.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFiesta.Location = New System.Drawing.Point(859, 181)
        Me.lblPrecioFiesta.Name = "lblPrecioFiesta"
        Me.lblPrecioFiesta.Size = New System.Drawing.Size(25, 27)
        Me.lblPrecioFiesta.TabIndex = 29
        Me.lblPrecioFiesta.Text = "0"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarCliente.FlatAppearance.BorderSize = 0
        Me.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCliente.Location = New System.Drawing.Point(435, 108)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(62, 27)
        Me.btnGuardarCliente.TabIndex = 27
        Me.btnGuardarCliente.Text = "Guardar"
        Me.btnGuardarCliente.UseVisualStyleBackColor = True
        Me.btnGuardarCliente.Visible = False
        '
        'lblEditandoCliente
        '
        Me.lblEditandoCliente.AutoSize = True
        Me.lblEditandoCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditandoCliente.Location = New System.Drawing.Point(231, 111)
        Me.lblEditandoCliente.Name = "lblEditandoCliente"
        Me.lblEditandoCliente.Size = New System.Drawing.Size(135, 19)
        Me.lblEditandoCliente.TabIndex = 26
        Me.lblEditandoCliente.Text = "Editando Cliente"
        Me.lblEditandoCliente.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(30, 11)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(116, 33)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "<  Volver Atrás"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtSeña
        '
        Me.txtSeña.Enabled = False
        Me.txtSeña.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeña.Location = New System.Drawing.Point(236, 499)
        Me.txtSeña.Name = "txtSeña"
        Me.txtSeña.Size = New System.Drawing.Size(121, 32)
        Me.txtSeña.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 507)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Seña: "
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Image = Global.Atila.My.Resources.Resources.precio_total
        Me.Label9.Location = New System.Drawing.Point(714, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 24)
        Me.Label9.TabIndex = 14
        '
        'btnGuardarPrecioFiesta
        '
        Me.btnGuardarPrecioFiesta.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardarPrecioFiesta.FlatAppearance.BorderSize = 0
        Me.btnGuardarPrecioFiesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPrecioFiesta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPrecioFiesta.Location = New System.Drawing.Point(952, 179)
        Me.btnGuardarPrecioFiesta.Name = "btnGuardarPrecioFiesta"
        Me.btnGuardarPrecioFiesta.Size = New System.Drawing.Size(62, 25)
        Me.btnGuardarPrecioFiesta.TabIndex = 42
        Me.btnGuardarPrecioFiesta.Text = "Guardar"
        Me.btnGuardarPrecioFiesta.UseVisualStyleBackColor = True
        Me.btnGuardarPrecioFiesta.Visible = False
        '
        'btnEditarPrecioFiesta
        '
        Me.btnEditarPrecioFiesta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarPrecioFiesta.FlatAppearance.BorderSize = 0
        Me.btnEditarPrecioFiesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPrecioFiesta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPrecioFiesta.Location = New System.Drawing.Point(952, 179)
        Me.btnEditarPrecioFiesta.Name = "btnEditarPrecioFiesta"
        Me.btnEditarPrecioFiesta.Size = New System.Drawing.Size(62, 25)
        Me.btnEditarPrecioFiesta.TabIndex = 40
        Me.btnEditarPrecioFiesta.Text = "Editar"
        Me.btnEditarPrecioFiesta.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCliente.FlatAppearance.BorderSize = 0
        Me.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCliente.Location = New System.Drawing.Point(377, 108)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(65, 27)
        Me.btnEditarCliente.TabIndex = 21
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        Me.btnEditarCliente.Visible = False
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarEdicion.FlatAppearance.BorderSize = 0
        Me.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEdicion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(377, 108)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(65, 27)
        Me.btnCancelarEdicion.TabIndex = 28
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        Me.btnCancelarEdicion.Visible = False
        '
        'pbCedula
        '
        Me.pbCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCedula.Location = New System.Drawing.Point(218, 143)
        Me.pbCedula.Name = "pbCedula"
        Me.pbCedula.Size = New System.Drawing.Size(207, 33)
        Me.pbCedula.TabIndex = 70
        Me.pbCedula.TabStop = False
        '
        'pbNombre
        '
        Me.pbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbNombre.Location = New System.Drawing.Point(218, 201)
        Me.pbNombre.Name = "pbNombre"
        Me.pbNombre.Size = New System.Drawing.Size(207, 33)
        Me.pbNombre.TabIndex = 71
        Me.pbNombre.TabStop = False
        '
        'pbTelefonos1
        '
        Me.pbTelefonos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbTelefonos1.Location = New System.Drawing.Point(218, 259)
        Me.pbTelefonos1.Name = "pbTelefonos1"
        Me.pbTelefonos1.Size = New System.Drawing.Size(207, 33)
        Me.pbTelefonos1.TabIndex = 73
        Me.pbTelefonos1.TabStop = False
        '
        'pbTelefono2
        '
        Me.pbTelefono2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbTelefono2.Location = New System.Drawing.Point(218, 298)
        Me.pbTelefono2.Name = "pbTelefono2"
        Me.pbTelefono2.Size = New System.Drawing.Size(207, 33)
        Me.pbTelefono2.TabIndex = 74
        Me.pbTelefono2.TabStop = False
        Me.pbTelefono2.Visible = False
        '
        'pbDireccion
        '
        Me.pbDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbDireccion.Location = New System.Drawing.Point(218, 316)
        Me.pbDireccion.Name = "pbDireccion"
        Me.pbDireccion.Size = New System.Drawing.Size(207, 33)
        Me.pbDireccion.TabIndex = 75
        Me.pbDireccion.TabStop = False
        '
        'pbSeña
        '
        Me.pbSeña.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbSeña.Location = New System.Drawing.Point(234, 497)
        Me.pbSeña.Name = "pbSeña"
        Me.pbSeña.Size = New System.Drawing.Size(125, 36)
        Me.pbSeña.TabIndex = 76
        Me.pbSeña.TabStop = False
        '
        'pbModoPago
        '
        Me.pbModoPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbModoPago.Location = New System.Drawing.Point(233, 571)
        Me.pbModoPago.Name = "pbModoPago"
        Me.pbModoPago.Size = New System.Drawing.Size(127, 36)
        Me.pbModoPago.TabIndex = 72
        Me.pbModoPago.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(759, 519)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 36)
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'pbCuotas
        '
        Me.pbCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCuotas.Location = New System.Drawing.Point(759, 586)
        Me.pbCuotas.Name = "pbCuotas"
        Me.pbCuotas.Size = New System.Drawing.Size(109, 36)
        Me.pbCuotas.TabIndex = 79
        Me.pbCuotas.TabStop = False
        '
        'pbModoPago1
        '
        Me.pbModoPago1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbModoPago1.Location = New System.Drawing.Point(759, 662)
        Me.pbModoPago1.Name = "pbModoPago1"
        Me.pbModoPago1.Size = New System.Drawing.Size(137, 36)
        Me.pbModoPago1.TabIndex = 78
        Me.pbModoPago1.TabStop = False
        '
        'pnlReserva
        '
        Me.pnlReserva.Controls.Add(Me.nudCantidadPersonas)
        Me.pnlReserva.Controls.Add(Me.pbCantidadPersonas)
        Me.pnlReserva.Controls.Add(Me.txtNota)
        Me.pnlReserva.Controls.Add(Me.cboMotivo)
        Me.pnlReserva.Controls.Add(Me.pbMotivo)
        Me.pnlReserva.Controls.Add(Me.dtpHoraFinal)
        Me.pnlReserva.Controls.Add(Me.pbHoraFinal)
        Me.pnlReserva.Controls.Add(Me.dtpHoraComienzo)
        Me.pnlReserva.Controls.Add(Me.pbHoraComienzo)
        Me.pnlReserva.Controls.Add(Me.Label8)
        Me.pnlReserva.Controls.Add(Me.pnlDatosReserva)
        Me.pnlReserva.Controls.Add(Me.lblIngresarDatos)
        Me.pnlReserva.Controls.Add(Me.lblFechaParaReservar)
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
        Me.pnlReserva.Controls.Add(Me.Label5)
        Me.pnlReserva.Controls.Add(Me.Label4)
        Me.pnlReserva.Controls.Add(Me.btnSiguiente)
        Me.pnlReserva.Controls.Add(Me.Calendario)
        Me.pnlReserva.Controls.Add(Me.pbNotacion)
        Me.pnlReserva.Controls.Add(Me.PictureBox1)
        Me.pnlReserva.Location = New System.Drawing.Point(1, 1)
        Me.pnlReserva.Name = "pnlReserva"
        Me.pnlReserva.Size = New System.Drawing.Size(1221, 807)
        Me.pnlReserva.TabIndex = 16
        '
        'nudCantidadPersonas
        '
        Me.nudCantidadPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidadPersonas.Location = New System.Drawing.Point(768, 419)
        Me.nudCantidadPersonas.Maximum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.nudCantidadPersonas.Name = "nudCantidadPersonas"
        Me.nudCantidadPersonas.Size = New System.Drawing.Size(67, 26)
        Me.nudCantidadPersonas.TabIndex = 29
        Me.nudCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbCantidadPersonas
        '
        Me.pbCantidadPersonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCantidadPersonas.Location = New System.Drawing.Point(766, 417)
        Me.pbCantidadPersonas.Name = "pbCantidadPersonas"
        Me.pbCantidadPersonas.Size = New System.Drawing.Size(71, 30)
        Me.pbCantidadPersonas.TabIndex = 69
        Me.pbCantidadPersonas.TabStop = False
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(705, 280)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(194, 79)
        Me.txtNota.TabIndex = 58
        '
        'cboMotivo
        '
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Fiesta con Baile", "Fiesta sin Baile", "Parrillada"})
        Me.cboMotivo.Location = New System.Drawing.Point(711, 197)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(172, 26)
        Me.cboMotivo.TabIndex = 6
        '
        'pbMotivo
        '
        Me.pbMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbMotivo.Location = New System.Drawing.Point(709, 195)
        Me.pbMotivo.Name = "pbMotivo"
        Me.pbMotivo.Size = New System.Drawing.Size(176, 30)
        Me.pbMotivo.TabIndex = 67
        Me.pbMotivo.TabStop = False
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.CustomFormat = "H:mm"
        Me.dtpHoraFinal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinal.Location = New System.Drawing.Point(848, 103)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(66, 26)
        Me.dtpHoraFinal.TabIndex = 28
        '
        'pbHoraFinal
        '
        Me.pbHoraFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbHoraFinal.Location = New System.Drawing.Point(846, 101)
        Me.pbHoraFinal.Name = "pbHoraFinal"
        Me.pbHoraFinal.Size = New System.Drawing.Size(70, 30)
        Me.pbHoraFinal.TabIndex = 65
        Me.pbHoraFinal.TabStop = False
        '
        'dtpHoraComienzo
        '
        Me.dtpHoraComienzo.CustomFormat = "H:mm"
        Me.dtpHoraComienzo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraComienzo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraComienzo.Location = New System.Drawing.Point(678, 103)
        Me.dtpHoraComienzo.Name = "dtpHoraComienzo"
        Me.dtpHoraComienzo.ShowUpDown = True
        Me.dtpHoraComienzo.Size = New System.Drawing.Size(66, 26)
        Me.dtpHoraComienzo.TabIndex = 27
        '
        'pbHoraComienzo
        '
        Me.pbHoraComienzo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbHoraComienzo.Location = New System.Drawing.Point(676, 101)
        Me.pbHoraComienzo.Name = "pbHoraComienzo"
        Me.pbHoraComienzo.Size = New System.Drawing.Size(70, 30)
        Me.pbHoraComienzo.TabIndex = 64
        Me.pbHoraComienzo.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(772, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Nota:"
        '
        'pnlDatosReserva
        '
        Me.pnlDatosReserva.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosReserva.BackgroundImage = Global.Atila.My.Resources.Resources.DesplegadorNuevoNuevo
        Me.pnlDatosReserva.Location = New System.Drawing.Point(84, 633)
        Me.pnlDatosReserva.Name = "pnlDatosReserva"
        Me.pnlDatosReserva.Size = New System.Drawing.Size(297, 631)
        Me.pnlDatosReserva.TabIndex = 54
        Me.pnlDatosReserva.Visible = False
        '
        'lblIngresarDatos
        '
        Me.lblIngresarDatos.AutoSize = True
        Me.lblIngresarDatos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresarDatos.Location = New System.Drawing.Point(718, 31)
        Me.lblIngresarDatos.Name = "lblIngresarDatos"
        Me.lblIngresarDatos.Size = New System.Drawing.Size(154, 22)
        Me.lblIngresarDatos.TabIndex = 26
        Me.lblIngresarDatos.Text = "Ingresar Datos:"
        '
        'lblFechaParaReservar
        '
        Me.lblFechaParaReservar.AutoSize = True
        Me.lblFechaParaReservar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaParaReservar.Location = New System.Drawing.Point(84, 237)
        Me.lblFechaParaReservar.Name = "lblFechaParaReservar"
        Me.lblFechaParaReservar.Size = New System.Drawing.Size(205, 22)
        Me.lblFechaParaReservar.TabIndex = 25
        Me.lblFechaParaReservar.Text = "Fecha para reservar:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(766, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Utiliza:"
        '
        'lblHora3
        '
        Me.lblHora3.AutoSize = True
        Me.lblHora3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora3.Location = New System.Drawing.Point(264, 130)
        Me.lblHora3.Name = "lblHora3"
        Me.lblHora3.Size = New System.Drawing.Size(64, 18)
        Me.lblHora3.TabIndex = 20
        Me.lblHora3.Text = "Label11"
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AllowUserToResizeColumns = False
        Me.dgvInventario.AllowUserToResizeRows = False
        Me.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventario.ColumnHeadersHeight = 30
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcado, Me.Descripcion, Me.Cantidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventario.EnableHeadersVisualStyles = False
        Me.dgvInventario.Location = New System.Drawing.Point(662, 496)
        Me.dgvInventario.MultiSelect = False
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventario.RowHeadersVisible = False
        Me.dgvInventario.RowTemplate.Height = 27
        Me.dgvInventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(288, 135)
        Me.dgvInventario.TabIndex = 22
        '
        'Marcado
        '
        Me.Marcado.Frozen = True
        Me.Marcado.HeaderText = "-"
        Me.Marcado.Name = "Marcado"
        Me.Marcado.Width = 25
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 110
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora2.Location = New System.Drawing.Point(264, 101)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(65, 18)
        Me.lblHora2.TabIndex = 19
        Me.lblHora2.Text = "Label10"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora1.Location = New System.Drawing.Point(264, 72)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(56, 18)
        Me.lblHora1.TabIndex = 18
        Me.lblHora1.Text = "Label9"
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(144, 65)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(217, 17)
        Me.lblNoHayReservas.TabIndex = 17
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'llblMotivoReserva3
        '
        Me.llblMotivoReserva3.AutoSize = True
        Me.llblMotivoReserva3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblMotivoReserva3.Location = New System.Drawing.Point(142, 130)
        Me.llblMotivoReserva3.Name = "llblMotivoReserva3"
        Me.llblMotivoReserva3.Size = New System.Drawing.Size(85, 18)
        Me.llblMotivoReserva3.TabIndex = 16
        Me.llblMotivoReserva3.TabStop = True
        Me.llblMotivoReserva3.Text = "LinkLabel3"
        '
        'llblMotivoReserva2
        '
        Me.llblMotivoReserva2.AutoSize = True
        Me.llblMotivoReserva2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblMotivoReserva2.Location = New System.Drawing.Point(142, 101)
        Me.llblMotivoReserva2.Name = "llblMotivoReserva2"
        Me.llblMotivoReserva2.Size = New System.Drawing.Size(85, 18)
        Me.llblMotivoReserva2.TabIndex = 15
        Me.llblMotivoReserva2.TabStop = True
        Me.llblMotivoReserva2.Text = "LinkLabel2"
        '
        'llblMotivoReserva1
        '
        Me.llblMotivoReserva1.AutoSize = True
        Me.llblMotivoReserva1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblMotivoReserva1.Location = New System.Drawing.Point(142, 72)
        Me.llblMotivoReserva1.Name = "llblMotivoReserva1"
        Me.llblMotivoReserva1.Size = New System.Drawing.Size(85, 18)
        Me.llblMotivoReserva1.TabIndex = 14
        Me.llblMotivoReserva1.TabStop = True
        Me.llblMotivoReserva1.Text = "LinkLabel1"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFecha.Location = New System.Drawing.Point(346, 29)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(53, 22)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "1/1/1"
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(67, 30)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(284, 24)
        Me.lblFiestasReservadasParaEl.TabIndex = 12
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServicio.ForeColor = System.Drawing.Color.Black
        Me.chkServicio.Location = New System.Drawing.Point(758, 658)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkServicio.Size = New System.Drawing.Size(90, 23)
        Me.chkServicio.TabIndex = 10
        Me.chkServicio.Text = "Servicio"
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(715, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad de Personas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(760, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Motivo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(843, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(639, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de Comienzo:"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(977, 680)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(155, 55)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente  >"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(96, 288)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        '
        'pbNotacion
        '
        Me.pbNotacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbNotacion.Location = New System.Drawing.Point(703, 278)
        Me.pbNotacion.Name = "pbNotacion"
        Me.pbNotacion.Size = New System.Drawing.Size(198, 83)
        Me.pbNotacion.TabIndex = 68
        Me.pbNotacion.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(94, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 166)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 807)
        Me.Controls.Add(Me.pnlReserva)
        Me.Controls.Add(Me.pnlCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservar"
        Me.Text = " "
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        CType(Me.pbCedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelefonos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelefono2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModoPago1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReserva.ResumeLayout(False)
        Me.pnlReserva.PerformLayout()
        CType(Me.nudCantidadPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCantidadPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHoraFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHoraComienzo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNotacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblIngresarDatos As System.Windows.Forms.Label
    Friend WithEvents lblFechaParaReservar As System.Windows.Forms.Label
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
    Friend WithEvents cboModoPagoSeña As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEditarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents txtPrecioFiesta As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents nudCantidadPersonas As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMostrarDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents lblDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents chkUtilizarDineroAFavor As System.Windows.Forms.CheckBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAgadu As System.Windows.Forms.Label
    Public WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents pbHoraComienzo As System.Windows.Forms.PictureBox
    Friend WithEvents dtpHoraComienzo As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbCantidadPersonas As System.Windows.Forms.PictureBox
    Friend WithEvents pbMotivo As System.Windows.Forms.PictureBox
    Friend WithEvents pbHoraFinal As System.Windows.Forms.PictureBox
    Friend WithEvents pbNotacion As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlDatosReserva As System.Windows.Forms.Panel
    Friend WithEvents lblIngreseLosDatosDelCliente As System.Windows.Forms.Label
    Friend WithEvents pbCedula As System.Windows.Forms.PictureBox
    Friend WithEvents pbModoPago As System.Windows.Forms.PictureBox
    Friend WithEvents pbNombre As System.Windows.Forms.PictureBox
    Friend WithEvents pbTelefonos1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbTelefono2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDireccion As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeña As System.Windows.Forms.PictureBox
    Friend WithEvents pbModoPago1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCuotas As System.Windows.Forms.PictureBox
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Marcado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
