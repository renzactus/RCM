Imports System.Runtime.InteropServices
Public Class Principal
    Dim mysql As New MySQL
    Dim datosReservasNotificacion As DataTable
    Dim PaginaNotificacion As Integer = 1
    Public booleanImprevistoAlmacenado As Boolean
    'Colores para el diseño
    Public colorPrincipal As Color = Color.FromArgb(239, 231, 220)
    Public colorSecundario As Color = Color.FromArgb(240, 223, 198)
    Public colorTerceario As Color = Color.FromArgb(227, 194, 175)
    Public colorTitulos As Color = Color.FromArgb(146, 90, 90)

    Dim oFrameAMostrar As Object
    Dim FrameAMostrar As Reservar
    'Constructor
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirFormEnPanel(Of Reservar)(btnReservar)

        EstablecerColores()
        ActualizarNotificaciones()
        llblPaginaSiguiente.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        llblPaginaAnterior.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
    End Sub
    'Diseño
    Private Sub EstablecerColores()
        Me.BackColor = colorSecundario
        pnlMenu.BackColor = colorPrincipal
        pnlArriba.BackColor = colorTerceario
        'Notificaciones
        pnlNotificacion1.BackColor = Color.FromArgb(251, 246, 240)
        pnlNotificacion2.BackColor = Color.FromArgb(251, 246, 240)
        pnlNotificacion3.BackColor = Color.FromArgb(251, 246, 240)
        pnlCuadroNotificaciones.BackColor = Color.FromArgb(251, 246, 240)

        btnNotificacion1Cancelar.ForeColor = colorTitulos
        btnNotificacion2Cancelar.ForeColor = colorTitulos
        btnNotificacion3Cancelar.ForeColor = colorTitulos
        btnNotificacion1Aceptar.ForeColor = colorTitulos
        btnNotificacion2Aceptar.ForeColor = colorTitulos
        btnNotificacion3Aceptar.ForeColor = colorTitulos

        lblNotificacion1Texto.ForeColor = colorTitulos
        lblNotificacion2Texto.ForeColor = colorTitulos
        lblNotificacion3Texto.ForeColor = colorTitulos
    End Sub
    'Menu
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})(ByVal Boton As Button)
        Dim Formulario As Form
        Formulario = pnlMostrador.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            pnlMostrador.Controls.Add(Formulario)
            pnlMostrador.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Public Sub ReiniciarReservas()
        Dim Formulario As Form
        Formulario = pnlMostrador.Controls.OfType(Of Reservar)().FirstOrDefault()
        Formulario = New Reservar()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        pnlMostrador.Controls.Add(Formulario)
        pnlMostrador.Tag = Formulario
        Formulario.Show()
        Formulario.BringToFront()
    End Sub

    Public Sub ReiniciarListaReservas()
        Dim Formulario As Form
        Formulario = pnlMostrador.Controls.OfType(Of ListadeReservas)().FirstOrDefault()
        Formulario = New ListadeReservas()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        pnlMostrador.Controls.Add(Formulario)
        pnlMostrador.Tag = Formulario
        Formulario.Show()
        Formulario.BringToFront()
    End Sub

    'Notificaciones
    Private Sub MostrarCuadroNotificaciones()
        If pnlCuadroNotificaciones.Visible = False Then
            pnlCuadroNotificaciones.BringToFront()
            pnlCuadroNotificaciones.Height = 1
            pnlCuadroNotificaciones.Visible = True
            btnNotificaciones.Enabled = False
            timerMostrarNotificacion.Enabled = True
            'pnlCuadroNotificaciones.Location = New Point(618, 29)
        Else
            btnNotificaciones.Enabled = False
            timerOcultarNotificacion.Enabled = True
        End If

    End Sub

    Private Sub ActualizarNotificaciones()

        mysql.Consultar("select ID_RESERVA,motivo,fecha,nombre,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final from reservas inner join clientes on " &
                        "clientes.ID_CLIENTE=reservas.ID_CLIENTE where fecha<current_date and fecha_cancelacion is null and razon_cancelacion is null order by fecha")
        datosReservasNotificacion = mysql.Resultado
        If PaginaNotificacion = 3 And datosReservasNotificacion.Rows.Count <= 6 Then
            PaginaNotificacion = 2
        ElseIf PaginaNotificacion = 2 And datosReservasNotificacion.Rows.Count <= 3 Then
            PaginaNotificacion = 1
        End If
        If PaginaNotificacion = 2 And datosReservasNotificacion.Rows.Count <= 6 Then
            llblPaginaSiguiente.Visible = False
        ElseIf PaginaNotificacion = 1 And datosReservasNotificacion.Rows.Count <= 3 Then
            llblPaginaSiguiente.Visible = False
        End If
        actualizarNumeroNotificaciones()
        rellenarNotificaciones(PaginaNotificacion)

    End Sub
    Private Sub actualizarNumeroNotificaciones()
        If datosReservasNotificacion.Rows.Count > 9 Then
            lblCantidadDeNotificaciones.Text = "+9"
        Else
            lblCantidadDeNotificaciones.Text = datosReservasNotificacion.Rows.Count
        End If
    End Sub
    Private Sub rellenarNotificaciones(ByVal pagina As Integer)
        vaciarNotificaciones()
        If datosReservasNotificacion.Rows.Count = 1 Or (datosReservasNotificacion.Rows.Count = 4 And pagina = 2) Or (datosReservasNotificacion.Rows.Count = 7 And pagina = 3) Then

            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo") & ":"
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

        ElseIf datosReservasNotificacion.Rows.Count = 2 Or (datosReservasNotificacion.Rows.Count = 5 And pagina = 2) Or (datosReservasNotificacion.Rows.Count = 8 And pagina = 3) Then

            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo") & ":"
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

            pnlNotificacion2.Visible = True
            lblNotificacion2Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("motivo") & ":"
            lblNotificacion2Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("fecha")
            lblNotificacion2Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("final").ToString

        ElseIf datosReservasNotificacion.Rows.Count > 2 Or (datosReservasNotificacion.Rows.Count = 6 And pagina = 2) Or (datosReservasNotificacion.Rows.Count = 9 And pagina = 3) Then
            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo") & ":"
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

            pnlNotificacion2.Visible = True
            lblNotificacion2Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("motivo") & ":"
            lblNotificacion2Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("fecha")
            lblNotificacion2Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("final").ToString

            pnlNotificacion3.Visible = True
            lblNotificacion3Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 2).Item("motivo") & ":"
            lblNotificacion3Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 2).Item("fecha")
            lblNotificacion3Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 2).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1) + 2).Item("final").ToString
            'dar los valores al 3
        End If
    End Sub
    Private Sub vaciarNotificaciones()
        pnlNotificacion1.Visible = False
        pnlNotificacion2.Visible = False
        pnlNotificacion3.Visible = False
        'Tambien que se achique el pnlCuadroNotificaciones dependiendo los que sean visibles
    End Sub

    Private Sub actualizarAReservaSinProblema(ByVal NroNotificacion As Integer)
        mysql.InsertarDatos("update reservas set razon_cancelacion='' where ID_RESERVA=" & datosReservasNotificacion.Rows(3 * (PaginaNotificacion - 1) + NroNotificacion - 1).Item("ID_RESERVA"))
        ActualizarNotificaciones()
    End Sub
    Private Sub actualizarAReservaConImprevisto(ByVal NroNotificacion As Integer)
        ListadeReservas.AlmacenarImprevisto(datosReservasNotificacion.Rows(3 * (PaginaNotificacion - 1) + NroNotificacion - 1).Item("ID_RESERVA"))
        If mysql.Consultado = True And booleanImprevistoAlmacenado = True Then
            mysql.InsertarDatos("update reservas set razon_cancelacion='' where ID_RESERVA=" & datosReservasNotificacion.Rows(3 * (PaginaNotificacion - 1) + NroNotificacion - 1).Item("ID_RESERVA"))
        End If
        ActualizarNotificaciones()
    End Sub

    'Importamos dll de windows para mover la pestaña arrastrando en el pnlArriba
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'Eventos Relacionados con notificaciones
    Private Sub btnNotificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificaciones.Click
        MostrarCuadroNotificaciones()
        ActualizarNotificaciones()
        PaginaNotificacion = 1
        llblPaginaAnterior.Visible = False
        If datosReservasNotificacion.Rows.Count > 3 Then
            llblPaginaSiguiente.Visible = True
        Else
            llblPaginaSiguiente.Visible = False
        End If
    End Sub

    Private Sub llblPaginaAnterior_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblPaginaAnterior.LinkClicked
        PaginaNotificacion = PaginaNotificacion - 1
        llblPaginaSiguiente.Visible = True
        If PaginaNotificacion = 2 Then
            rellenarNotificaciones(2)
        ElseIf PaginaNotificacion = 1 Then
            rellenarNotificaciones(1)
            llblPaginaAnterior.Visible = False
        End If
    End Sub

    Private Sub btnNotificacion1Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion1Aceptar.Click
        actualizarAReservaSinProblema(1)
    End Sub

    Private Sub btnNotificacion2Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion2Aceptar.Click
        actualizarAReservaSinProblema(2)
    End Sub

    Private Sub btnNotificacion3Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion3Aceptar.Click
        actualizarAReservaSinProblema(3)
    End Sub

    Private Sub btnNotificacion1No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion1Cancelar.Click
        actualizarAReservaConImprevisto(1)
    End Sub

    Private Sub btnNotificacion2No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion2Cancelar.Click
        actualizarAReservaConImprevisto(2)
    End Sub

    Private Sub btnNotificacion3No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion3Cancelar.Click
        actualizarAReservaConImprevisto(3)
    End Sub

    Private Sub llblPaginaSiguiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblPaginaSiguiente.LinkClicked
        If PaginaNotificacion = 1 Then
            rellenarNotificaciones(2)
            PaginaNotificacion = 2
            llblPaginaAnterior.Visible = True
            If datosReservasNotificacion.Rows.Count < 7 Then
                llblPaginaSiguiente.Visible = False
            End If

        ElseIf PaginaNotificacion = 2 Then
            rellenarNotificaciones(3)
            llblPaginaSiguiente.Visible = False
            PaginaNotificacion = 3

        End If
    End Sub

    'Eventos
    Private Sub btnRealizarunareserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormEnPanel(Of Reservar)(sender)
    End Sub

    Private Sub btnListadereservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormEnPanel(Of ListadeReservas)(sender)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlArriba_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlArriba.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblPerfil_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerfil.MouseEnter
        lblPerfil.Font = New Font("Sans Serif", 11, FontStyle.Underline, GraphicsUnit.Point)
    End Sub

    Private Sub lblPerfil_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPerfil.MouseLeave
        lblPerfil.Font = New Font("Sans Serif", 11, FontStyle.Regular, GraphicsUnit.Point)
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        System.Diagnostics.Process.Start("https://github.com/renzactus/RCM")
    End Sub

    Private Sub btnAyuda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.MouseHover
        Me.ToolTip1.SetToolTip(btnAyuda, "Ante cualquier duda llamar a 091111111")
    End Sub

    

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        AbrirFormEnPanel(Of Reservar)(sender)
        pnlApartadoSeleccionado.Location = New Point(pnlApartadoSeleccionado.Location.X, btnReservar.Location.Y)
    End Sub

    Private Sub btnReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservas.Click
        AbrirFormEnPanel(Of ListadeReservas)(sender)
        pnlApartadoSeleccionado.Location = New Point(pnlApartadoSeleccionado.Location.X, btnReservas.Location.Y)
        ReiniciarListaReservas()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(Of Clientes)(sender)
        pnlApartadoSeleccionado.Location = New Point(pnlApartadoSeleccionado.Location.X, btnClientes.Location.Y)
    End Sub

    Private Sub btnGanancias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGanancias.Click
        AbrirFormEnPanel(Of Ganancias)(sender)
        pnlApartadoSeleccionado.Location = New Point(pnlApartadoSeleccionado.Location.X, btnGanancias.Location.Y)
    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        pnlApartadoSeleccionado.Location = New Point(pnlApartadoSeleccionado.Location.X, btnConfiguracion.Location.Y)
        If pnlConfiguracion.Visible = False Then
            lblDesplegadorNormal.Visible = False
            lblDesplegadorAbajo.BackColor = Color.FromArgb(215, 207, 197)
            pnlConfiguracion.Height = 1
            btnConfiguracion.Enabled = False
            timerMostrarConfiguracion.Enabled = True
            btnConfiguracion.BackColor = Color.FromArgb(215, 207, 197)
            pnlConfiguracion.Visible = True
        Else
            lblDesplegadorNormal.Visible = True
            btnConfiguracion.Enabled = False
            timerOcultarConfiguracion.Enabled = True
            btnConfiguracion.BackColor = Color.FromArgb(239, 231, 220)
        End If
    End Sub
    Private Sub timerMostrarConfiguracion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerMostrarConfiguracion.Tick
        pnlConfiguracion.Height = pnlConfiguracion.Height + 2
        If pnlConfiguracion.Height > 82 Then
            timerMostrarConfiguracion.Enabled = False
            btnConfiguracion.Enabled = True
        End If
    End Sub

    Private Sub timerOcultarConfiguracion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerOcultarConfiguracion.Tick
        pnlConfiguracion.Height = pnlConfiguracion.Height - 2
        If pnlConfiguracion.Height < 3 Then
            timerOcultarConfiguracion.Enabled = False
            pnlConfiguracion.Visible = False
            btnConfiguracion.Enabled = True
        End If
    End Sub

    Private Sub btnCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        AbrirFormEnPanel(Of Costos)(sender)
    End Sub

    Private Sub btnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventario.Click
        AbrirFormEnPanel(Of Inventario)(sender)
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        If MsgBox("¿Seguro que quiere cerrar su sesión?", vbYesNo, "Atención!") = vbYes Then

            Dim login As New Login
            login.Show()
            Me.Dispose()
            Reservar.Dispose()
            ListadeReservas.Dispose()
            Ganancias.Dispose()
            Clientes.Dispose()
            Costos.Dispose()
            Inventario.Dispose()

        Else

        End If
    End Sub

    Private Sub timerMostrarNotificacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerMostrarNotificacion.Tick
        pnlCuadroNotificaciones.Height = pnlCuadroNotificaciones.Height + 9
        If pnlCuadroNotificaciones.Height > 460 Then
            timerMostrarNotificacion.Enabled = False
            btnNotificaciones.Enabled = True
        End If
    End Sub

    Private Sub timerOcultarNotificacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerOcultarNotificacion.Tick
        pnlCuadroNotificaciones.Height = pnlCuadroNotificaciones.Height - 9
        If pnlCuadroNotificaciones.Height < 10 Then
            timerOcultarNotificacion.Enabled = False
            pnlCuadroNotificaciones.Visible = False
            btnNotificaciones.Enabled = True
        End If
    End Sub

End Class
