Imports System.Drawing.Imaging

Public Class Login
    Dim sumadeopacidad As Double
    Dim imagen As Image
    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap 'FUNCION PARA CAMBIAR OPACIDAD DE IMAGEN CON pibAnimacion.Image = ChangeOpacity(pibAnimacion.Image, contador)
        Dim bmp As New Bitmap(img.Width, img.Height)
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
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' CONSTRUCTOR DE LA CLASE
        imagen = pibAnimacion.Image
        sumadeopacidad = 0.005
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If sumadeopacidad < 1 Then
            pibAnimacion.Image = ChangeOpacity(imagen, sumadeopacidad)
            sumadeopacidad = sumadeopacidad + 0.005
        Else
            Timer1.Enabled = False
            pibAnimacion.Visible = False
        End If
    End Sub
End Class