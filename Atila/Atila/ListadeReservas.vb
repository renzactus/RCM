Public Class ListadeReservas
    Dim mysql As New MySQL

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PonerEnNegritasDiasConReservas()
        MostrarReservasDelDia()
    End Sub
    'Metodos utilizados
    Private Sub MostrarReservasDelDia()
        lblFechaSeleccionada.Text = Calendario.SelectionRange.Start
        lblNoHayReservas.Visible = True
        llblMotivoReserva1.Visible = False
        llblMotivoReserva2.Visible = False
        llblMotivoReserva3.Visible = False
        lblHora1.Visible = False
        lblHora2.Visible = False
        lblHora3.Visible = False
        mysql.Consultar("select motivo,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and fecha_cancelacion is null")
        If mysql.Consultado = True Then
            If mysql.Resultado.Rows.Count() = 1 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                lblHora1.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
            ElseIf mysql.Resultado.Rows.Count() = 2 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                llblMotivoReserva2.Visible = True
                lblHora1.Visible = True
                lblHora2.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                llblMotivoReserva2.Text = mysql.Resultado.Rows(1).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
                lblHora1.Text = mysql.Resultado.Rows(1).Item("comienzo") & "-" & mysql.Resultado.Rows(1).Item("final")
            ElseIf mysql.Resultado.Rows.Count() = 3 Then
                lblNoHayReservas.Visible = False
                llblMotivoReserva1.Visible = True
                llblMotivoReserva2.Visible = True
                llblMotivoReserva3.Visible = True
                lblHora1.Visible = True
                lblHora2.Visible = True
                lblHora3.Visible = True
                llblMotivoReserva1.Text = mysql.Resultado.Rows(0).Item("motivo")
                llblMotivoReserva2.Text = mysql.Resultado.Rows(1).Item("motivo")
                llblMotivoReserva3.Text = mysql.Resultado.Rows(2).Item("motivo")
                lblHora1.Text = mysql.Resultado.Rows(0).Item("comienzo") & "-" & mysql.Resultado.Rows(0).Item("final")
                lblHora2.Text = mysql.Resultado.Rows(1).Item("comienzo") & "-" & mysql.Resultado.Rows(1).Item("final")
                lblHora3.Text = mysql.Resultado.Rows(2).Item("comienzo") & "-" & mysql.Resultado.Rows(2).Item("final")
            End If
        End If
    End Sub
    Private Sub PonerEnNegritasDiasConReservas()
        mysql.Consultar("select distinct fecha from reservas where fecha_cancelacion is null")
        If mysql.Consultado = True Then
            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
        End If
    End Sub

    Private Sub MostrarDatosDeReserva()
        ConsultarDatosDeReservaConSuCliente()
        If mysql.Consultado = True Then
            If mysql.Resultado.Rows.Count <> 0 Then


                lblMostrarMotivo.Text = mysql.Resultado.Rows(0).Item("motivo")
                lblMostrarFecha.Text = mysql.Resultado.Rows(0).Item("fecha")
                lblMostrarHora.Text = mysql.Resultado.Rows(0).Item("comienzo").ToString & " - " & mysql.Resultado.Rows(0).Item("final").ToString
                lblMostrarPersonas.Text = mysql.Resultado.Rows(0).Item("cantidad_personas")
                lblMostrarServicio.Text = mysql.Resultado.Rows(0).Item("servicio")
                lblMostrarCliente.Text = mysql.Resultado.Rows(0).Item("nombre")
                If Not IsDBNull(mysql.Resultado.Rows(0).Item("s")) Then
                    lblMostrarSeña.Text = mysql.Resultado.Rows(0).Item("s")
                End If


            End If
        End If
    End Sub
    Private Sub ConsultarDatosDeReservaConSuCliente()
        mysql.Consultar("select motivo,fecha,comienzo,final,cantidad_personas,servicio,nombre,seña as s from reservas inner join " &
                        "clientes on reservas.id_cliente=clientes.id_cliente where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "'")
    End Sub


    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        MostrarReservasDelDia()
        MostrarDatosDeReserva()
    End Sub


    Private Sub cboFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class