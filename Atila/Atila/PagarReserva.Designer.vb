<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarReserva
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
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNroRecibo = New System.Windows.Forms.TextBox()
        Me.cboCuotas = New System.Windows.Forms.ComboBox()
        Me.rboEfectivo = New System.Windows.Forms.RadioButton()
        Me.rboTarjeta = New System.Windows.Forms.RadioButton()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.Transparent
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(211, 425)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(120, 42)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(211, 473)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 38)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNroRecibo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRecibo.Location = New System.Drawing.Point(145, 125)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(231, 25)
        Me.txtNroRecibo.TabIndex = 62
        '
        'cboCuotas
        '
        Me.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuotas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuotas.FormattingEnabled = True
        Me.cboCuotas.Items.AddRange(New Object() {"Ninguna", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboCuotas.Location = New System.Drawing.Point(175, 223)
        Me.cboCuotas.Name = "cboCuotas"
        Me.cboCuotas.Size = New System.Drawing.Size(171, 32)
        Me.cboCuotas.TabIndex = 61
        '
        'rboEfectivo
        '
        Me.rboEfectivo.AutoSize = True
        Me.rboEfectivo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboEfectivo.Location = New System.Drawing.Point(344, 405)
        Me.rboEfectivo.Name = "rboEfectivo"
        Me.rboEfectivo.Size = New System.Drawing.Size(14, 13)
        Me.rboEfectivo.TabIndex = 63
        Me.rboEfectivo.UseVisualStyleBackColor = True
        '
        'rboTarjeta
        '
        Me.rboTarjeta.AutoSize = True
        Me.rboTarjeta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboTarjeta.Location = New System.Drawing.Point(175, 405)
        Me.rboTarjeta.Name = "rboTarjeta"
        Me.rboTarjeta.Size = New System.Drawing.Size(14, 13)
        Me.rboTarjeta.TabIndex = 64
        Me.rboTarjeta.UseVisualStyleBackColor = True
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'PagarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Atila.My.Resources.Resources.pagar_Reserv
        Me.ClientSize = New System.Drawing.Size(520, 532)
        Me.Controls.Add(Me.rboTarjeta)
        Me.Controls.Add(Me.rboEfectivo)
        Me.Controls.Add(Me.txtNroRecibo)
        Me.Controls.Add(Me.cboCuotas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PagarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PagarReserva"
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Public WithEvents rboEfectivo As System.Windows.Forms.RadioButton
    Public WithEvents rboTarjeta As System.Windows.Forms.RadioButton
    Public WithEvents txtNroRecibo As System.Windows.Forms.TextBox
    Public WithEvents cboCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents epError As System.Windows.Forms.ErrorProvider
End Class
