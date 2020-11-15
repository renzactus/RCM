Public Class Costos
    Dim mysql As New MySQL
    Dim datosCostos As DataTable

    'Constructor
    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstablecerColores()
        actualizarCostos()
    End Sub
    'Diseño
    Private Sub EstablecerColores()
        Me.BackColor = Principal.colorSecundario
        lblMostrarCostos.ForeColor = Principal.colorTitulos
        lblIngresarCostos.ForeColor = Principal.colorTitulos
        btnAgregar.ForeColor = Principal.colorTitulos
    End Sub
    'Mostrar Datos
    Private Sub actualizarCostos()
        consultarCostos()
        rellenarcboCostos()
    End Sub
    Private Sub consultarCostos()
        datosCostos = mysql.Consultar("select * from costos order by fecha_actualizacion desc")
    End Sub
    Private Sub rellenarcboCostos()
        cboCostos.Items.Clear()
        For i = 0 To datosCostos.Rows.Count - 1
            If i = 0 Then
                cboCostos.Items.Add(datosCostos.Rows(i).Item("fecha_actualizacion") & " (Actual)")
            Else
                cboCostos.Items.Add(datosCostos.Rows(i).Item("fecha_actualizacion"))
            End If
        Next
        cboCostos.SelectedIndex = 0
    End Sub
    Private Sub rellenarDatos()
        txtPorcentajeExtraFinde.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("porcentaje_findesemana")
        txtPrecioPorPersona.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("c_precio_por_persona")

        txtFiestaConBaile.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("c_fiesta_con_baile")
        txtFiestaSinBaile.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("c_fiesta_sin_baile")
        txtParrillada.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("c_parrillada")

        txtHasta2Cuotas.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("hasta_2cuotas")
        txtEntre4Y12Cuotas.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("entre_4_y_12cuotas")

        txtIva.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("iva")
        txtAgadu.Text = datosCostos.Rows(cboCostos.SelectedIndex).Item("agadu")
    End Sub
    'Agregar Datos
    Private Sub chequearAntesDeAgregar()
        If txtAgregarPorcentajeExtraFinde.Text = "" Or txtAgregarPrecioPorPersona.Text = "" Or txtAgregarFiestaConBaile.Text = "" Or txtAgregarFiestaSinBaile.Text = "" Or
            txtAgregarParrillada.Text = "" Or txtAgregarHasta2Cuotas.Text = "" Or txtAgregarEntre4Y12Cuotas.Text = "" Or txtAgregarIva.Text = "" Or txtAgregarAgadu.Text = "" Then
            avisarSiEstaVacio(txtAgregarPorcentajeExtraFinde)
            avisarSiEstaVacio(txtAgregarPrecioPorPersona)
            avisarSiEstaVacio(txtAgregarFiestaConBaile)
            avisarSiEstaVacio(txtAgregarFiestaSinBaile)
            avisarSiEstaVacio(txtAgregarParrillada)
            avisarSiEstaVacio(txtAgregarHasta2Cuotas)
            avisarSiEstaVacio(txtAgregarEntre4Y12Cuotas)
            avisarSiEstaVacio(txtAgregarIva)
            avisarSiEstaVacio(txtAgregarAgadu)
            Reservar.sonidoError()
        Else
            insertarDatos()
        End If
    End Sub
    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    Private Sub insertarDatos()
        mysql.InsertarDatos("insert into costos(fecha_actualizacion,porcentaje_findesemana,c_precio_por_persona,c_fiesta_con_baile," &
                            "c_fiesta_sin_baile,c_parrillada,hasta_2cuotas,entre_4_y_12cuotas,iva,agadu) values(current_timestamp," &
                            txtAgregarPorcentajeExtraFinde.Text & "," & txtAgregarPrecioPorPersona.Text & "," & txtAgregarFiestaConBaile.Text &
                            "," & txtAgregarFiestaSinBaile.Text & "," & txtAgregarParrillada.Text & ",'" & txtAgregarHasta2Cuotas.Text.Replace(",", ".") & "','" &
                            txtAgregarEntre4Y12Cuotas.Text.Replace(",", ".") & "','" & txtAgregarIva.Text.Replace(",", ".") & "','" & txtAgregarAgadu.Text.Replace(",", ".") & "')")
        If mysql.Consultado = True Then
            actualizarCostos()
            MsgBox("Costos actualzados correctamente!")
        End If
    End Sub
    'Eventos
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        chequearAntesDeAgregar()
    End Sub

    Private Sub txtAgregarPorcentajeExtraFinde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        epError.SetError(sender, "")
    End Sub

    Private Sub txtAgregarPorcentajeExtraFinde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub txtAgregarHasta2Cuotas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub cboCostos_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCostos.SelectedIndexChanged
        rellenarDatos()
    End Sub

    Private Sub txtAgregarPorcentajeExtraFinde_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAgregarPrecioPorPersona.KeyPress, txtAgregarPorcentajeExtraFinde.KeyPress, txtAgregarParrillada.KeyPress, txtAgregarIva.KeyPress, txtAgregarHasta2Cuotas.KeyPress, txtAgregarFiestaSinBaile.KeyPress, txtAgregarFiestaConBaile.KeyPress, txtAgregarEntre4Y12Cuotas.KeyPress, txtAgregarAgadu.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'SOLO DEJA ESCRIBIR NUMEROS Y BORRAR 
    End Sub

    Private Sub btnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        chequearAntesDeAgregar()
    End Sub
End Class