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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.rboCedula = New System.Windows.Forms.RadioButton()
        Me.rboNombre = New System.Windows.Forms.RadioButton()
        Me.rboTelefono = New System.Windows.Forms.RadioButton()
        Me.txtFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.txtFiltrarTelefono = New System.Windows.Forms.TextBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dinero_a_favor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimareserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMostrarDineroAFavor = New System.Windows.Forms.Label()
        Me.lblDineroAFavor = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.lblEditandoCliente = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarEdicion = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnFiltrarNombre = New System.Windows.Forms.Button()
        Me.btnFiltrarCedula = New System.Windows.Forms.Button()
        Me.btnFiltrarTelefono = New System.Windows.Forms.Button()
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFiltrarNombre = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mostrar por"
        '
        'cboFiltrarPor
        '
        Me.cboFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltrarPor.FormattingEnabled = True
        Me.cboFiltrarPor.Items.AddRange(New Object() {"Nombre", "Cedula", "Telefono", "Reserva"})
        Me.cboFiltrarPor.Location = New System.Drawing.Point(525, 11)
        Me.cboFiltrarPor.Name = "cboFiltrarPor"
        Me.cboFiltrarPor.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltrarPor.TabIndex = 1
        '
        'rboCedula
        '
        Me.rboCedula.AutoSize = True
        Me.rboCedula.Location = New System.Drawing.Point(246, 354)
        Me.rboCedula.Name = "rboCedula"
        Me.rboCedula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboCedula.Size = New System.Drawing.Size(58, 17)
        Me.rboCedula.TabIndex = 6
        Me.rboCedula.TabStop = True
        Me.rboCedula.Text = "Cedula"
        Me.rboCedula.UseVisualStyleBackColor = True
        '
        'rboNombre
        '
        Me.rboNombre.AutoSize = True
        Me.rboNombre.Location = New System.Drawing.Point(34, 354)
        Me.rboNombre.Name = "rboNombre"
        Me.rboNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboNombre.Size = New System.Drawing.Size(62, 17)
        Me.rboNombre.TabIndex = 7
        Me.rboNombre.TabStop = True
        Me.rboNombre.Text = "Nombre"
        Me.rboNombre.UseVisualStyleBackColor = True
        '
        'rboTelefono
        '
        Me.rboTelefono.AutoSize = True
        Me.rboTelefono.Location = New System.Drawing.Point(433, 354)
        Me.rboTelefono.Name = "rboTelefono"
        Me.rboTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboTelefono.Size = New System.Drawing.Size(67, 17)
        Me.rboTelefono.TabIndex = 8
        Me.rboTelefono.TabStop = True
        Me.rboTelefono.Text = "Telefono"
        Me.rboTelefono.UseVisualStyleBackColor = True
        '
        'txtFiltrarCedula
        '
        Me.txtFiltrarCedula.Enabled = False
        Me.txtFiltrarCedula.Location = New System.Drawing.Point(233, 387)
        Me.txtFiltrarCedula.Name = "txtFiltrarCedula"
        Me.txtFiltrarCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarCedula.TabIndex = 11
        '
        'txtFiltrarTelefono
        '
        Me.txtFiltrarTelefono.Enabled = False
        Me.txtFiltrarTelefono.Location = New System.Drawing.Point(433, 387)
        Me.txtFiltrarTelefono.Name = "txtFiltrarTelefono"
        Me.txtFiltrarTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarTelefono.TabIndex = 15
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.Cantidad, Me.Telefonos, Me.Direccion, Me.Dinero_a_favor, Me.ultimareserva})
        Me.dgvClientes.Location = New System.Drawing.Point(1, 74)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(652, 233)
        Me.dgvClientes.TabIndex = 24
        '
        'cedula
        '
        Me.cedula.Frozen = True
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Nombre"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 140
        '
        'Telefonos
        '
        Me.Telefonos.Frozen = True
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.Name = "Telefonos"
        Me.Telefonos.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.Frozen = True
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Dinero_a_favor
        '
        Me.Dinero_a_favor.Frozen = True
        Me.Dinero_a_favor.HeaderText = "Dinero a favor"
        Me.Dinero_a_favor.Name = "Dinero_a_favor"
        Me.Dinero_a_favor.ReadOnly = True
        Me.Dinero_a_favor.Width = 82
        '
        'ultimareserva
        '
        Me.ultimareserva.Frozen = True
        Me.ultimareserva.HeaderText = "Ultima Reserva"
        Me.ultimareserva.Name = "ultimareserva"
        Me.ultimareserva.ReadOnly = True
        Me.ultimareserva.Width = 85
        '
        'lblMostrarDineroAFavor
        '
        Me.lblMostrarDineroAFavor.AutoSize = True
        Me.lblMostrarDineroAFavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarDineroAFavor.Location = New System.Drawing.Point(805, 228)
        Me.lblMostrarDineroAFavor.Name = "lblMostrarDineroAFavor"
        Me.lblMostrarDineroAFavor.Size = New System.Drawing.Size(44, 18)
        Me.lblMostrarDineroAFavor.TabIndex = 61
        Me.lblMostrarDineroAFavor.Text = "$$$$"
        Me.lblMostrarDineroAFavor.Visible = False
        '
        'lblDineroAFavor
        '
        Me.lblDineroAFavor.AutoSize = True
        Me.lblDineroAFavor.Location = New System.Drawing.Point(729, 231)
        Me.lblDineroAFavor.Name = "lblDineroAFavor"
        Me.lblDineroAFavor.Size = New System.Drawing.Size(77, 13)
        Me.lblDineroAFavor.TabIndex = 60
        Me.lblDineroAFavor.Text = "Dinero a favor:"
        Me.lblDineroAFavor.Visible = False
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Location = New System.Drawing.Point(941, 79)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(55, 27)
        Me.btnGuardarCliente.TabIndex = 58
        Me.btnGuardarCliente.Text = "Guardar"
        Me.btnGuardarCliente.UseVisualStyleBackColor = True
        Me.btnGuardarCliente.Visible = False
        '
        'lblEditandoCliente
        '
        Me.lblEditandoCliente.AutoSize = True
        Me.lblEditandoCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditandoCliente.Location = New System.Drawing.Point(749, 49)
        Me.lblEditandoCliente.Name = "lblEditandoCliente"
        Me.lblEditandoCliente.Size = New System.Drawing.Size(105, 18)
        Me.lblEditandoCliente.TabIndex = 57
        Me.lblEditandoCliente.Text = "Editar Cliente"
        Me.lblEditandoCliente.Visible = False
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Enabled = False
        Me.txtTelefono2.Location = New System.Drawing.Point(754, 189)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 55
        Me.txtTelefono2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(772, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Cedula"
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(867, 163)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 54
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(768, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(764, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Telefonos"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(754, 200)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 50
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Enabled = False
        Me.txtTelefono1.Location = New System.Drawing.Point(754, 163)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 52
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(764, 186)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 51
        Me.lblDireccion.Text = "Direccion"
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(875, 79)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(60, 27)
        Me.btnEditarCliente.TabIndex = 56
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        Me.btnEditarCliente.Visible = False
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(875, 79)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(60, 27)
        Me.btnCancelarEdicion.TabIndex = 59
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        Me.btnCancelarEdicion.Visible = False
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(754, 83)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 62
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(754, 122)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 63
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'btnFiltrarNombre
        '
        Me.btnFiltrarNombre.Enabled = False
        Me.btnFiltrarNombre.Location = New System.Drawing.Point(34, 411)
        Me.btnFiltrarNombre.Name = "btnFiltrarNombre"
        Me.btnFiltrarNombre.Size = New System.Drawing.Size(75, 19)
        Me.btnFiltrarNombre.TabIndex = 64
        Me.btnFiltrarNombre.Text = "Filtrar"
        Me.btnFiltrarNombre.UseVisualStyleBackColor = True
        '
        'btnFiltrarCedula
        '
        Me.btnFiltrarCedula.Enabled = False
        Me.btnFiltrarCedula.Location = New System.Drawing.Point(246, 413)
        Me.btnFiltrarCedula.Name = "btnFiltrarCedula"
        Me.btnFiltrarCedula.Size = New System.Drawing.Size(75, 19)
        Me.btnFiltrarCedula.TabIndex = 65
        Me.btnFiltrarCedula.Text = "Filtrar"
        Me.btnFiltrarCedula.UseVisualStyleBackColor = True
        '
        'btnFiltrarTelefono
        '
        Me.btnFiltrarTelefono.Enabled = False
        Me.btnFiltrarTelefono.Location = New System.Drawing.Point(442, 413)
        Me.btnFiltrarTelefono.Name = "btnFiltrarTelefono"
        Me.btnFiltrarTelefono.Size = New System.Drawing.Size(75, 19)
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
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Motivo, Me.Fecha, Me.Personas, Me.Hora, Me.Cancelada})
        Me.dgvReservas.Location = New System.Drawing.Point(671, 349)
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.Size = New System.Drawing.Size(378, 98)
        Me.dgvReservas.TabIndex = 67
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
        Me.Personas.Width = 60
        '
        'Hora
        '
        Me.Hora.Frozen = True
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 75
        '
        'Cancelada
        '
        Me.Cancelada.Frozen = True
        Me.Cancelada.HeaderText = "Cancelada"
        Me.Cancelada.Name = "Cancelada"
        Me.Cancelada.ReadOnly = True
        Me.Cancelada.Width = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(729, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(713, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 18)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Reservas que realizó:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 18)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Clientes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 18)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Filtrar cliente por:"
        '
        'txtFiltrarNombre
        '
        Me.txtFiltrarNombre.Enabled = False
        Me.txtFiltrarNombre.Location = New System.Drawing.Point(23, 385)
        Me.txtFiltrarNombre.Name = "txtFiltrarNombre"
        Me.txtFiltrarNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarNombre.TabIndex = 72
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 589)
        Me.Controls.Add(Me.txtFiltrarNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvReservas)
        Me.Controls.Add(Me.btnFiltrarTelefono)
        Me.Controls.Add(Me.btnFiltrarCedula)
        Me.Controls.Add(Me.btnFiltrarNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblMostrarDineroAFavor)
        Me.Controls.Add(Me.lblDineroAFavor)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.lblEditandoCliente)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregarTelefonos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtFiltrarCedula)
        Me.Controls.Add(Me.txtFiltrarTelefono)
        Me.Controls.Add(Me.rboTelefono)
        Me.Controls.Add(Me.rboNombre)
        Me.Controls.Add(Me.rboCedula)
        Me.Controls.Add(Me.cboFiltrarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarEdicion)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents rboCedula As System.Windows.Forms.RadioButton
    Friend WithEvents rboNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rboTelefono As System.Windows.Forms.RadioButton
    Friend WithEvents txtFiltrarCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltrarTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents lblMostrarDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents lblDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents btnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents lblEditandoCliente As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelarEdicion As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnFiltrarNombre As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarTelefono As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarCedula As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dinero_a_favor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultimareserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancelada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrarNombre As System.Windows.Forms.TextBox
End Class
