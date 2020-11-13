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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.lblMostrarMotivo = New System.Windows.Forms.Label()
        Me.lblMostrarFecha = New System.Windows.Forms.Label()
        Me.lblMostrarHora = New System.Windows.Forms.Label()
        Me.lblMostrarPersonas = New System.Windows.Forms.Label()
        Me.lblMostrarCliente = New System.Windows.Forms.Label()
        Me.lblMostrarSeña = New System.Windows.Forms.Label()
        Me.cboReservasEnElDia = New System.Windows.Forms.ComboBox()
        Me.chkMostrarServicio = New System.Windows.Forms.CheckBox()
        Me.pnlDatosReservas = New System.Windows.Forms.Panel()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblMostrarNota = New System.Windows.Forms.Label()
        Me.lblMostrarImprevisto = New System.Windows.Forms.Label()
        Me.lblImprevisto = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblMostrarPagado = New System.Windows.Forms.Label()
        Me.lblPagado = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblPersonas = New System.Windows.Forms.Label()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPrecioFiesta = New System.Windows.Forms.TextBox()
        Me.lblPrecioFiesta = New System.Windows.Forms.Label()
        Me.lblPrecioF = New System.Windows.Forms.Label()
        Me.btnGuardarPrecioFiesta = New System.Windows.Forms.Button()
        Me.btnEditarPrecioFiesta = New System.Windows.Forms.Button()
        Me.pnlSiNoSePago = New System.Windows.Forms.Panel()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnCancelarReserva = New System.Windows.Forms.Button()
        Me.btnSurgioImprevisto = New System.Windows.Forms.Button()
        Me.btnGuardarFecha = New System.Windows.Forms.Button()
        Me.btnEditarFecha = New System.Windows.Forms.Button()
        Me.lblEditandoReservas = New System.Windows.Forms.Label()
        Me.btnCancelarFecha = New System.Windows.Forms.Button()
        Me.dgvUtiliza = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.pbReservasEnELDIa = New System.Windows.Forms.PictureBox()
        Me.pbCalendario = New System.Windows.Forms.PictureBox()
        Me.lblSeleccioneUnaFecha = New System.Windows.Forms.Label()
        Me.lblCosasUtilizar = New System.Windows.Forms.Label()
        Me.btnExpandirImprevisto = New System.Windows.Forms.Button()
        Me.pnlDatosReservas.SuspendLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSiNoSePago.SuspendLayout()
        CType(Me.dgvUtiliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReservasEnELDIa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(67, 30)
        Me.lblFiestasReservadasParaEl.Name = "lblFiestasReservadasParaEl"
        Me.lblFiestasReservadasParaEl.Size = New System.Drawing.Size(284, 24)
        Me.lblFiestasReservadasParaEl.TabIndex = 21
        Me.lblFiestasReservadasParaEl.Text = "Fiestas reservadas para el:"
        '
        'Calendario
        '
        Me.Calendario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Calendario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calendario.Location = New System.Drawing.Point(827, 208)
        Me.Calendario.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 30
        '
        'lblMostrarMotivo
        '
        Me.lblMostrarMotivo.AutoSize = True
        Me.lblMostrarMotivo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarMotivo.Location = New System.Drawing.Point(91, 38)
        Me.lblMostrarMotivo.Name = "lblMostrarMotivo"
        Me.lblMostrarMotivo.Size = New System.Drawing.Size(73, 24)
        Me.lblMostrarMotivo.TabIndex = 42
        Me.lblMostrarMotivo.Text = "Motivo"
        '
        'lblMostrarFecha
        '
        Me.lblMostrarFecha.AutoSize = True
        Me.lblMostrarFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarFecha.Location = New System.Drawing.Point(91, 187)
        Me.lblMostrarFecha.Name = "lblMostrarFecha"
        Me.lblMostrarFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblMostrarFecha.TabIndex = 43
        Me.lblMostrarFecha.Text = "Fecha"
        '
        'lblMostrarHora
        '
        Me.lblMostrarHora.AutoSize = True
        Me.lblMostrarHora.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarHora.Location = New System.Drawing.Point(91, 267)
        Me.lblMostrarHora.Name = "lblMostrarHora"
        Me.lblMostrarHora.Size = New System.Drawing.Size(55, 24)
        Me.lblMostrarHora.TabIndex = 44
        Me.lblMostrarHora.Text = "Hora"
        '
        'lblMostrarPersonas
        '
        Me.lblMostrarPersonas.AutoSize = True
        Me.lblMostrarPersonas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarPersonas.Location = New System.Drawing.Point(91, 347)
        Me.lblMostrarPersonas.Name = "lblMostrarPersonas"
        Me.lblMostrarPersonas.Size = New System.Drawing.Size(100, 24)
        Me.lblMostrarPersonas.TabIndex = 45
        Me.lblMostrarPersonas.Text = "Personas"
        '
        'lblMostrarCliente
        '
        Me.lblMostrarCliente.AutoSize = True
        Me.lblMostrarCliente.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarCliente.Location = New System.Drawing.Point(91, 508)
        Me.lblMostrarCliente.Name = "lblMostrarCliente"
        Me.lblMostrarCliente.Size = New System.Drawing.Size(75, 24)
        Me.lblMostrarCliente.TabIndex = 48
        Me.lblMostrarCliente.Text = "Cliente"
        '
        'lblMostrarSeña
        '
        Me.lblMostrarSeña.AutoSize = True
        Me.lblMostrarSeña.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarSeña.Location = New System.Drawing.Point(91, 584)
        Me.lblMostrarSeña.Name = "lblMostrarSeña"
        Me.lblMostrarSeña.Size = New System.Drawing.Size(59, 24)
        Me.lblMostrarSeña.TabIndex = 49
        Me.lblMostrarSeña.Text = "Seña"
        '
        'cboReservasEnElDia
        '
        Me.cboReservasEnElDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReservasEnElDia.Enabled = False
        Me.cboReservasEnElDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReservasEnElDia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReservasEnElDia.FormattingEnabled = True
        Me.cboReservasEnElDia.Location = New System.Drawing.Point(346, 79)
        Me.cboReservasEnElDia.Name = "cboReservasEnElDia"
        Me.cboReservasEnElDia.Size = New System.Drawing.Size(158, 30)
        Me.cboReservasEnElDia.TabIndex = 50
        '
        'chkMostrarServicio
        '
        Me.chkMostrarServicio.Enabled = False
        Me.chkMostrarServicio.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarServicio.Location = New System.Drawing.Point(104, 438)
        Me.chkMostrarServicio.Name = "chkMostrarServicio"
        Me.chkMostrarServicio.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarServicio.TabIndex = 51
        Me.chkMostrarServicio.UseVisualStyleBackColor = True
        Me.chkMostrarServicio.Visible = False
        '
        'pnlDatosReservas
        '
        Me.pnlDatosReservas.Controls.Add(Me.btnExpandirImprevisto)
        Me.pnlDatosReservas.Controls.Add(Me.btnExpandir)
        Me.pnlDatosReservas.Controls.Add(Me.lblNota)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarNota)
        Me.pnlDatosReservas.Controls.Add(Me.lblMostrarImprevisto)
        Me.pnlDatosReservas.Controls.Add(Me.lblImprevisto)
        Me.pnlDatosReservas.Controls.Add(Me.dtpFecha)
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
        Me.pnlDatosReservas.Location = New System.Drawing.Point(71, 122)
        Me.pnlDatosReservas.Name = "pnlDatosReservas"
        Me.pnlDatosReservas.Size = New System.Drawing.Size(289, 678)
        Me.pnlDatosReservas.TabIndex = 52
        '
        'btnExpandir
        '
        Me.btnExpandir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandir.Location = New System.Drawing.Point(254, 105)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(26, 23)
        Me.btnExpandir.TabIndex = 70
        Me.btnExpandir.Text = "..."
        Me.btnExpandir.UseVisualStyleBackColor = True
        Me.btnExpandir.Visible = False
        '
        'lblNota
        '
        Me.lblNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.Image = Global.Atila.My.Resources.Resources.icono_nota
        Me.lblNota.Location = New System.Drawing.Point(20, 92)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(50, 50)
        Me.lblNota.TabIndex = 57
        '
        'lblMostrarNota
        '
        Me.lblMostrarNota.AutoSize = True
        Me.lblMostrarNota.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarNota.Location = New System.Drawing.Point(91, 106)
        Me.lblMostrarNota.Name = "lblMostrarNota"
        Me.lblMostrarNota.Size = New System.Drawing.Size(54, 24)
        Me.lblMostrarNota.TabIndex = 58
        Me.lblMostrarNota.Text = "Nota"
        '
        'lblMostrarImprevisto
        '
        Me.lblMostrarImprevisto.AutoSize = True
        Me.lblMostrarImprevisto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarImprevisto.Location = New System.Drawing.Point(91, 636)
        Me.lblMostrarImprevisto.Name = "lblMostrarImprevisto"
        Me.lblMostrarImprevisto.Size = New System.Drawing.Size(107, 24)
        Me.lblMostrarImprevisto.TabIndex = 56
        Me.lblMostrarImprevisto.Text = "Imprevisto"
        '
        'lblImprevisto
        '
        Me.lblImprevisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprevisto.Image = Global.Atila.My.Resources.Resources.icono_Imprevisto
        Me.lblImprevisto.Location = New System.Drawing.Point(23, 632)
        Me.lblImprevisto.Name = "lblImprevisto"
        Me.lblImprevisto.Size = New System.Drawing.Size(48, 39)
        Me.lblImprevisto.TabIndex = 55
        Me.lblImprevisto.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(91, 187)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(131, 32)
        Me.dtpFecha.TabIndex = 54
        Me.dtpFecha.Visible = False
        '
        'lblMostrarPagado
        '
        Me.lblMostrarPagado.AutoSize = True
        Me.lblMostrarPagado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarPagado.Location = New System.Drawing.Point(91, 584)
        Me.lblMostrarPagado.Name = "lblMostrarPagado"
        Me.lblMostrarPagado.Size = New System.Drawing.Size(82, 24)
        Me.lblMostrarPagado.TabIndex = 53
        Me.lblMostrarPagado.Text = "Pagado"
        '
        'lblPagado
        '
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagado.Image = Global.Atila.My.Resources.Resources.icono_precio
        Me.lblPagado.Location = New System.Drawing.Point(20, 572)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(47, 41)
        Me.lblPagado.TabIndex = 52
        '
        'lblMotivo
        '
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Image = Global.Atila.My.Resources.Resources.icono_motivo
        Me.lblMotivo.Location = New System.Drawing.Point(20, 12)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(54, 58)
        Me.lblMotivo.TabIndex = 34
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Image = Global.Atila.My.Resources.Resources.icono_fecha
        Me.lblFecha.Location = New System.Drawing.Point(20, 172)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 50)
        Me.lblFecha.TabIndex = 35
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Image = Global.Atila.My.Resources.Resources.icono_hora
        Me.lblHora.Location = New System.Drawing.Point(20, 252)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(46, 49)
        Me.lblHora.TabIndex = 36
        '
        'lblPersonas
        '
        Me.lblPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonas.Image = Global.Atila.My.Resources.Resources.icono_personas
        Me.lblPersonas.Location = New System.Drawing.Point(16, 332)
        Me.lblPersonas.Name = "lblPersonas"
        Me.lblPersonas.Size = New System.Drawing.Size(56, 48)
        Me.lblPersonas.TabIndex = 37
        '
        'lblServicio
        '
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Image = Global.Atila.My.Resources.Resources.icono_servicio
        Me.lblServicio.Location = New System.Drawing.Point(15, 412)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(60, 51)
        Me.lblServicio.TabIndex = 39
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Image = Global.Atila.My.Resources.Resources.lista_de_fiestas_reservadas_0021_Capa_25
        Me.lblCliente.Location = New System.Drawing.Point(20, 492)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 50)
        Me.lblCliente.TabIndex = 40
        '
        'lblSeña
        '
        Me.lblSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeña.Image = Global.Atila.My.Resources.Resources.icono_seña
        Me.lblSeña.Location = New System.Drawing.Point(20, 572)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(50, 50)
        Me.lblSeña.TabIndex = 41
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'txtPrecioFiesta
        '
        Me.txtPrecioFiesta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioFiesta.Location = New System.Drawing.Point(174, 6)
        Me.txtPrecioFiesta.Name = "txtPrecioFiesta"
        Me.txtPrecioFiesta.Size = New System.Drawing.Size(62, 32)
        Me.txtPrecioFiesta.TabIndex = 58
        Me.txtPrecioFiesta.Visible = False
        '
        'lblPrecioFiesta
        '
        Me.lblPrecioFiesta.AutoSize = True
        Me.lblPrecioFiesta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFiesta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPrecioFiesta.Location = New System.Drawing.Point(172, 10)
        Me.lblPrecioFiesta.Name = "lblPrecioFiesta"
        Me.lblPrecioFiesta.Size = New System.Drawing.Size(58, 24)
        Me.lblPrecioFiesta.TabIndex = 56
        Me.lblPrecioFiesta.Text = "1000"
        '
        'lblPrecioF
        '
        Me.lblPrecioF.AutoSize = True
        Me.lblPrecioF.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioF.Location = New System.Drawing.Point(6, 9)
        Me.lblPrecioF.Name = "lblPrecioF"
        Me.lblPrecioF.Size = New System.Drawing.Size(177, 24)
        Me.lblPrecioF.TabIndex = 55
        Me.lblPrecioF.Text = "Precio de Fiesta: "
        '
        'btnGuardarPrecioFiesta
        '
        Me.btnGuardarPrecioFiesta.FlatAppearance.BorderSize = 0
        Me.btnGuardarPrecioFiesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPrecioFiesta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPrecioFiesta.Location = New System.Drawing.Point(190, 42)
        Me.btnGuardarPrecioFiesta.Name = "btnGuardarPrecioFiesta"
        Me.btnGuardarPrecioFiesta.Size = New System.Drawing.Size(70, 21)
        Me.btnGuardarPrecioFiesta.TabIndex = 59
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
        Me.btnEditarPrecioFiesta.Location = New System.Drawing.Point(190, 42)
        Me.btnEditarPrecioFiesta.Name = "btnEditarPrecioFiesta"
        Me.btnEditarPrecioFiesta.Size = New System.Drawing.Size(70, 21)
        Me.btnEditarPrecioFiesta.TabIndex = 57
        Me.btnEditarPrecioFiesta.Text = "Editar"
        Me.btnEditarPrecioFiesta.UseVisualStyleBackColor = True
        '
        'pnlSiNoSePago
        '
        Me.pnlSiNoSePago.Controls.Add(Me.btnPagar)
        Me.pnlSiNoSePago.Controls.Add(Me.txtPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.lblPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.lblPrecioF)
        Me.pnlSiNoSePago.Controls.Add(Me.btnGuardarPrecioFiesta)
        Me.pnlSiNoSePago.Controls.Add(Me.btnEditarPrecioFiesta)
        Me.pnlSiNoSePago.Location = New System.Drawing.Point(839, 78)
        Me.pnlSiNoSePago.Name = "pnlSiNoSePago"
        Me.pnlSiNoSePago.Size = New System.Drawing.Size(369, 78)
        Me.pnlSiNoSePago.TabIndex = 60
        '
        'btnPagar
        '
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Image = Global.Atila.My.Resources.Resources.icono_pagar_verde
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPagar.Location = New System.Drawing.Point(236, 5)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(130, 34)
        Me.btnPagar.TabIndex = 53
        Me.btnPagar.Text = "Pagar Reserva"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnCancelarReserva
        '
        Me.btnCancelarReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarReserva.FlatAppearance.BorderSize = 0
        Me.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarReserva.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarReserva.Location = New System.Drawing.Point(923, 706)
        Me.btnCancelarReserva.Name = "btnCancelarReserva"
        Me.btnCancelarReserva.Size = New System.Drawing.Size(225, 38)
        Me.btnCancelarReserva.TabIndex = 60
        Me.btnCancelarReserva.Text = "Cancelar Reserva"
        Me.btnCancelarReserva.UseVisualStyleBackColor = True
        Me.btnCancelarReserva.Visible = False
        '
        'btnSurgioImprevisto
        '
        Me.btnSurgioImprevisto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurgioImprevisto.FlatAppearance.BorderSize = 0
        Me.btnSurgioImprevisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSurgioImprevisto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurgioImprevisto.Location = New System.Drawing.Point(923, 706)
        Me.btnSurgioImprevisto.Name = "btnSurgioImprevisto"
        Me.btnSurgioImprevisto.Size = New System.Drawing.Size(225, 38)
        Me.btnSurgioImprevisto.TabIndex = 61
        Me.btnSurgioImprevisto.Text = "Surgió imprevisto"
        Me.btnSurgioImprevisto.UseVisualStyleBackColor = True
        Me.btnSurgioImprevisto.Visible = False
        '
        'btnGuardarFecha
        '
        Me.btnGuardarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarFecha.FlatAppearance.BorderSize = 0
        Me.btnGuardarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFecha.Location = New System.Drawing.Point(400, 301)
        Me.btnGuardarFecha.Name = "btnGuardarFecha"
        Me.btnGuardarFecha.Size = New System.Drawing.Size(57, 21)
        Me.btnGuardarFecha.TabIndex = 63
        Me.btnGuardarFecha.Text = "Guardar"
        Me.btnGuardarFecha.UseVisualStyleBackColor = True
        Me.btnGuardarFecha.Visible = False
        '
        'btnEditarFecha
        '
        Me.btnEditarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarFecha.FlatAppearance.BorderSize = 0
        Me.btnEditarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarFecha.Location = New System.Drawing.Point(356, 301)
        Me.btnEditarFecha.Name = "btnEditarFecha"
        Me.btnEditarFecha.Size = New System.Drawing.Size(51, 21)
        Me.btnEditarFecha.TabIndex = 62
        Me.btnEditarFecha.Text = "Editar"
        Me.btnEditarFecha.UseVisualStyleBackColor = True
        Me.btnEditarFecha.Visible = False
        '
        'lblEditandoReservas
        '
        Me.lblEditandoReservas.AutoSize = True
        Me.lblEditandoReservas.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditandoReservas.Location = New System.Drawing.Point(145, 101)
        Me.lblEditandoReservas.Name = "lblEditandoReservas"
        Me.lblEditandoReservas.Size = New System.Drawing.Size(143, 18)
        Me.lblEditandoReservas.TabIndex = 65
        Me.lblEditandoReservas.Text = "Editando Reservas"
        Me.lblEditandoReservas.Visible = False
        '
        'btnCancelarFecha
        '
        Me.btnCancelarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarFecha.FlatAppearance.BorderSize = 0
        Me.btnCancelarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarFecha.Location = New System.Drawing.Point(356, 301)
        Me.btnCancelarFecha.Name = "btnCancelarFecha"
        Me.btnCancelarFecha.Size = New System.Drawing.Size(51, 21)
        Me.btnCancelarFecha.TabIndex = 66
        Me.btnCancelarFecha.Text = "Cancelar"
        Me.btnCancelarFecha.UseVisualStyleBackColor = True
        Me.btnCancelarFecha.Visible = False
        '
        'dgvUtiliza
        '
        Me.dgvUtiliza.AllowUserToAddRows = False
        Me.dgvUtiliza.AllowUserToDeleteRows = False
        Me.dgvUtiliza.AllowUserToResizeColumns = False
        Me.dgvUtiliza.AllowUserToResizeRows = False
        Me.dgvUtiliza.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvUtiliza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUtiliza.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUtiliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUtiliza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUtiliza.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvUtiliza.EnableHeadersVisualStyles = False
        Me.dgvUtiliza.Location = New System.Drawing.Point(820, 497)
        Me.dgvUtiliza.MultiSelect = False
        Me.dgvUtiliza.Name = "dgvUtiliza"
        Me.dgvUtiliza.RowHeadersVisible = False
        Me.dgvUtiliza.RowTemplate.Height = 27
        Me.dgvUtiliza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUtiliza.Size = New System.Drawing.Size(263, 135)
        Me.dgvUtiliza.TabIndex = 67
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
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(254, 56)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(217, 17)
        Me.lblNoHayReservas.TabIndex = 69
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(346, 29)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(53, 22)
        Me.lblFechaSeleccionada.TabIndex = 70
        Me.lblFechaSeleccionada.Text = "1/1/1"
        '
        'pbReservasEnELDIa
        '
        Me.pbReservasEnELDIa.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbReservasEnELDIa.Location = New System.Drawing.Point(344, 77)
        Me.pbReservasEnELDIa.Name = "pbReservasEnELDIa"
        Me.pbReservasEnELDIa.Size = New System.Drawing.Size(162, 34)
        Me.pbReservasEnELDIa.TabIndex = 71
        Me.pbReservasEnELDIa.TabStop = False
        '
        'pbCalendario
        '
        Me.pbCalendario.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbCalendario.Location = New System.Drawing.Point(825, 206)
        Me.pbCalendario.Name = "pbCalendario"
        Me.pbCalendario.Size = New System.Drawing.Size(252, 166)
        Me.pbCalendario.TabIndex = 72
        Me.pbCalendario.TabStop = False
        '
        'lblSeleccioneUnaFecha
        '
        Me.lblSeleccioneUnaFecha.AutoSize = True
        Me.lblSeleccioneUnaFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneUnaFecha.Location = New System.Drawing.Point(778, 170)
        Me.lblSeleccioneUnaFecha.Name = "lblSeleccioneUnaFecha"
        Me.lblSeleccioneUnaFecha.Size = New System.Drawing.Size(177, 19)
        Me.lblSeleccioneUnaFecha.TabIndex = 73
        Me.lblSeleccioneUnaFecha.Text = "Seleccione una Fecha"
        '
        'lblCosasUtilizar
        '
        Me.lblCosasUtilizar.AutoSize = True
        Me.lblCosasUtilizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosasUtilizar.Location = New System.Drawing.Point(778, 452)
        Me.lblCosasUtilizar.Name = "lblCosasUtilizar"
        Me.lblCosasUtilizar.Size = New System.Drawing.Size(114, 19)
        Me.lblCosasUtilizar.TabIndex = 74
        Me.lblCosasUtilizar.Text = "Utiliza/Utilizo:"
        '
        'btnExpandirImprevisto
        '
        Me.btnExpandirImprevisto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandirImprevisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandirImprevisto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandirImprevisto.Location = New System.Drawing.Point(254, 639)
        Me.btnExpandirImprevisto.Name = "btnExpandirImprevisto"
        Me.btnExpandirImprevisto.Size = New System.Drawing.Size(26, 23)
        Me.btnExpandirImprevisto.TabIndex = 71
        Me.btnExpandirImprevisto.Text = "..."
        Me.btnExpandirImprevisto.UseVisualStyleBackColor = True
        Me.btnExpandirImprevisto.Visible = False
        '
        'ListadeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 807)
        Me.Controls.Add(Me.lblCosasUtilizar)
        Me.Controls.Add(Me.lblSeleccioneUnaFecha)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.lblNoHayReservas)
        Me.Controls.Add(Me.dgvUtiliza)
        Me.Controls.Add(Me.lblEditandoReservas)
        Me.Controls.Add(Me.btnSurgioImprevisto)
        Me.Controls.Add(Me.btnGuardarFecha)
        Me.Controls.Add(Me.btnCancelarReserva)
        Me.Controls.Add(Me.pnlSiNoSePago)
        Me.Controls.Add(Me.cboReservasEnElDia)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.Controls.Add(Me.pnlDatosReservas)
        Me.Controls.Add(Me.btnEditarFecha)
        Me.Controls.Add(Me.btnCancelarFecha)
        Me.Controls.Add(Me.pbCalendario)
        Me.Controls.Add(Me.pbReservasEnELDIa)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadeReservas"
        Me.Text = "ListadeReservas"
        Me.pnlDatosReservas.ResumeLayout(False)
        Me.pnlDatosReservas.PerformLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSiNoSePago.ResumeLayout(False)
        Me.pnlSiNoSePago.PerformLayout()
        CType(Me.dgvUtiliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReservasEnELDIa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFiestasReservadasParaEl As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
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
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtPrecioFiesta As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioFiesta As System.Windows.Forms.Label
    Friend WithEvents lblPrecioF As System.Windows.Forms.Label
    Friend WithEvents btnGuardarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents btnEditarPrecioFiesta As System.Windows.Forms.Button
    Friend WithEvents pnlSiNoSePago As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarReserva As System.Windows.Forms.Button
    Friend WithEvents btnSurgioImprevisto As System.Windows.Forms.Button
    Friend WithEvents lblEditandoReservas As System.Windows.Forms.Label
    Friend WithEvents btnGuardarFecha As System.Windows.Forms.Button
    Friend WithEvents btnEditarFecha As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelarFecha As System.Windows.Forms.Button
    Friend WithEvents dgvUtiliza As System.Windows.Forms.DataGridView
    Friend WithEvents lblMostrarImprevisto As System.Windows.Forms.Label
    Friend WithEvents lblImprevisto As System.Windows.Forms.Label
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNota As System.Windows.Forms.Label
    Friend WithEvents btnExpandir As System.Windows.Forms.Button
    Friend WithEvents lblNoHayReservas As System.Windows.Forms.Label
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents pbReservasEnELDIa As System.Windows.Forms.PictureBox
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbCalendario As System.Windows.Forms.PictureBox
    Friend WithEvents lblSeleccioneUnaFecha As System.Windows.Forms.Label
    Friend WithEvents lblCosasUtilizar As System.Windows.Forms.Label
    Friend WithEvents btnExpandirImprevisto As System.Windows.Forms.Button
End Class
