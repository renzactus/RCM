<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rboCedula = New System.Windows.Forms.RadioButton()
        Me.rboNombre = New System.Windows.Forms.RadioButton()
        Me.rboTelefono = New System.Windows.Forms.RadioButton()
        Me.txtFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.txtFiltrarTelefono = New System.Windows.Forms.TextBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnFiltrarNombre = New System.Windows.Forms.Button()
        Me.btnFiltrarCedula = New System.Windows.Forms.Button()
        Me.btnFiltrarTelefono = New System.Windows.Forms.Button()
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.lblReservasQueRealizo = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblFIltrarClientePor = New System.Windows.Forms.Label()
        Me.txtFiltrarNombre = New System.Windows.Forms.TextBox()
        Me.btnCancelarDinero = New System.Windows.Forms.Button()
        Me.btnEditarDinero = New System.Windows.Forms.Button()
        Me.btnGuardarDinero = New System.Windows.Forms.Button()
        Me.lblMostrarDineroAFavor = New System.Windows.Forms.Label()
        Me.lblDineroAFavor = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.lblEditandoCliente = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarEdicion = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.pbCedula = New System.Windows.Forms.PictureBox()
        Me.pbNombre = New System.Windows.Forms.PictureBox()
        Me.pbTelefonos1 = New System.Windows.Forms.PictureBox()
        Me.pbTelefono2 = New System.Windows.Forms.PictureBox()
        Me.pbDireccion = New System.Windows.Forms.PictureBox()
        Me.txtDineroAFavor = New System.Windows.Forms.TextBox()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dinero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimareserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pbFiltrarNombre = New System.Windows.Forms.PictureBox()
        Me.pbFiltrarCedula = New System.Windows.Forms.PictureBox()
        Me.pbFiltrarTelefono = New System.Windows.Forms.PictureBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelefonos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelefono2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFiltrarNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFiltrarCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFiltrarTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rboCedula
        '
        Me.rboCedula.AutoSize = True
        Me.rboCedula.Enabled = False
        Me.rboCedula.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboCedula.Location = New System.Drawing.Point(263, 525)
        Me.rboCedula.Name = "rboCedula"
        Me.rboCedula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboCedula.Size = New System.Drawing.Size(76, 21)
        Me.rboCedula.TabIndex = 7
        Me.rboCedula.Text = ":Cedula"
        Me.rboCedula.UseVisualStyleBackColor = True
        '
        'rboNombre
        '
        Me.rboNombre.AutoSize = True
        Me.rboNombre.Enabled = False
        Me.rboNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboNombre.Location = New System.Drawing.Point(51, 525)
        Me.rboNombre.Name = "rboNombre"
        Me.rboNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboNombre.Size = New System.Drawing.Size(82, 21)
        Me.rboNombre.TabIndex = 6
        Me.rboNombre.Text = ":Nombre"
        Me.rboNombre.UseVisualStyleBackColor = True
        '
        'rboTelefono
        '
        Me.rboTelefono.AutoSize = True
        Me.rboTelefono.Enabled = False
        Me.rboTelefono.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboTelefono.Location = New System.Drawing.Point(450, 525)
        Me.rboTelefono.Name = "rboTelefono"
        Me.rboTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboTelefono.Size = New System.Drawing.Size(84, 21)
        Me.rboTelefono.TabIndex = 8
        Me.rboTelefono.Text = ":Telefono"
        Me.rboTelefono.UseVisualStyleBackColor = True
        '
        'txtFiltrarCedula
        '
        Me.txtFiltrarCedula.Enabled = False
        Me.txtFiltrarCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltrarCedula.Location = New System.Drawing.Point(250, 558)
        Me.txtFiltrarCedula.Name = "txtFiltrarCedula"
        Me.txtFiltrarCedula.Size = New System.Drawing.Size(114, 26)
        Me.txtFiltrarCedula.TabIndex = 11
        '
        'txtFiltrarTelefono
        '
        Me.txtFiltrarTelefono.Enabled = False
        Me.txtFiltrarTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltrarTelefono.Location = New System.Drawing.Point(450, 558)
        Me.txtFiltrarTelefono.Name = "txtFiltrarTelefono"
        Me.txtFiltrarTelefono.Size = New System.Drawing.Size(114, 26)
        Me.txtFiltrarTelefono.TabIndex = 15
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvClientes.ColumnHeadersHeight = 30
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.Cantidad, Me.Telefonos, Me.Direccion, Me.Dinero, Me.ultimareserva})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.Location = New System.Drawing.Point(22, 124)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowTemplate.Height = 27
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(682, 233)
        Me.dgvClientes.TabIndex = 24
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'btnFiltrarNombre
        '
        Me.btnFiltrarNombre.Enabled = False
        Me.btnFiltrarNombre.FlatAppearance.BorderSize = 0
        Me.btnFiltrarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrarNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarNombre.Location = New System.Drawing.Point(57, 590)
        Me.btnFiltrarNombre.Name = "btnFiltrarNombre"
        Me.btnFiltrarNombre.Size = New System.Drawing.Size(75, 24)
        Me.btnFiltrarNombre.TabIndex = 64
        Me.btnFiltrarNombre.Text = "Filtrar"
        Me.btnFiltrarNombre.UseVisualStyleBackColor = True
        '
        'btnFiltrarCedula
        '
        Me.btnFiltrarCedula.Enabled = False
        Me.btnFiltrarCedula.FlatAppearance.BorderSize = 0
        Me.btnFiltrarCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrarCedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarCedula.Location = New System.Drawing.Point(268, 590)
        Me.btnFiltrarCedula.Name = "btnFiltrarCedula"
        Me.btnFiltrarCedula.Size = New System.Drawing.Size(75, 24)
        Me.btnFiltrarCedula.TabIndex = 65
        Me.btnFiltrarCedula.Text = "Filtrar"
        Me.btnFiltrarCedula.UseVisualStyleBackColor = True
        '
        'btnFiltrarTelefono
        '
        Me.btnFiltrarTelefono.Enabled = False
        Me.btnFiltrarTelefono.FlatAppearance.BorderSize = 0
        Me.btnFiltrarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrarTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarTelefono.Location = New System.Drawing.Point(469, 590)
        Me.btnFiltrarTelefono.Name = "btnFiltrarTelefono"
        Me.btnFiltrarTelefono.Size = New System.Drawing.Size(75, 24)
        Me.btnFiltrarTelefono.TabIndex = 66
        Me.btnFiltrarTelefono.Text = "Filtrar"
        Me.btnFiltrarTelefono.UseVisualStyleBackColor = True
        '
        'dgvReservas
        '
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.AllowUserToResizeColumns = False
        Me.dgvReservas.AllowUserToResizeRows = False
        Me.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvReservas.ColumnHeadersHeight = 30
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Motivo, Me.Fecha, Me.Personas, Me.Hora, Me.Cancelada})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservas.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvReservas.EnableHeadersVisualStyles = False
        Me.dgvReservas.Location = New System.Drawing.Point(681, 483)
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservas.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.RowTemplate.Height = 27
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.Size = New System.Drawing.Size(484, 131)
        Me.dgvReservas.TabIndex = 67
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(967, 51)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(76, 24)
        Me.lblDatos.TabIndex = 68
        Me.lblDatos.Text = "Datos:"
        '
        'lblReservasQueRealizo
        '
        Me.lblReservasQueRealizo.AutoSize = True
        Me.lblReservasQueRealizo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservasQueRealizo.Location = New System.Drawing.Point(816, 430)
        Me.lblReservasQueRealizo.Name = "lblReservasQueRealizo"
        Me.lblReservasQueRealizo.Size = New System.Drawing.Size(175, 19)
        Me.lblReservasQueRealizo.TabIndex = 69
        Me.lblReservasQueRealizo.Text = "Reservas que realizó:"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(45, 51)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(98, 24)
        Me.lblClientes.TabIndex = 70
        Me.lblClientes.Text = "Clientes:"
        '
        'lblFIltrarClientePor
        '
        Me.lblFIltrarClientePor.AutoSize = True
        Me.lblFIltrarClientePor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFIltrarClientePor.Location = New System.Drawing.Point(53, 430)
        Me.lblFIltrarClientePor.Name = "lblFIltrarClientePor"
        Me.lblFIltrarClientePor.Size = New System.Drawing.Size(143, 19)
        Me.lblFIltrarClientePor.TabIndex = 71
        Me.lblFIltrarClientePor.Text = "Filtrar cliente por:"
        '
        'txtFiltrarNombre
        '
        Me.txtFiltrarNombre.Enabled = False
        Me.txtFiltrarNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltrarNombre.Location = New System.Drawing.Point(40, 556)
        Me.txtFiltrarNombre.Name = "txtFiltrarNombre"
        Me.txtFiltrarNombre.Size = New System.Drawing.Size(114, 26)
        Me.txtFiltrarNombre.TabIndex = 72
        '
        'btnCancelarDinero
        '
        Me.btnCancelarDinero.Enabled = False
        Me.btnCancelarDinero.FlatAppearance.BorderSize = 0
        Me.btnCancelarDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarDinero.Location = New System.Drawing.Point(1040, 349)
        Me.btnCancelarDinero.Name = "btnCancelarDinero"
        Me.btnCancelarDinero.Size = New System.Drawing.Size(59, 23)
        Me.btnCancelarDinero.TabIndex = 75
        Me.btnCancelarDinero.Text = "Cancelar"
        Me.btnCancelarDinero.UseVisualStyleBackColor = True
        '
        'btnEditarDinero
        '
        Me.btnEditarDinero.Enabled = False
        Me.btnEditarDinero.FlatAppearance.BorderSize = 0
        Me.btnEditarDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarDinero.Location = New System.Drawing.Point(1040, 349)
        Me.btnEditarDinero.Name = "btnEditarDinero"
        Me.btnEditarDinero.Size = New System.Drawing.Size(59, 23)
        Me.btnEditarDinero.TabIndex = 73
        Me.btnEditarDinero.Text = "Editar"
        Me.btnEditarDinero.UseVisualStyleBackColor = True
        '
        'btnGuardarDinero
        '
        Me.btnGuardarDinero.Enabled = False
        Me.btnGuardarDinero.FlatAppearance.BorderSize = 0
        Me.btnGuardarDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarDinero.Location = New System.Drawing.Point(1093, 349)
        Me.btnGuardarDinero.Name = "btnGuardarDinero"
        Me.btnGuardarDinero.Size = New System.Drawing.Size(54, 23)
        Me.btnGuardarDinero.TabIndex = 74
        Me.btnGuardarDinero.Text = "Guardar"
        Me.btnGuardarDinero.UseVisualStyleBackColor = True
        Me.btnGuardarDinero.Visible = False
        '
        'lblMostrarDineroAFavor
        '
        Me.lblMostrarDineroAFavor.AutoSize = True
        Me.lblMostrarDineroAFavor.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarDineroAFavor.Location = New System.Drawing.Point(943, 344)
        Me.lblMostrarDineroAFavor.Name = "lblMostrarDineroAFavor"
        Me.lblMostrarDineroAFavor.Size = New System.Drawing.Size(69, 30)
        Me.lblMostrarDineroAFavor.TabIndex = 91
        Me.lblMostrarDineroAFavor.Text = "$$$$"
        '
        'lblDineroAFavor
        '
        Me.lblDineroAFavor.AutoSize = True
        Me.lblDineroAFavor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroAFavor.Location = New System.Drawing.Point(800, 349)
        Me.lblDineroAFavor.Name = "lblDineroAFavor"
        Me.lblDineroAFavor.Size = New System.Drawing.Size(150, 24)
        Me.lblDineroAFavor.TabIndex = 90
        Me.lblDineroAFavor.Text = "Dinero a favor:"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardarCliente.FlatAppearance.BorderSize = 0
        Me.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCliente.Location = New System.Drawing.Point(1128, 87)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(62, 27)
        Me.btnGuardarCliente.TabIndex = 88
        Me.btnGuardarCliente.Text = "Guardar"
        Me.btnGuardarCliente.UseVisualStyleBackColor = True
        Me.btnGuardarCliente.Visible = False
        '
        'lblEditandoCliente
        '
        Me.lblEditandoCliente.AutoSize = True
        Me.lblEditandoCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditandoCliente.Location = New System.Drawing.Point(924, 90)
        Me.lblEditandoCliente.Name = "lblEditandoCliente"
        Me.lblEditandoCliente.Size = New System.Drawing.Size(135, 19)
        Me.lblEditandoCliente.TabIndex = 87
        Me.lblEditandoCliente.Text = "Editando Cliente"
        Me.lblEditandoCliente.Visible = False
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtTelefono2.Location = New System.Drawing.Point(913, 279)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(203, 29)
        Me.txtTelefono2.TabIndex = 85
        Me.txtTelefono2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(800, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Cedula:"
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregarTelefonos.Enabled = False
        Me.btnAgregarTelefonos.FlatAppearance.BorderSize = 0
        Me.btnAgregarTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefonos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(1119, 240)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(31, 29)
        Me.btnAgregarTelefonos.TabIndex = 84
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtNombre.Location = New System.Drawing.Point(913, 182)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 29)
        Me.txtNombre.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(800, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(800, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Telefonos:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(913, 297)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(203, 29)
        Me.txtDireccion.TabIndex = 80
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Enabled = False
        Me.txtTelefono1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtTelefono1.Location = New System.Drawing.Point(913, 240)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(203, 29)
        Me.txtTelefono1.TabIndex = 82
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(800, 300)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(105, 24)
        Me.lblDireccion.TabIndex = 81
        Me.lblDireccion.Text = "Direccion:"
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditarCliente.FlatAppearance.BorderSize = 0
        Me.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCliente.Location = New System.Drawing.Point(1070, 87)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(65, 27)
        Me.btnEditarCliente.TabIndex = 86
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        Me.btnEditarCliente.Visible = False
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelarEdicion.FlatAppearance.BorderSize = 0
        Me.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEdicion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(1070, 87)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(65, 27)
        Me.btnCancelarEdicion.TabIndex = 89
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        Me.btnCancelarEdicion.Visible = False
        '
        'txtCedula
        '
        Me.txtCedula.Enabled = False
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(913, 124)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(203, 29)
        Me.txtCedula.TabIndex = 76
        '
        'pbCedula
        '
        Me.pbCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCedula.Location = New System.Drawing.Point(911, 122)
        Me.pbCedula.Name = "pbCedula"
        Me.pbCedula.Size = New System.Drawing.Size(207, 33)
        Me.pbCedula.TabIndex = 92
        Me.pbCedula.TabStop = False
        '
        'pbNombre
        '
        Me.pbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbNombre.Location = New System.Drawing.Point(911, 180)
        Me.pbNombre.Name = "pbNombre"
        Me.pbNombre.Size = New System.Drawing.Size(207, 33)
        Me.pbNombre.TabIndex = 93
        Me.pbNombre.TabStop = False
        '
        'pbTelefonos1
        '
        Me.pbTelefonos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbTelefonos1.Location = New System.Drawing.Point(911, 238)
        Me.pbTelefonos1.Name = "pbTelefonos1"
        Me.pbTelefonos1.Size = New System.Drawing.Size(207, 33)
        Me.pbTelefonos1.TabIndex = 94
        Me.pbTelefonos1.TabStop = False
        '
        'pbTelefono2
        '
        Me.pbTelefono2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbTelefono2.Location = New System.Drawing.Point(911, 277)
        Me.pbTelefono2.Name = "pbTelefono2"
        Me.pbTelefono2.Size = New System.Drawing.Size(207, 33)
        Me.pbTelefono2.TabIndex = 95
        Me.pbTelefono2.TabStop = False
        Me.pbTelefono2.Visible = False
        '
        'pbDireccion
        '
        Me.pbDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbDireccion.Location = New System.Drawing.Point(911, 295)
        Me.pbDireccion.Name = "pbDireccion"
        Me.pbDireccion.Size = New System.Drawing.Size(207, 33)
        Me.pbDireccion.TabIndex = 96
        Me.pbDireccion.TabStop = False
        '
        'txtDineroAFavor
        '
        Me.txtDineroAFavor.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtDineroAFavor.Location = New System.Drawing.Point(948, 346)
        Me.txtDineroAFavor.Name = "txtDineroAFavor"
        Me.txtDineroAFavor.Size = New System.Drawing.Size(88, 29)
        Me.txtDineroAFavor.TabIndex = 97
        Me.txtDineroAFavor.Visible = False
        '
        'cedula
        '
        Me.cedula.Frozen = True
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Width = 70
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Nombre"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 160
        '
        'Telefonos
        '
        Me.Telefonos.Frozen = True
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.Name = "Telefonos"
        Me.Telefonos.ReadOnly = True
        Me.Telefonos.Width = 140
        '
        'Direccion
        '
        Me.Direccion.Frozen = True
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Dinero
        '
        Me.Dinero.Frozen = True
        Me.Dinero.HeaderText = "Credito"
        Me.Dinero.Name = "Dinero"
        Me.Dinero.ReadOnly = True
        Me.Dinero.Width = 60
        '
        'ultimareserva
        '
        Me.ultimareserva.Frozen = True
        Me.ultimareserva.HeaderText = "Ultima Reserva"
        Me.ultimareserva.Name = "ultimareserva"
        Me.ultimareserva.ReadOnly = True
        Me.ultimareserva.Width = 150
        '
        'Motivo
        '
        Me.Motivo.Frozen = True
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 70
        '
        'Personas
        '
        Me.Personas.Frozen = True
        Me.Personas.HeaderText = "Personas"
        Me.Personas.Name = "Personas"
        Me.Personas.ReadOnly = True
        Me.Personas.Width = 90
        '
        'Hora
        '
        Me.Hora.Frozen = True
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 95
        '
        'Cancelada
        '
        Me.Cancelada.Frozen = True
        Me.Cancelada.HeaderText = "Cancelada"
        Me.Cancelada.Name = "Cancelada"
        Me.Cancelada.ReadOnly = True
        Me.Cancelada.Width = 125
        '
        'pbFiltrarNombre
        '
        Me.pbFiltrarNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbFiltrarNombre.Location = New System.Drawing.Point(38, 554)
        Me.pbFiltrarNombre.Name = "pbFiltrarNombre"
        Me.pbFiltrarNombre.Size = New System.Drawing.Size(118, 30)
        Me.pbFiltrarNombre.TabIndex = 99
        Me.pbFiltrarNombre.TabStop = False
        '
        'pbFiltrarCedula
        '
        Me.pbFiltrarCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbFiltrarCedula.Location = New System.Drawing.Point(248, 556)
        Me.pbFiltrarCedula.Name = "pbFiltrarCedula"
        Me.pbFiltrarCedula.Size = New System.Drawing.Size(118, 30)
        Me.pbFiltrarCedula.TabIndex = 100
        Me.pbFiltrarCedula.TabStop = False
        '
        'pbFiltrarTelefono
        '
        Me.pbFiltrarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbFiltrarTelefono.Location = New System.Drawing.Point(448, 556)
        Me.pbFiltrarTelefono.Name = "pbFiltrarTelefono"
        Me.pbFiltrarTelefono.Size = New System.Drawing.Size(118, 30)
        Me.pbFiltrarTelefono.TabIndex = 101
        Me.pbFiltrarTelefono.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 768)
        Me.Controls.Add(Me.txtDineroAFavor)
        Me.Controls.Add(Me.lblMostrarDineroAFavor)
        Me.Controls.Add(Me.lblDineroAFavor)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.lblEditandoCliente)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarTelefonos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.btnCancelarEdicion)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.pbCedula)
        Me.Controls.Add(Me.pbNombre)
        Me.Controls.Add(Me.pbTelefonos1)
        Me.Controls.Add(Me.pbTelefono2)
        Me.Controls.Add(Me.pbDireccion)
        Me.Controls.Add(Me.btnGuardarDinero)
        Me.Controls.Add(Me.txtFiltrarNombre)
        Me.Controls.Add(Me.lblFIltrarClientePor)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.lblReservasQueRealizo)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.dgvReservas)
        Me.Controls.Add(Me.btnFiltrarTelefono)
        Me.Controls.Add(Me.btnFiltrarCedula)
        Me.Controls.Add(Me.btnFiltrarNombre)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtFiltrarCedula)
        Me.Controls.Add(Me.txtFiltrarTelefono)
        Me.Controls.Add(Me.rboTelefono)
        Me.Controls.Add(Me.rboNombre)
        Me.Controls.Add(Me.rboCedula)
        Me.Controls.Add(Me.btnEditarDinero)
        Me.Controls.Add(Me.btnCancelarDinero)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Controls.Add(Me.pbFiltrarNombre)
        Me.Controls.Add(Me.pbFiltrarCedula)
        Me.Controls.Add(Me.pbFiltrarTelefono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelefonos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelefono2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFiltrarNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFiltrarCedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFiltrarTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rboCedula As System.Windows.Forms.RadioButton
    Friend WithEvents rboNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rboTelefono As System.Windows.Forms.RadioButton
    Friend WithEvents txtFiltrarCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltrarTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnFiltrarNombre As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarTelefono As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarCedula As System.Windows.Forms.Button
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
    Friend WithEvents lblReservasQueRealizo As System.Windows.Forms.Label
    Friend WithEvents lblFIltrarClientePor As System.Windows.Forms.Label
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents txtFiltrarNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblMostrarDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents lblDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents btnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents lblEditandoCliente As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelarEdicion As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents pbCedula As System.Windows.Forms.PictureBox
    Friend WithEvents pbNombre As System.Windows.Forms.PictureBox
    Friend WithEvents pbTelefonos1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbTelefono2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDireccion As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardarDinero As System.Windows.Forms.Button
    Friend WithEvents btnEditarDinero As System.Windows.Forms.Button
    Friend WithEvents btnCancelarDinero As System.Windows.Forms.Button
    Friend WithEvents txtDineroAFavor As System.Windows.Forms.TextBox
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dinero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultimareserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancelada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pbFiltrarNombre As System.Windows.Forms.PictureBox
    Friend WithEvents pbFiltrarCedula As System.Windows.Forms.PictureBox
    Friend WithEvents pbFiltrarTelefono As System.Windows.Forms.PictureBox
End Class
