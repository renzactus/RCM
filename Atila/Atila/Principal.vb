Imports System.Runtime.InteropServices

Public Class Principal
    Dim mysql As New MySQL
    Dim datosReservasNotificacion As DataTable
    Public colorprincipal As Color = Color.FromArgb(239, 231, 219)
    Public colorsecundario As Color = Color.FromArgb(227, 195, 176)

    'Constructor
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR DE LA CLASE


        Me.BackColor = colorprincipal
        pnlArriba.BackColor = Color.FromArgb(colorsecundario.R, colorsecundario.G, colorsecundario.B)
        actualizarNotificaciones(1)
    End Sub
    'Notificaciones
    Private Sub MostrarCuadroNotificaciones()
        If pnlCuadroNotificaciones.Visible = False Then
            pnlCuadroNotificaciones.Visible = True
            pnlCuadroNotificaciones.Location = New Point(958, 31)
        Else
            pnlCuadroNotificaciones.Visible = False
        End If

    End Sub
    Private Sub actualizarNotificaciones(ByVal pagina As Integer)

        mysql.Consultar("select motivo,fecha,nombre from reservas inner join clientes on clientes.ID_CLIENTE=reservas.ID_CLIENTE where fecha<current_date and fecha_cancelacion is null")
        datosReservasNotificacion = mysql.Resultado
        vaciarNotificaciones()
        rellenarNotificaciones(pagina)
        If datosReservasNotificacion.Rows.Count > 3 Then
            llblPaginaSiguiente.Visible = True
        End If
    End Sub
    Private Sub vaciarNotificaciones()
        pnlNotificacion1.Visible = False
        pnlNotificacion2.Visible = False
        pnlNotificacion3.Visible = False
        'Tambien que se achique el pnlCuadroNotificaciones dependiendo los que sean visibles
    End Sub
    Private Sub rellenarNotificaciones(ByVal pagina As Integer)
        If datosReservasNotificacion.Rows.Count = 1 Then
            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("Motivo")
            'dar los valores al 1
        ElseIf datosReservasNotificacion.Rows.Count = 2 Then
            pnlNotificacion1.Visible = True
            pnlNotificacion2.Visible = True
            'dar los valores al 1,2
        ElseIf datosReservasNotificacion.Rows.Count > 2 Then
            pnlNotificacion1.Visible = True
            pnlNotificacion2.Visible = True
            pnlNotificacion3.Visible = True
            'dar los valores al 3
        End If
    End Sub
    'Importamos dll de windows para mover la pestaña arrastrando en el pnlArriba
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'Eventos
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Panel1.Controls.Count > 0 Then
            Panel1.Controls.RemoveAt(0)
        Else
            Dim dr As Object
            Dim listadereservas As ListadeReservas = New ListadeReservas
            listadereservas.ChequearSiHayMasDeUnaReservaEnElDiaYProceder("27/10/2020")
            listadereservas.cboReservasEnElDia.SelectedIndex = 0
            dr = listadereservas.pnlDatosReservas
            dr.Dock = DockStyle.Fill
            Panel1.Controls.Add(dr)
            Panel1.Tag = dr
            dr.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim inventario As New Inventario
        inventario.Show()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        System.Diagnostics.Process.Start("https://github.com/renzactus/RCM")


    End Sub

    Private Sub btnAyuda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.MouseHover
        Me.ToolTip1.SetToolTip(btnAyuda, "Ante cualquier duda llamar a 091111111")
    End Sub

    Private Sub btnNotificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificaciones.Click
        MostrarCuadroNotificaciones()
    End Sub

    Private Sub llblPaginaSiguiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblPaginaSiguiente.LinkClicked

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub
End Class
