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
        Me.botonAgregarDatos = New System.Windows.Forms.Button()
        Me.cuadroCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cuadroNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cuadroDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cuadroTelefonos = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'botonAgregarDatos
        '
        Me.botonAgregarDatos.Location = New System.Drawing.Point(191, 282)
        Me.botonAgregarDatos.Name = "botonAgregarDatos"
        Me.botonAgregarDatos.Size = New System.Drawing.Size(91, 23)
        Me.botonAgregarDatos.TabIndex = 0
        Me.botonAgregarDatos.Text = "Agregar Datos"
        Me.botonAgregarDatos.UseVisualStyleBackColor = True
        '
        'cuadroCedula
        '
        Me.cuadroCedula.Location = New System.Drawing.Point(103, 64)
        Me.cuadroCedula.Name = "cuadroCedula"
        Me.cuadroCedula.Size = New System.Drawing.Size(100, 20)
        Me.cuadroCedula.TabIndex = 1
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
        'cuadroNombre
        '
        Me.cuadroNombre.Location = New System.Drawing.Point(103, 103)
        Me.cuadroNombre.Name = "cuadroNombre"
        Me.cuadroNombre.Size = New System.Drawing.Size(100, 20)
        Me.cuadroNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "cuadroDireccion"
        '
        'cuadroDireccion
        '
        Me.cuadroDireccion.Location = New System.Drawing.Point(103, 141)
        Me.cuadroDireccion.Name = "cuadroDireccion"
        Me.cuadroDireccion.Size = New System.Drawing.Size(100, 20)
        Me.cuadroDireccion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "cuadroTelefonos"
        '
        'cuadroTelefonos
        '
        Me.cuadroTelefonos.Location = New System.Drawing.Point(103, 180)
        Me.cuadroTelefonos.Name = "cuadroTelefonos"
        Me.cuadroTelefonos.Size = New System.Drawing.Size(100, 20)
        Me.cuadroTelefonos.TabIndex = 9
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
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 478)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cuadroTelefonos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cuadroDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cuadroNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cuadroCedula)
        Me.Controls.Add(Me.botonAgregarDatos)
        Me.Name = "Reservar"
        Me.Text = "Reservar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botonAgregarDatos As System.Windows.Forms.Button
    Friend WithEvents cuadroCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cuadroNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cuadroDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cuadroTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
