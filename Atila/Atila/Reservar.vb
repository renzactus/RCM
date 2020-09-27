Public Class Reservar
    Dim booleanTelefonos As Boolean
    Dim mysql As New MySQL
    Dim telefonos As String
    Private Sub Reservar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'CONSTRUCTOR

    End Sub

    Private Sub botonAgregarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDatos.Click
        If txtTelefono2.Text <> "" Then
            telefonos = txtTelefono1.Text & "|" & txtTelefono2.Text
        Else
            telefonos = txtTelefono1.Text
        End If
        mysql.Consulta = "insert into clientes (cedula,nombre,telefonos,direccion) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" & telefonos & "','" & txtDireccion.Text & "')"
        mysql.InsertarDatos()
        mysql.Consulta = "insert into reservas (motivo,fecha,comienzo,final,cantidad_personas,servicio,ID_CLIENTE) values ('" &
            cboMotivo.Text & "','" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "','" & dudHoraComienzo.Text & "','" & dudHoraFinal.Text & "'," &
            dudCantidadPersonas.Text & "," & chkServicio.CheckState & ",(select ID_CLIENTE from clientes where nombre='" & txtNombre.Text & "'))"
        mysql.InsertarDatos()
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
        
        mysql.Consulta = "select ID_RESERVA from reservas where fecha='" & Format(Calendario.SelectionRange.Start, "yyyy-MM-dd") & "'and '" & dudHoraComienzo.Text & "'<addtime(final,'1:00:00') and fecha_cancelacion is null;"
        mysql.Consultar() 'ENVIAR CONSULTA
        If mysql.Consultado = True Then 'SI SE CONSULTO SIN ERRORES
            If mysql.Data.Rows.Count() > 0 Then 'SI SE DEVOLVIO MAS DE UNA FILA QUIERE DECIR QUE YA HAY RESERVA PARA ESA FECHA
                MessageBox.Show("Dia Ocupado")
            Else
                pnlReserva.Visible = False
                pnlCliente.Visible = True
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
End Class