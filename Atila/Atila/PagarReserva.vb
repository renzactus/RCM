Public Class PagarReserva
    Dim mysql As New MySQL
    Dim modopago As String
    Dim listadereservas As New ListadeReservas
    Public dtosReserva As DataTable
    Public ptotal As Integer
    Private Sub avisarSiEstaVacio(ByVal componente As Object)
        If componente.Text = "" Then
            epError.SetError(componente, "Porfavor, Complete los datos de " & componente.Name.Substring(3))
        Else
            epError.SetError(componente, "")
        End If
    End Sub
    Private Sub ChequearSiHayCamposVaciosYProceder()
        chequearQueNroReciboSeaUnico()
        If txtNroRecibo.Text = "" Or cboCuotas.SelectedIndex = -1 Then
            avisarSiEstaVacio(txtNroRecibo)
            avisarSiEstaVacio(cboCuotas)
            Reservar.sonidoError()
        ElseIf listadereservas.booleanNroReciboUnico = False Then
            epError.SetError(txtNroRecibo, "Ya existe un numero de recibo igual, ingrese otro")
            Reservar.sonidoError()
        ElseIf rboEfectivo.Checked = False And rboTarjeta.Checked = False Then
            epError.SetError(rboEfectivo, "Marque alguna de las dos opciones")
            epError.SetError(rboTarjeta, "Marque alguna de las dos opciones")
        Else
            insertarPago()
        End If
    End Sub
    Private Sub chequearQueNroReciboSeaUnico()
        If txtNroRecibo.Text <> "" Then
            listadereservas.booleanNroReciboUnico = True
            mysql.Consultar("select nro_recibo from pagos")
            If mysql.Consultado = True Then
                For i = 0 To mysql.Resultado.Rows.Count - 1
                    If mysql.Resultado.Rows(i).Item("nro_recibo") = txtNroRecibo.Text Then
                        listadereservas.booleanNroReciboUnico = False
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub insertarPago()
        If cboCuotas.Text = "Ninguna" Then
            listadereservas.cuotas = 1
        Else
            listadereservas.cuotas = cboCuotas.Text
        End If
        If rboEfectivo.Checked = True Then
            modopago = "Efectivo"
        ElseIf rboTarjeta.Checked = True Then
            modopago = "Tarjeta"
        End If

        mysql.InsertarDatos("insert into pagos (NRO_RECIBO,cuotas,fecha_pago,costo,forma,ID_RESERVA) values(" & txtNroRecibo.Text & "," & listadereservas.cuotas & ",current_date," &
                           ptotal + dtosReserva.Rows(listadereservas.FilaNumero).Item("s") & ",'" & modopago & "'," & dtosReserva.Rows(listadereservas.FilaNumero).Item("ID_RESERVA") & ")")
        If mysql.Consultado = True Then
            Principal.Enabled = True
            Me.Close()
            MsgBox("Pagado Correctamente")
            Principal.ReiniciarListaReservas()
        End If
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Principal.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        ChequearSiHayCamposVaciosYProceder()
    End Sub

    Private Sub rboEfectivo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles rboEfectivo.Validating
        epError.SetError(rboEfectivo, "")
    End Sub

    Private Sub rboTarjeta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles rboTarjeta.Validating
        epError.SetError(rboTarjeta, "")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(listadereservas.FilaNumero)
    End Sub
End Class