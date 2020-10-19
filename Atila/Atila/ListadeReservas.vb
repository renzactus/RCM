Public Class ListadeReservas
    Dim mysql As New MySQL

    Private Sub ListadeReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PonerEnNegritasDiasConReservas()
        MostrarReservasDelDia()
    End Sub
    'Metodos utilizados
    Private Sub MostrarReservasDelDia()
        lblFecha.Text = Calendario.SelectionRange.Start
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

    Private Sub VaciarLista()

    End Sub
    Private Sub ListarReservasDelMesSeleccionado()

        mysql.Consultar("select month(fecha) as mes,year(fecha) as year,motivo,cantidad_personas,id_cliente from reservas where month(fecha)=" & cboMes.SelectedIndex + 1 & " and fecha_cancelacion is null")
        For i = 0 To mysql.Resultado.Rows.Count - 1
            dgvFiltrarReservas.Rows.Add(mysql.Resultado.Rows(i).Item("mes") & "/" & mysql.Resultado.Rows(i).Item("year"), mysql.Resultado.Rows(i).Item("motivo"), mysql.Resultado.Rows(i).Item("cantidad_personas"))
        Next
    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        MostrarReservasDelDia()
    End Sub

    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        VaciarLista()
        ListarReservasDelMesSeleccionado()
    End Sub

    Private Sub cboFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFiltrarPor.SelectedIndexChanged
        If cboFiltrarPor.Text = "Mes" Then
            cboMes.SelectedIndex = DateAndTime.Now.Month - 1
            cboMes.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(cboMes.SelectedIndex + 1)
    End Sub
End Class