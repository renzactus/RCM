Imports System.Runtime.InteropServices
Public Class Principal
    Public colorprincipal As Color = Color.FromArgb(239, 231, 219)
    Public colorsecundario As Color = Color.FromArgb(227, 195, 176)
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR DE LA CLASE
        Me.BackColor = colorprincipal
        pnlArriba.BackColor = Color.FromArgb(colorsecundario.R, colorsecundario.G, colorsecundario.B)
    End Sub
    'Importamos dll de windows para mover la pestaña arrastrando en el pnlArriba
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarunareserva.Click
        Dim reservar As New Reservar
        reservar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim login As New Login
        login.Show()
    End Sub

    Private Sub btnListadereservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadereservas.Click
        Dim listadereservas As New ListadeReservas
        listadereservas.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlArriba_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlArriba.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerfil.MouseEnter
        lblPerfil.Font = New Font("Sans Serif", 11, FontStyle.Underline, GraphicsUnit.Point)
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerfil.MouseLeave
        lblPerfil.Font = New Font("Sans Serif", 11, FontStyle.Regular, GraphicsUnit.Point)
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
End Class
