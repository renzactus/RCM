Public Class Reservar
    Dim booleanTelefonos As Boolean
    Dim mysql As New MySQL
    Dim telefonos As String
    Private Sub MostrarReservasDelDia()
        lblFecha.Text = Calendario.SelectionRange.Start
        lblNoHayReservas.Visible = True
        llblMotivoReserva1.Visible = False
        llblMotivoReserva2.Visible = False
        llblMotivoReserva3.Visible = False
        lblHora1.Visible = False
        lblHora2.Visible = False
        lblHora3.Visible = False
        mysql.Consultar("select motivo,time_format(comienzo,'%H:%i') as comienzo,time_format(final,'%H:%i') as final from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "';")
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

    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(191, 128, 130)
        Calendario.MinDate = DateAndTime.Today
        Calendario.MaxDate = DateAdd("yyyy", 3, DateAndTime.Today)
        mysql.Consultar("select distinct fecha from reservas")
        If mysql.Consultado = True Then
            For i = 0 To mysql.Resultado.Rows.Count - 1
                Calendario.AddBoldedDate(mysql.Resultado.Rows(i).Item("fecha"))
            Next
            Calendario.UpdateBoldedDates()
            MostrarReservasDelDia()
        End If
    End Sub

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        If txtTelefono2.Text <> "" Then
            telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            telefonos = txtTelefono1.Text
        End If
        mysql.InsertarDatos("insert into clientes (cedula,nombre,telefonos,direccion) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" &
            telefonos & "','" & txtDireccion.Text & "')") 'Agregamos los clientes
        mysql.InsertarDatos("insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE) values ('" &
            cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dudHoraComienzo.Text & "','" & dudHoraFinal.Text & "'," &
            dudCantidadPersonas.Text & "," & chkServicio.CheckState & ",(select ID_CLIENTE from clientes where nombre='" & txtNombre.Text & "'))") 'Agregamos las reservas
    End Sub

    Private Sub btnAgregarTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTelefonos.Click
        'PARA PONER VISIBLE EL txtTelefonos2 Y MOVER DE LUGAR txtDireccion y lblDireccion
        If booleanTelefonos = False Then
            txtTelefono2.Visible = True
            btnAgregarTelefonos.Text = "-"
            booleanTelefonos = True
            txtDireccion.Location = New Point(txtDireccion.Location.X, txtDireccion.Location.Y + 27)
            lblDireccion.Location = New Point(lblDireccion.Location.X, lblDireccion.Location.Y + 27)
        ElseIf booleanTelefonos = True Then
            txtTelefono2.Visible = False
            btnAgregarTelefonos.Text = "+"
            txtTelefono2.Text = ""
            booleanTelefonos = False
            txtDireccion.Location = New Point(txtDireccion.Location.X, txtDireccion.Location.Y - 27)
            lblDireccion.Location = New Point(lblDireccion.Location.X, lblDireccion.Location.Y - 27)
        End If


    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        'Devuelve la id_reserva si la hora en esa fecha esta ocupada
        mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "';")

        If mysql.Consultado = True Then
            If mysql.Resultado.Rows.Count() > 2 Then 'SI SE DEVOLVIERON 3 FILAS O MAS QUIERE DECIR QUE SE SUPERO EL MAXIMO DE RESERVAS EN UN DIA
                MsgBox("Se supero el maximo de reservas en un día")
            Else
                mysql.Consultar("select id_reserva from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "' and (('" &
            dudHoraComienzo.Text & "'<addtime(final,'1:00:00') and '" & dudHoraComienzo.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
            dudHoraFinal.Text & "'<addtime(final,'1:00:00') and '" & dudHoraFinal.Text & "'>addtime(comienzo,'-1:00:00')) or ('" &
            dudHoraComienzo.Text & "'<addtime(comienzo,'-1:00:00') and '" & dudHoraFinal.Text & "'>addtime(final,'1:00:00')));")
                If mysql.Consultado = True Then
                    If mysql.Resultado.Rows.Count() > 0 Then 'SI SE DEVOLVIO MAS DE UNA FILA QUIERE DECIR QUE YA HAY RESERVA PARA ESA FECHA y hora
                        MessageBox.Show("Horario Ocupado")
                    ElseIf dudHoraComienzo.Text = "" Or dudHoraFinal.Text = "" Or cboMotivo.Text = "Ingresar Motivo" Or dudCantidadPersonas.Text = "" Then
                        MsgBox("Campos Sin completar")
                    Else 'SI TODO LO DEMAS ESTA CORRECTO
                        pnlReserva.Visible = False
                        pnlCliente.Visible = True
                    End If
                End If
            End If
            End If
        
    End Sub

    Private Sub dudHoraComienz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudHoraComienzo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES
    End Sub

    Private Sub dudHoraFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudHoraFinal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS, BORRAR Y ESCRIBIR PUNTUACIONES
    End Sub

    Private Sub dudCantidadPersonas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dudCantidadPersonas.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Date
        a = "18:00"
        MsgBox(Format(a, "HH:mm"))
    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged

        MostrarReservasDelDia()
    End Sub
End Class