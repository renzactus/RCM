Imports System.Runtime.InteropServices
Public Class Principal
    Dim mysql As New MySQL
    Dim datosReservasNotificacion As DataTable
    Public colorprincipal As Color = Color.FromArgb(239, 231, 219)
    Public colorsecundario As Color = Color.FromArgb(227, 195, 176)

    Dim TamañoNotificacionY As Integer = 0
    Dim contador As Integer = 0
    Dim some_button As New Button
    Dim new_panel(5) As Panel
    Dim cliceado As Integer
    'Constructor
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR DE LA CLASE


        Me.BackColor = colorprincipal
        pnlArriba.BackColor = Color.FromArgb(colorsecundario.R, colorsecundario.G, colorsecundario.B)
        actualizarNotificaciones()
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
    Private Sub actualizarNotificaciones()
        mysql.Consultar("select motivo,fecha,nombre from reservas inner join clientes on clientes.ID_CLIENTE=reservas.ID_CLIENTE where fecha<current_date")
        datosReservasNotificacion = mysql.Resultado
        For i = 0 To datosReservasNotificacion.Rows.Count - 1
            ' dgvNotificaciones.Rows.Add(Panel1)
            'continuar esto
            'datosReservasNotificacion.Rows(i).Item("motivo")
        Next
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        new_panel(contador) = New Panel
        With new_panel(contador)
            .Location = New Point(0, TamañoNotificacionY)
            .Size = New Size(pnllPlantillaNotificacion.Width, pnllPlantillaNotificacion.Height)
            AddHandler new_panel(contador).MouseClick, AddressOf pnllPlantillaNotificacion_MouseClick
        End With
        'new_panel.Controls.Add(some_label)

        some_button = New Button

            With some_button
            .Tag = "some value" ' A way to Identify the button if clicked
            .BackColor = btnPlantillaAceptar.BackColor
            .UseVisualStyleBackColor = True
            .Location = btnPlantillaAceptar.Location
            .Text = btnPlantillaAceptar.Text
            AddHandler some_button.Click, AddressOf btnPlantillaAceptar_Click
            ' The Sub that determines what happens when that button is clicked.
            End With

        new_panel(contador).Controls.Add(some_button)
        pnlN.Controls.Add(new_panel(contador))

        Button5.Tag = new_panel(contador).Bottom ' Set the bottom position of the last panel added.

        TamañoNotificacionY = TamañoNotificacionY + 200
        contador = contador + 1
    End Sub

    Private Sub btnPlantillaAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlantillaAceptar.Click
        'MsgBox("aa" & Me.new_panel().)
    End Sub

    Private Sub pnllPlantillaNotificacion_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnllPlantillaNotificacion.MouseClick
        cliceado = new
    End Sub
End Class
