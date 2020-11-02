Imports System.Windows.Forms.DataVisualization.Charting

Public Class Ganancias
    Dim mysql As New MySQL
    Dim booleanNoPrimeraActMensual As Boolean
    Dim ReservasoGananciasAñoAnterior, ReservasoGananciasAñoSeleccionado As String 'Año
    Private Sub Ganancias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarAñosConReserva()
        crearSeriesParaAnual()
        crearSeriesParaMeses()
        Grafica.ChartAreas(0).AxisX.LabelStyle.Angle = 25
        Grafica.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 11)
    End Sub
    'Otro
    Private Sub actualizarAñosConReserva()
        mysql.Consultar("select distinct year(fecha) from reservas")
        For i = 0 To mysql.Resultado.Rows.Count - 1
            cboAño.Items.Add(mysql.Resultado.Rows(i).Item("year(fecha)"))

        Next
    End Sub
    Private Sub crearSeriesParaAnual()
        ReservasoGananciasAñoAnterior = "x1"
        ReservasoGananciasAñoSeleccionado = "x2"
        Grafica.Series.Add(ReservasoGananciasAñoSeleccionado)
        Grafica.Series.Add(ReservasoGananciasAñoAnterior)
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Color = Color.Maroon
        Grafica.Series(ReservasoGananciasAñoAnterior).Color = Color.Blue
    End Sub
    Private Sub crearSeriesParaMeses()
        For i = 1 To 12
                Grafica.Series.Add("xm" & i)
            Grafica.Series("xm" & i).Color = Color.Cyan
            Grafica.Series("xm" & i).IsVisibleInLegend = False
            Grafica.Series("xm" & i).ToolTip = MonthName(i)
        Next
    End Sub
    Private Sub vaciarGraficayMas()
        lblTotal.Visible = False
        lblMostrarTotal.Visible = False
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.Clear()
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.Clear()
        For i = 1 To 12
            Grafica.Series("xm" & i).Points.Clear()
        Next
    End Sub
    'Grafica Anual
    Private Sub actualizarGraficaAnual()

        vaciarGraficayMas()
        Grafica.Series(ReservasoGananciasAñoAnterior).Name = "x1"
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Name = "x2"
        ReservasoGananciasAñoAnterior = "x1"
        ReservasoGananciasAñoSeleccionado = "x2"
        'Actualizar Total
        lblTotal.Visible = True
        lblMostrarTotal.Visible = True
        If cboSeleccionar.SelectedIndex = 0 Then
            lblMostrarTotal.Text = mysql.Consultar("select count(*) from reservas where year(fecha)=" & cboAño.Text & " and fecha_cancelacion is null").
                rows(0).item("count(*)")
        ElseIf cboSeleccionar.SelectedIndex = 3 Then
            mysql.Consultar("select sum(costo) from pagos inner join reservas on reservas.ID_RESERVA=pagos.ID_RESERVA where year(fecha)=" & cboAño.Text &
                            " and fecha_cancelacion is null").rows(0).item("sum(costo)")
            If IsDBNull(mysql.Resultado.Rows(0).Item("sum(costo)")) Then
                lblMostrarTotal.Text = 0
            Else
                lblMostrarTotal.Text = mysql.Resultado.Rows(0).Item("sum(costo)")
            End If
        End If

        'Serie Año seleccionado 

        Grafica.Series(ReservasoGananciasAñoSeleccionado).Name = cboAño.Text
        ReservasoGananciasAñoSeleccionado = cboAño.Text

        Grafica.Series(ReservasoGananciasAñoSeleccionado).ToolTip = ReservasoGananciasAñoSeleccionado
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Enero", cantidadAnual(1, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Febrero", cantidadAnual(2, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Marzo", cantidadAnual(3, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Abril", cantidadAnual(4, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Mayo", cantidadAnual(5, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Junio", cantidadAnual(6, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Julio", cantidadAnual(7, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Agosto", cantidadAnual(8, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Septiembre", cantidadAnual(9, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Octubre", cantidadAnual(10, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Noviembre", cantidadAnual(11, ReservasoGananciasAñoSeleccionado))
        Grafica.Series(ReservasoGananciasAñoSeleccionado).Points.AddXY("Diciembre", cantidadAnual(12, ReservasoGananciasAñoSeleccionado))
        'Serie un año anterior
        Grafica.Series(ReservasoGananciasAñoAnterior).Name = cboAño.Text - 1
        ReservasoGananciasAñoAnterior = cboAño.Text - 1

        Grafica.Series(ReservasoGananciasAñoAnterior).ToolTip = ReservasoGananciasAñoAnterior
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Enero", cantidadAnual(1, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Febrero", cantidadAnual(2, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Marzo", cantidadAnual(3, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Abril", cantidadAnual(4, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Mayo", cantidadAnual(5, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Junio", cantidadAnual(6, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Julio", cantidadAnual(7, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Agosto", cantidadAnual(8, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Septiembre", cantidadAnual(9, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Octubre", cantidadAnual(10, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Noviembre", cantidadAnual(11, ReservasoGananciasAñoAnterior))
        Grafica.Series(ReservasoGananciasAñoAnterior).Points.AddXY("Diciembre", cantidadAnual(12, ReservasoGananciasAñoAnterior))


    End Sub
    Private Function cantidadAnual(ByVal mes As Integer, ByVal año As String)
        Dim resultado As Integer = 0
        If cboSeleccionar.SelectedIndex = 0 Then
            mysql.Consultar("select count(*) from reservas where year(fecha)=" & año & " and month(fecha)=" & mes & " and fecha_cancelacion is null")
            resultado = mysql.Resultado.Rows(0).Item("count(*)")
        ElseIf cboSeleccionar.SelectedIndex = 3 Then
            mysql.Consultar("select sum(costo) from pagos inner join reservas on reservas.ID_RESERVA=pagos.ID_RESERVA where year(fecha)=" & año & " and month(fecha)=" & mes & " and fecha_cancelacion is null")
            If IsDBNull(mysql.Resultado.Rows(0).Item("sum(costo)")) Then
                resultado = 0
            Else
                resultado = mysql.Resultado.Rows(0).Item("sum(costo)")
            End If
        End If
        Return resultado
    End Function
    'Grafica Mensual
    Private Sub actualizarGraficaMensual()

        vaciarGraficayMas()
        lblTotal.Visible = True
        lblMostrarTotal.Visible = True

        If cboSeleccionar.SelectedIndex = 2 Then
            lblMostrarTotal.Text = String.Format("{0:N0}", mysql.Consultar("select count(*) from reservas where year(fecha)=" & cboAño.Text & " and month(fecha)=" & cboMes.SelectedIndex + 1 & " and fecha_cancelacion is null").
                rows(0).item("count(*)"))
        ElseIf cboSeleccionar.SelectedIndex = 1 Then
            mysql.Consultar("select sum(costo) from pagos inner join reservas on reservas.ID_RESERVA=pagos.ID_RESERVA where year(fecha)=" &
                                                   cboAño.Text & " and month(fecha)=" & cboMes.SelectedIndex + 1 & " and fecha_cancelacion is null").rows(0).item("sum(costo)")
            If IsDBNull(mysql.Resultado.Rows(0).Item("sum(costo)")) Then
                lblMostrarTotal.Text = 0
            Else
                lblMostrarTotal.Text = String.Format("{0:N0}", mysql.Resultado(0).Item("sum(costo)"))
            End If
            
        End If


        'Agregando Puntos
        For i = 1 To 31
            Grafica.Series("xm" & cboMes.SelectedIndex + 1).Points.AddXY(i.ToString, cantidadMensual(cboAño.Text, cboMes.SelectedIndex + 1, i))
        Next


    End Sub
    Private Function cantidadMensual(ByVal año As Integer, ByVal mes As String, ByVal dia As Integer)
        Dim resultado As Integer = 0
        If cboSeleccionar.SelectedIndex = 2 Then
            mysql.Consultar("select count(*) from reservas where year(fecha)=" & año & " and month(fecha)=" & mes & " and day(fecha)=" & dia)
            resultado = mysql.Resultado.Rows(0).Item("count(*)")
        ElseIf cboSeleccionar.SelectedIndex = 1 Then
            mysql.Consultar("select sum(costo) from pagos inner join reservas on reservas.ID_RESERVA=pagos.ID_RESERVA where year(fecha)=" & año & " and month(fecha)=" & mes & " and day(fecha)=" & dia)
            If IsDBNull(mysql.Resultado.Rows(0).Item("sum(costo)")) Then
                resultado = 0
            Else
                resultado = mysql.Resultado.Rows(0).Item("sum(costo)")
            End If
        End If
        Return resultado
    End Function

    'Eventos


    Private Sub btnAlternar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlternar.Click
        If Grafica.Series(ReservasoGananciasAñoAnterior).ChartType = SeriesChartType.Column Then
            Grafica.Series(ReservasoGananciasAñoAnterior).ChartType = SeriesChartType.SplineArea
            Grafica.Series(ReservasoGananciasAñoSeleccionado).ChartType = SeriesChartType.SplineArea
            For i = 1 To 12
                Grafica.Series("xm" & i).ChartType = SeriesChartType.SplineArea
            Next
        Else
            Grafica.Series(ReservasoGananciasAñoAnterior).ChartType = SeriesChartType.Column
            Grafica.Series(ReservasoGananciasAñoSeleccionado).ChartType = SeriesChartType.Column
            For i = 1 To 12
                Grafica.Series("xm" & i).ChartType = SeriesChartType.Column
            Next
        End If

    End Sub

    Private Sub cboSeleccionar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeleccionar.SelectedIndexChanged
        cboMes.SelectedIndex = -1
        cboMes.Enabled = False
        If cboAño.SelectedIndex <> -1 Then
            cboAño.SelectedIndex = -1
        End If

        If cboSeleccionar.SelectedIndex = 0 Or cboSeleccionar.SelectedIndex = 3 Then
            cboMes.Visible = False
            lblMes.Visible = False

            lblAño.Visible = True
            cboAño.Visible = True
        ElseIf cboSeleccionar.SelectedIndex = 1 Or cboSeleccionar.SelectedIndex = 2 Then
            cboMes.Visible = True
            lblMes.Visible = True

            lblAño.Visible = True
            cboAño.Visible = True
            cboAño.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboAño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAño.SelectedIndexChanged
        If cboAño.SelectedIndex <> -1 And (cboSeleccionar.SelectedIndex <> 1 And cboSeleccionar.SelectedIndex <> 2) Then
            actualizarGraficaAnual()
        Else
            vaciarGraficayMas()
        End If
        If cboSeleccionar.SelectedIndex = 1 Or cboSeleccionar.SelectedIndex = 2 Then

            If cboAño.SelectedIndex <> -1 Then
                cboMes.Enabled = True
            End If
            If cboMes.SelectedIndex <> -1 Then
                actualizarGraficaMensual()
            End If
        End If
    End Sub

    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If cboMes.SelectedIndex <> -1 Then
            actualizarGraficaMensual()
        End If
    End Sub

End Class