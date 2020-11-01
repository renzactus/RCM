Imports System.Runtime.InteropServices

Public Class Principal
    Dim mysql As New MySQL
    Dim datosReservasNotificacion As DataTable
    Dim PaginaNotificacion As Integer = 1
    Public colorprincipal As Color = Color.FromArgb(239, 231, 219)
    Public colorsecundario As Color = Color.FromArgb(227, 195, 176)
    Public booleanImprevistoAlmacenado As Boolean

    'Constructor
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = colorprincipal
        pnlArriba.BackColor = Color.FromArgb(colorsecundario.R, colorsecundario.G, colorsecundario.B)
        ActualizarNotificaciones()
    End Sub
    'Notificaciones
    Private Sub MostrarCuadroNotificaciones()
        If pnlCuadroNotificaciones.Visible = False Then
            pnlCuadroNotificaciones.Visible = True
            pnlCuadroNotificaciones.Location = New Point(718, 29)
        Else
            pnlCuadroNotificaciones.Visible = False
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
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo")
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

        ElseIf datosReservasNotificacion.Rows.Count = 2 Or (datosReservasNotificacion.Rows.Count = 5 And pagina = 2) Or (datosReservasNotificacion.Rows.Count = 8 And pagina = 3) Then

            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo")
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

            pnlNotificacion2.Visible = True
            lblNotificacion2Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("motivo")
            lblNotificacion2Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("fecha")
            lblNotificacion2Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("final").ToString

        ElseIf datosReservasNotificacion.Rows.Count > 2 Or (datosReservasNotificacion.Rows.Count = 6 And pagina = 2) Or (datosReservasNotificacion.Rows.Count = 9 And pagina = 3) Then
            pnlNotificacion1.Visible = True
            lblNotificacion1Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("motivo")
            lblNotificacion1Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("fecha")
            lblNotificacion1Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1)).Item("final").ToString

            pnlNotificacion2.Visible = True
            lblNotificacion2Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("motivo")
            lblNotificacion2Fecha.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("fecha")
            lblNotificacion2Hora.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("comienzo").ToString & " - " & datosReservasNotificacion.Rows(3 * (pagina - 1) + 1).Item("final").ToString

            pnlNotificacion3.Visible = True
            lblNotificacion3Motivo.Text = datosReservasNotificacion.Rows(3 * (pagina - 1) + 2).Item("motivo")
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
        Dim configuracion As New Configuracion
        configuracion.Show()
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

    Private Sub btnNotificacion1Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion1Si.Click
        actualizarAReservaSinProblema(1)
    End Sub

    Private Sub btnNotificacion2Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion2Si.Click
        actualizarAReservaSinProblema(2)
    End Sub

    Private Sub btnNotificacion3Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion3Si.Click
        actualizarAReservaSinProblema(3)
    End Sub


    Private Sub btnNotificacion1No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion1No.Click
        actualizarAReservaConImprevisto(1)
    End Sub

    Private Sub btnNotificacion2No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion2No.Click
        actualizarAReservaConImprevisto(2)
    End Sub

    Private Sub btnNotificacion3No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacion3No.Click
        actualizarAReservaConImprevisto(3)
    End Sub





    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox(String.Format("{0:N0}", 10.0))
    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim clientes As New Clientes
        clientes.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ganancias As New Ganancias
        ganancias.Show()
    End Sub
End Class
