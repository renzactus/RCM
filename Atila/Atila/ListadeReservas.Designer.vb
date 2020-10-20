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
        Me.lblHora3 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.lblNoHayReservas = New System.Windows.Forms.Label()
        Me.llblMotivoReserva3 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva2 = New System.Windows.Forms.LinkLabel()
        Me.llblMotivoReserva1 = New System.Windows.Forms.LinkLabel()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.lblFiestasReservadasParaEl = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.lblPersonas = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHora3
        '
        Me.lblHora3.AutoSize = True
        Me.lblHora3.Location = New System.Drawing.Point(105, 343)
        Me.lblHora3.Name = "lblHora3"
        Me.lblHora3.Size = New System.Drawing.Size(45, 13)
        Me.lblHora3.TabIndex = 29
        Me.lblHora3.Text = "Label11"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Location = New System.Drawing.Point(105, 321)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(45, 13)
        Me.lblHora2.TabIndex = 28
        Me.lblHora2.Text = "Label10"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.Location = New System.Drawing.Point(105, 300)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(39, 13)
        Me.lblHora1.TabIndex = 27
        Me.lblHora1.Text = "Label9"
        '
        'lblNoHayReservas
        '
        Me.lblNoHayReservas.AutoSize = True
        Me.lblNoHayReservas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHayReservas.Location = New System.Drawing.Point(33, 285)
        Me.lblNoHayReservas.Name = "lblNoHayReservas"
        Me.lblNoHayReservas.Size = New System.Drawing.Size(172, 15)
        Me.lblNoHayReservas.TabIndex = 26
        Me.lblNoHayReservas.Text = "No hay reservas en esta fecha"
        '
        'llblMotivoReserva3
        '
        Me.llblMotivoReserva3.AutoSize = True
        Me.llblMotivoReserva3.Location = New System.Drawing.Point(33, 343)
        Me.llblMotivoReserva3.Name = "llblMotivoReserva3"
        Me.llblMotivoReserva3.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva3.TabIndex = 25
        Me.llblMotivoReserva3.TabStop = True
        Me.llblMotivoReserva3.Text = "LinkLabel3"
        '
        'llblMotivoReserva2
        '
        Me.llblMotivoReserva2.AutoSize = True
        Me.llblMotivoReserva2.Location = New System.Drawing.Point(33, 321)
        Me.llblMotivoReserva2.Name = "llblMotivoReserva2"
        Me.llblMotivoReserva2.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva2.TabIndex = 24
        Me.llblMotivoReserva2.TabStop = True
        Me.llblMotivoReserva2.Text = "LinkLabel2"
        '
        'llblMotivoReserva1
        '
        Me.llblMotivoReserva1.AutoSize = True
        Me.llblMotivoReserva1.Location = New System.Drawing.Point(33, 300)
        Me.llblMotivoReserva1.Name = "llblMotivoReserva1"
        Me.llblMotivoReserva1.Size = New System.Drawing.Size(59, 13)
        Me.llblMotivoReserva1.TabIndex = 23
        Me.llblMotivoReserva1.TabStop = True
        Me.llblMotivoReserva1.Text = "LinkLabel1"
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(211, 267)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(0, 18)
        Me.lblFechaSeleccionada.TabIndex = 22
        '
        'lblFiestasReservadasParaEl
        '
        Me.lblFiestasReservadasParaEl.AutoSize = True
        Me.lblFiestasReservadasParaEl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiestasReservadasParaEl.Location = New System.Drawing.Point(12, 267)
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
        Me.Calendario.Location = New System.Drawing.Point(54, 85)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Motivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(398, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Personas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(379, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Servicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Seña"
        '
        'lblSeña
        '
        Me.lblSeña.AutoSize = True
        Me.lblSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeña.Location = New System.Drawing.Point(456, 183)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(40, 16)
        Me.lblSeña.TabIndex = 49
        Me.lblSeña.Text = "Seña"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(456, 157)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(49, 16)
        Me.lblCliente.TabIndex = 48
        Me.lblCliente.Text = "Cliente"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(456, 131)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(57, 16)
        Me.lblServicio.TabIndex = 47
        Me.lblServicio.Text = "Servicio"
        '
        'lblPersonas
        '
        Me.lblPersonas.AutoSize = True
        Me.lblPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonas.Location = New System.Drawing.Point(456, 106)
        Me.lblPersonas.Name = "lblPersonas"
        Me.lblPersonas.Size = New System.Drawing.Size(66, 16)
        Me.lblPersonas.TabIndex = 45
        Me.lblPersonas.Text = "Personas"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(456, 80)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(38, 16)
        Me.lblHora.TabIndex = 44
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(456, 55)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblFecha.TabIndex = 43
        Me.lblFecha.Text = "Fecha"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(456, 30)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(48, 16)
        Me.lblMotivo.TabIndex = 42
        Me.lblMotivo.Text = "Motivo"
        '
        'ListadeReservas
        '
        Me.AcceptButton = Me.llblMotivoReserva3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 445)
        Me.Controls.Add(Me.lblSeña)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.lblPersonas)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.lblHora3)
        Me.Controls.Add(Me.lblHora2)
        Me.Controls.Add(Me.lblHora1)
        Me.Controls.Add(Me.lblNoHayReservas)
        Me.Controls.Add(Me.llblMotivoReserva3)
        Me.Controls.Add(Me.llblMotivoReserva2)
        Me.Controls.Add(Me.llblMotivoReserva1)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.lblFiestasReservadasParaEl)
        Me.Name = "ListadeReservas"
        Me.Text = "ListadeReservas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHora3 As System.Windows.Forms.Label
    Friend WithEvents lblHora2 As System.Windows.Forms.Label
    Friend WithEvents lblHora1 As System.Windows.Forms.Label
    Friend WithEvents lblNoHayReservas As System.Windows.Forms.Label
    Friend WithEvents llblMotivoReserva3 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva2 As System.Windows.Forms.LinkLabel
    Friend WithEvents llblMotivoReserva1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents lblFiestasReservadasParaEl As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSeña As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents lblPersonas As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
End Class
