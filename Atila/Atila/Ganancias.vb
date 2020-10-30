Imports System.Windows.Forms.DataVisualization.Charting

Public Class Ganancias
    Dim mysql As New MySQL
    Dim ReservasAñoAnterior As String
    Dim ReservasAñoSeleccionado As String
    Private Sub Ganancias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAño.SelectedIndex = 0
    End Sub
    'Mostrar Reservas en el año grafica
    Private Sub actualizarGraficaReservasAnuales()
        
        Grafica.ChartAreas(0).AxisX.LabelStyle.Angle = 45
        Grafica.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 12)

        'Serie Año seleccionado 
        ReservasAñoSeleccionado = cboAño.Text
        Grafica.Series.Add(ReservasAñoSeleccionado)
        Grafica.Series(ReservasAñoSeleccionado).Color = Color.Maroon

        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Enero", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 1).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Febrero", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 2).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Marzo", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 3).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Abril", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 4).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Mayo", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 5).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Junio", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 6).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Julio", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 7).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Agosto", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 8).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Septiembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 9).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Octubre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 10).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Noviembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 11).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoSeleccionado).Points.AddXY("Diciembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoSeleccionado &
                                                                           " and month(fecha)=" & 12).rows(0).item("count(*)"))
        'Serie un año anterior
        ReservasAñoAnterior = cboAño.Text - 1
        Grafica.Series.Add(ReservasAñoAnterior)
        Grafica.Series(ReservasAñoAnterior).Color = Color.Blue


        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Enero", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 1).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Febrero", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 2).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Marzo", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 3).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Abril", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 4).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Mayo", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 5).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Junio", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 6).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Julio", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 7).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Agosto", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 8).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Septiembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 9).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Octubre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 10).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Noviembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 11).rows(0).item("count(*)"))
        Grafica.Series(ReservasAñoAnterior).Points.AddXY("Diciembre", mysql.Consultar("select count(*) from reservas where year(fecha)=" & ReservasAñoAnterior &
                                                                           " and month(fecha)=" & 12).rows(0).item("count(*)"))


    End Sub

    'Eventos
    Private Sub cboAño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAño.SelectedIndexChanged
        actualizarGraficaReservasAnuales()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnAlternar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlternar.Click
        If Grafica.Series(ReservasAñoAnterior).ChartType = SeriesChartType.Column Then
            Grafica.Series(ReservasAñoAnterior).ChartType = SeriesChartType.StackedArea
            Grafica.Series(ReservasAñoSeleccionado).ChartType = SeriesChartType.StackedArea
        Else
            Grafica.Series(ReservasAñoAnterior).ChartType = SeriesChartType.Column
            Grafica.Series(ReservasAñoSeleccionado).ChartType = SeriesChartType.Column
        End If
        
    End Sub
End Class