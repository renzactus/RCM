﻿Imports System.Drawing.Imaging

Public Class Login
    Dim mysql As New MySQL
    Dim contador As Integer = 0
    Dim bmp As Bitmap
    Dim sumadeopacidad As Double
    Dim imagen As Image
    

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR DE LA CLASE
        EstablecerColores()
        timerChequearMayusculaActivada.Enabled = True
        imagen = pibAnimacion.Image 'ASIGNAMOS A imagen LA IMAGEN QUE TRAE pibAnimacion POR DEFECTO
        sumadeopacidad = 0.005 'ASIGNAMOS UN VALOR DE OPACIDAD QUE LUEGO SE IRA INCREMENTANDO
        tmrCambiandoOpacidad.Enabled = True 'COMENZAMOS EL TIMER
        'Cambiando colores
        btnLogin.BackColor = Principal.colorTerceario
        btnCancelar.BackColor = Principal.colorTerceario
        btnLogin.ForeColor = Color.FromArgb(105, 105, 105)
        btnCancelar.ForeColor = Color.FromArgb(105, 105, 105)
        'Asignando otras cosas
        If My.Settings.Recodar = True Then
            txtCedula.Text = My.Settings.Cedula
            txtContraseña.Text = My.Settings.Contraseña
            chkRecordarSesion.Checked = My.Settings.Recodar
            txtCedula.ForeColor = Color.FromArgb(105, 105, 105)
            txtContraseña.ForeColor = Color.FromArgb(105, 105, 105)
            txtContraseña.PasswordChar = "•"
        End If
    End Sub
    'Diseño
    Private Sub EstablecerColores()
        pnlBarra.BackColor = Principal.colorTerceario
        lblnroCedula.ForeColor = Principal.colorTitulos
        lblContraseña.ForeColor = Principal.colorTitulos
        chkRecordarSesion.ForeColor = Principal.colorTitulos
    End Sub
    'Metodos
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
            mysql.Consultar("select sesiones.ID_USUARIO,funcionarios.nombre from sesiones inner join funcionarios on " &
                "sesiones.ID_FUNCIONARIO=funcionarios.ID_FUNCIONARIO where sesiones.contraseña= binary '" &
                txtContraseña.Text & "' And funcionarios.cedula=" & txtCedula.Text & ";",
                "server=localhost;database=atila;user=login;password=contralogin;") 'ENVIAR CONSULTA
            If mysql.Consultado = True Then 'SI SE CONSULTO SIN ERRORES
                If mysql.Resultado.Rows.Count() = 1 Then 'SI SE DEVOLVIO UNA FILA QUIERE DECIR QUE COINCIDE EL USUARIO
                    If chkRecordarSesion.Checked = True Then 'Si el ChkRecordarSesion esta marcado tiene que almacenar los datos
                        My.Settings.Cedula = txtCedula.Text
                        My.Settings.Contraseña = txtContraseña.Text
                        My.Settings.Recodar = True
                        My.Settings.Save()
                    End If

                    Principal.lblPerfil.Text = mysql.Resultado.Rows(0).Item("nombre")
                    Principal.Show()
                    timerChequearMayusculaActivada.Enabled = False
                    Me.Hide()
                Else
                    Reservar.sonidoError()
                    epError.SetError(txtCedula, "La cedula o contraseña es inválida")
                    epError.SetError(txtContraseña, "La cedula o contraseña es inválida")
                End If
            End If
        End If
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS
        epError.SetError(txtCedula, "")
        epError.SetError(txtContraseña, "")
        If txtCedula.Text.Length > 7 Then
            If txtCedula.SelectedText.Length = 0 Then
                e.Handled = True And Not Char.IsControl(e.KeyChar)
            End If
        End If
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

    Private Sub chkRecordarSesion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecordarSesion.CheckedChanged
        If chkRecordarSesion.Checked = False Then
            My.Settings.Cedula = vbNull
            My.Settings.Contraseña = vbNull
            My.Settings.Recodar = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub timerChequearMayusculaActivada_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerChequearMayusculaActivada.Tick
        If My.Computer.Keyboard.CapsLock Then
            pboMayusculas.Visible = True
        Else
            pboMayusculas.Visible = False
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub pnlBarra_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarra.MouseMove
        Principal.ReleaseCapture()
        Principal.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        epError.SetError(txtCedula, "")
        epError.SetError(txtContraseña, "")
    End Sub
End Class