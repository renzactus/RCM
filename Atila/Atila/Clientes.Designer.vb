﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.rboCedula = New System.Windows.Forms.RadioButton()
        Me.rboNombre = New System.Windows.Forms.RadioButton()
        Me.rboTelefono = New System.Windows.Forms.RadioButton()
        Me.rboReserva = New System.Windows.Forms.RadioButton()
        Me.txtFiltrarCedula = New System.Windows.Forms.TextBox()
        Me.txtFiltarNombre = New System.Windows.Forms.TextBox()
        Me.txtFiltrarTelefono = New System.Windows.Forms.TextBox()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dinero_a_favor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMostrarDineroAFavor = New System.Windows.Forms.Label()
        Me.lblDineroAFavor = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.lblEditandoCliente = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarEdicion = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'cboFiltrarPor
        '
        Me.cboFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltrarPor.FormattingEnabled = True
        Me.cboFiltrarPor.Items.AddRange(New Object() {"Nombre", "Cedula", "Telefono", "Reserva"})
        Me.cboFiltrarPor.Location = New System.Drawing.Point(76, 25)
        Me.cboFiltrarPor.Name = "cboFiltrarPor"
        Me.cboFiltrarPor.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltrarPor.TabIndex = 1
        '
        'rboCedula
        '
        Me.rboCedula.AutoSize = True
        Me.rboCedula.Location = New System.Drawing.Point(179, 354)
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
        Me.rboTelefono.Location = New System.Drawing.Point(305, 354)
        Me.rboTelefono.Name = "rboTelefono"
        Me.rboTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboTelefono.Size = New System.Drawing.Size(67, 17)
        Me.rboTelefono.TabIndex = 8
        Me.rboTelefono.TabStop = True
        Me.rboTelefono.Text = "Telefono"
        Me.rboTelefono.UseVisualStyleBackColor = True
        '
        'rboReserva
        '
        Me.rboReserva.AutoSize = True
        Me.rboReserva.Location = New System.Drawing.Point(511, 354)
        Me.rboReserva.Name = "rboReserva"
        Me.rboReserva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rboReserva.Size = New System.Drawing.Size(65, 17)
        Me.rboReserva.TabIndex = 9
        Me.rboReserva.TabStop = True
        Me.rboReserva.Text = "Reserva"
        Me.rboReserva.UseVisualStyleBackColor = True
        '
        'txtFiltrarCedula
        '
        Me.txtFiltrarCedula.Location = New System.Drawing.Point(166, 387)
        Me.txtFiltrarCedula.Name = "txtFiltrarCedula"
        Me.txtFiltrarCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarCedula.TabIndex = 11
        '
        'txtFiltarNombre
        '
        Me.txtFiltarNombre.Location = New System.Drawing.Point(23, 385)
        Me.txtFiltarNombre.Name = "txtFiltarNombre"
        Me.txtFiltarNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltarNombre.TabIndex = 13
        '
        'txtFiltrarTelefono
        '
        Me.txtFiltrarTelefono.Location = New System.Drawing.Point(305, 387)
        Me.txtFiltrarTelefono.Name = "txtFiltrarTelefono"
        Me.txtFiltrarTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarTelefono.TabIndex = 15
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(433, 383)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 17
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AllowUserToResizeColumns = False
        Me.dgvInventario.AllowUserToResizeRows = False
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.Cantidad, Me.Telefonos, Me.Direccion, Me.Dinero_a_favor})
        Me.dgvInventario.Location = New System.Drawing.Point(12, 72)
        Me.dgvInventario.MultiSelect = False
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(626, 233)
        Me.dgvInventario.TabIndex = 24
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
        Me.Cantidad.Width = 170
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
        Me.Direccion.Width = 130
        '
        'Dinero_a_favor
        '
        Me.Dinero_a_favor.Frozen = True
        Me.Dinero_a_favor.HeaderText = "Dinero a favor"
        Me.Dinero_a_favor.Name = "Dinero_a_favor"
        Me.Dinero_a_favor.ReadOnly = True
        Me.Dinero_a_favor.Width = 82
        '
        'lblMostrarDineroAFavor
        '
        Me.lblMostrarDineroAFavor.AutoSize = True
        Me.lblMostrarDineroAFavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarDineroAFavor.Location = New System.Drawing.Point(784, 223)
        Me.lblMostrarDineroAFavor.Name = "lblMostrarDineroAFavor"
        Me.lblMostrarDineroAFavor.Size = New System.Drawing.Size(44, 18)
        Me.lblMostrarDineroAFavor.TabIndex = 61
        Me.lblMostrarDineroAFavor.Text = "$$$$"
        Me.lblMostrarDineroAFavor.Visible = False
        '
        'lblDineroAFavor
        '
        Me.lblDineroAFavor.AutoSize = True
        Me.lblDineroAFavor.Location = New System.Drawing.Point(708, 226)
        Me.lblDineroAFavor.Name = "lblDineroAFavor"
        Me.lblDineroAFavor.Size = New System.Drawing.Size(77, 13)
        Me.lblDineroAFavor.TabIndex = 60
        Me.lblDineroAFavor.Text = "Dinero a favor:"
        Me.lblDineroAFavor.Visible = False
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Location = New System.Drawing.Point(920, 74)
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
        Me.lblEditandoCliente.Location = New System.Drawing.Point(728, 44)
        Me.lblEditandoCliente.Name = "lblEditandoCliente"
        Me.lblEditandoCliente.Size = New System.Drawing.Size(105, 18)
        Me.lblEditandoCliente.TabIndex = 57
        Me.lblEditandoCliente.Text = "Editar Cliente"
        Me.lblEditandoCliente.Visible = False
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(733, 184)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 55
        Me.txtTelefono2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(751, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Cedula"
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(846, 158)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 54
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(733, 117)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(747, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(743, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Telefonos"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(733, 195)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 50
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(733, 158)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 52
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(743, 181)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 51
        Me.lblDireccion.Text = "Direccion"
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(854, 74)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(60, 27)
        Me.btnEditarCliente.TabIndex = 56
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        Me.btnEditarCliente.Visible = False
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(854, 74)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(60, 27)
        Me.btnCancelarEdicion.TabIndex = 59
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        Me.btnCancelarEdicion.Visible = False
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(733, 78)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 62
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 589)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblMostrarDineroAFavor)
        Me.Controls.Add(Me.lblDineroAFavor)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.lblEditandoCliente)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregarTelefonos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.txtFiltrarCedula)
        Me.Controls.Add(Me.txtFiltarNombre)
        Me.Controls.Add(Me.txtFiltrarTelefono)
        Me.Controls.Add(Me.rboReserva)
        Me.Controls.Add(Me.rboTelefono)
        Me.Controls.Add(Me.rboNombre)
        Me.Controls.Add(Me.rboCedula)
        Me.Controls.Add(Me.cboFiltrarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Controls.Add(Me.btnCancelarEdicion)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents rboCedula As System.Windows.Forms.RadioButton
    Friend WithEvents rboNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rboTelefono As System.Windows.Forms.RadioButton
    Friend WithEvents rboReserva As System.Windows.Forms.RadioButton
    Friend WithEvents txtFiltrarCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltarNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltrarTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dinero_a_favor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMostrarDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents lblDineroAFavor As System.Windows.Forms.Label
    Friend WithEvents btnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents lblEditandoCliente As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelarEdicion As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
End Class
