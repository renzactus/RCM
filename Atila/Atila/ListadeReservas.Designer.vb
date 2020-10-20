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
        Me.SuspendLayout()
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(351, 27)
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
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(330, 9)
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
        Me.Calendario.Location = New System.Drawing.Point(28, 18)
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
        Me.lblMotivo.Location = New System.Drawing.Point(384, 84)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(48, 16)
        Me.lblMotivo.TabIndex = 34
        Me.lblMotivo.Text = "Motivo"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(386, 109)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblFecha.TabIndex = 35
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(394, 134)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(38, 16)
        Me.lblHora.TabIndex = 36
        Me.lblHora.Text = "Hora"
        '
        'lblPersonas
        '
        Me.lblPersonas.AutoSize = True
        Me.lblPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonas.Location = New System.Drawing.Point(366, 160)
        Me.lblPersonas.Name = "lblPersonas"
        Me.lblPersonas.Size = New System.Drawing.Size(66, 16)
        Me.lblPersonas.TabIndex = 37
        Me.lblPersonas.Text = "Personas"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(375, 185)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(57, 16)
        Me.lblServicio.TabIndex = 39
        Me.lblServicio.Text = "Servicio"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(384, 211)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(49, 16)
        Me.lblCliente.TabIndex = 40
        Me.lblCliente.Text = "Cliente"
        '
        'lblSeña
        '
        Me.lblSeña.AutoSize = True
        Me.lblSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeña.Location = New System.Drawing.Point(393, 237)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(40, 16)
        Me.lblSeña.TabIndex = 41
        Me.lblSeña.Text = "Seña"
        '
        'lblMostrarMotivo
        '
        Me.lblMostrarMotivo.AutoSize = True
        Me.lblMostrarMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarMotivo.Location = New System.Drawing.Point(452, 84)
        Me.lblMostrarMotivo.Name = "lblMostrarMotivo"
        Me.lblMostrarMotivo.Size = New System.Drawing.Size(48, 16)
        Me.lblMostrarMotivo.TabIndex = 42
        Me.lblMostrarMotivo.Text = "Motivo"
        '
        'lblMostrarFecha
        '
        Me.lblMostrarFecha.AutoSize = True
        Me.lblMostrarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarFecha.Location = New System.Drawing.Point(452, 109)
        Me.lblMostrarFecha.Name = "lblMostrarFecha"
        Me.lblMostrarFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblMostrarFecha.TabIndex = 43
        Me.lblMostrarFecha.Text = "Fecha"
        '
        'lblMostrarHora
        '
        Me.lblMostrarHora.AutoSize = True
        Me.lblMostrarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarHora.Location = New System.Drawing.Point(452, 134)
        Me.lblMostrarHora.Name = "lblMostrarHora"
        Me.lblMostrarHora.Size = New System.Drawing.Size(38, 16)
        Me.lblMostrarHora.TabIndex = 44
        Me.lblMostrarHora.Text = "Hora"
        '
        'lblMostrarPersonas
        '
        Me.lblMostrarPersonas.AutoSize = True
        Me.lblMostrarPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarPersonas.Location = New System.Drawing.Point(452, 160)
        Me.lblMostrarPersonas.Name = "lblMostrarPersonas"
        Me.lblMostrarPersonas.Size = New System.Drawing.Size(66, 16)
        Me.lblMostrarPersonas.TabIndex = 45
        Me.lblMostrarPersonas.Text = "Personas"
        '
        'lblMostrarCliente
        '
        Me.lblMostrarCliente.AutoSize = True
        Me.lblMostrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarCliente.Location = New System.Drawing.Point(452, 211)
        Me.lblMostrarCliente.Name = "lblMostrarCliente"
        Me.lblMostrarCliente.Size = New System.Drawing.Size(49, 16)
        Me.lblMostrarCliente.TabIndex = 48
        Me.lblMostrarCliente.Text = "Cliente"
        '
        'lblMostrarSeña
        '
        Me.lblMostrarSeña.AutoSize = True
        Me.lblMostrarSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarSeña.Location = New System.Drawing.Point(452, 237)
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
        Me.cboReservasEnElDia.Location = New System.Drawing.Point(387, 42)
        Me.cboReservasEnElDia.Name = "cboReservasEnElDia"
        Me.cboReservasEnElDia.Size = New System.Drawing.Size(94, 21)
        Me.cboReservasEnElDia.TabIndex = 50
        '
        'chkMostrarServicio
        '
        Me.chkMostrarServicio.AutoSize = True
        Me.chkMostrarServicio.Enabled = False
        Me.chkMostrarServicio.Location = New System.Drawing.Point(466, 187)
        Me.chkMostrarServicio.Name = "chkMostrarServicio"
        Me.chkMostrarServicio.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarServicio.TabIndex = 51
        Me.chkMostrarServicio.UseVisualStyleBackColor = True
        '
        'ListadeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 438)
        Me.Controls.Add(Me.chkMostrarServicio)
        Me.Controls.Add(Me.cboReservasEnElDia)
        Me.Controls.Add(Me.lblMostrarSeña)
        Me.Controls.Add(Me.lblMostrarCliente)
        Me.Controls.Add(Me.lblMostrarPersonas)
        Me.Controls.Add(Me.lblMostrarHora)
        Me.Controls.Add(Me.lblMostrarFecha)
        Me.Controls.Add(Me.lblMostrarMotivo)
        Me.Controls.Add(Me.lblSeña)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.lblPersonas)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblNoHayReservas)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.Name = "ListadeReservas"
        Me.Text = "ListadeReservas"
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
End Class
