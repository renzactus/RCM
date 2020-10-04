Imports System.Drawing.Imaging

Public Class Login
    Dim mysql As New MySQL
    Dim contador As Integer = 0
    Dim bmp As Bitmap
    Dim sumadeopacidad As Double
    Dim imagen As Image
    Public Function CambiarOpacidad(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap 'FUNCION PARA CAMBIAR OPACIDAD DE IMAGEN
        bmp = New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, _
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR DE LA CLASE
        'Cambiando colores
        btnLogin.BackColor = Principal.colorsecundario
        btnLogin.ForeColor = Color.FromArgb(105, 105, 105)
        LineShape1.BorderColor = Color.FromArgb(105, 105, 105)
        LineShape2.BorderColor = Color.FromArgb(105, 105, 105)
        'Asignando otras cosas
        imagen = pibAnimacion.Image 'ASIGNAMOS A imagen LA IMAGEN QUE TRAE pibAnimacion POR DEFECTO
        sumadeopacidad = 0.99 'ASIGNAMOS UN VALOR DE OPACIDAD QUE LUEGO SE IRA INCREMENTANDO poner en 0.005
        tmrCambiandoOpacidad.Enabled = True 'COMENZAMOS EL TIMER
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCambiandoOpacidad.Tick
        If sumadeopacidad < 1 Then
            pibAnimacion.Image = CambiarOpacidad(imagen, sumadeopacidad)
            sumadeopacidad = sumadeopacidad + 0.005
            'PARA EVITAR QUE SE SOBRE CARGUE LA MEMORIA RAM VAMOS LIMPIANDO CADA VEZ QUE SE EJECUTA LA FUNCION
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Else
            bmp.Dispose() 'ACABAMOS CON EL VALOR DEL BITMAP PARA LIBERAR RAM
            tmrCambiandoOpacidad.Enabled = False 'PARAMOS EL TIMER
            Me.BackColor = Principal.colorprincipal 'Establecemos el color de fondo
            pibAnimacion.Visible = False 'OCULTAMOS LA IMAGEN
        End If
    End Sub


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtCedula.Text = "" Or txtContraseña.Text = "" Or txtCedula.Text = "Cédula" Or txtContraseña.Text = "Contraseña" Then 'SI ESTAN VACIAS
            MsgBox("Las credenciales no pueden estar vacias")
        Else
            mysql.Consulta = "select sesiones.ID_USUARIO,funcionarios.nombre from sesiones inner join funcionarios_sesiones on " &
                "sesiones.ID_USUARIO=funcionarios_sesiones.ID_USUARIO inner join funcionarios on " &
                "funcionarios_sesiones.ID_FUNCIONARIOS=funcionarios.ID_FUNCIONARIOS where sesiones.contraseña= binary '" &
                txtContraseña.Text & "' And funcionarios.cedula=" & txtCedula.Text & ";"
            mysql.Consultar() 'ENVIAR CONSULTA
            If mysql.Consultado = True Then 'SI SE CONSULTO SIN ERRORES
                If mysql.Data.Rows.Count() = 1 Then 'SI SE DEVOLVIO UNA FILA QUIERE DECIR QUE COINCIDE EL USUARIO
                    Principal.lblPerfil.Text = mysql.Data.Rows(0).Item("nombre")
                    MessageBox.Show("Bienvenido al Sistema " & Principal.lblPerfil.Text, "Sistema")
                    Principal.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("datos invalidos", "Sistema")
                End If
            End If
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS
    End Sub

    Private Sub Login_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Principal.ReleaseCapture()
        Principal.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub pboLogoAtila_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pboLogoAtila.MouseMove
        Principal.ReleaseCapture()
        Principal.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtCedula_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedula.Enter
        If txtCedula.Text = "Cédula" Then
            txtCedula.Text = ""
            txtCedula.ForeColor = Color.FromArgb(105, 105, 105)
        End If
    End Sub

    Private Sub txtCedula_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If txtCedula.Text = "" Then
            txtCedula.Text = "Cédula"
            txtCedula.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtContraseña_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.Enter
        If txtContraseña.Text = "Contraseña" Then
            txtContraseña.Text = ""
            txtContraseña.PasswordChar = "•"
            txtContraseña.ForeColor = Color.FromArgb(105, 105, 105)
        End If
    End Sub

    Private Sub txtContraseña_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.Leave
        If txtContraseña.Text = "" Then
            txtContraseña.Text = "Contraseña"
            txtContraseña.PasswordChar = ""
            txtContraseña.ForeColor = Color.LightGray
        End If
    End Sub
End Class