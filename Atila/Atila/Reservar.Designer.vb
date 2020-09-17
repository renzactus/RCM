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
        Me.btnAgregarDatos = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAgregarTelefonos = New System.Windows.Forms.Button()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.txtTelefono3 = New System.Windows.Forms.TextBox()
        Me.btnRestarTelefonos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregarDatos
        '
        Me.btnAgregarDatos.Location = New System.Drawing.Point(76, 358)
        Me.btnAgregarDatos.Name = "btnAgregarDatos"
        Me.btnAgregarDatos.Size = New System.Drawing.Size(91, 23)
        Me.btnAgregarDatos.TabIndex = 0
        Me.btnAgregarDatos.Text = "Agregar Datos"
        Me.btnAgregarDatos.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(103, 64)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "cuadroCedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "cuadroNombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 103)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "cuadroDireccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(95, 239)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "cuadroTelefonos"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(103, 144)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono1.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(288, 103)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Habilitar edicion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefonos
        '
        Me.btnAgregarTelefonos.Location = New System.Drawing.Point(209, 144)
        Me.btnAgregarTelefonos.Name = "btnAgregarTelefonos"
        Me.btnAgregarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelefonos.TabIndex = 12
        Me.btnAgregarTelefonos.Text = "+"
        Me.btnAgregarTelefonos.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(103, 170)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono2.TabIndex = 13
        Me.txtTelefono2.Visible = False
        '
        'txtTelefono3
        '
        Me.txtTelefono3.Location = New System.Drawing.Point(103, 196)
        Me.txtTelefono3.Name = "txtTelefono3"
        Me.txtTelefono3.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono3.TabIndex = 14
        Me.txtTelefono3.Visible = False
        '
        'btnRestarTelefonos
        '
        Me.btnRestarTelefonos.Location = New System.Drawing.Point(241, 144)
        Me.btnRestarTelefonos.Name = "btnRestarTelefonos"
        Me.btnRestarTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.btnRestarTelefonos.TabIndex = 15
        Me.btnRestarTelefonos.Text = "-"
        Me.btnRestarTelefonos.UseVisualStyleBackColor = True
        Me.btnRestarTelefonos.Visible = False
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 478)
        Me.Controls.Add(Me.btnRestarTelefonos)
        Me.Controls.Add(Me.txtTelefono3)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.btnAgregarTelefonos)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.btnAgregarDatos)
        Me.Name = "Reservar"
        Me.Text = "Reservar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarDatos As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAgregarTelefonos As System.Windows.Forms.Button
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono3 As System.Windows.Forms.TextBox
    Friend WithEvents btnRestarTelefonos As System.Windows.Forms.Button
End Class
