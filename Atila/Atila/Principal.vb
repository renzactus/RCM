Public Class Principal

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
End Class
