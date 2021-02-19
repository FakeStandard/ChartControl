Imports System.Web.UI.DataVisualization.Charting
Imports System.Drawing
Public Class DoubleSequence
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = True Then
            Return
        End If

        Bind()
    End Sub

    Sub Bind()
        ' 建立 x,y 軸資料
        Dim xValues As String() = {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"}
        Dim y1Values As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}
        Dim y2Values As Integer() = {33, 14, 19, 40, 27, 53, 77, 8, 23, 17, 61, 37}

        chart.Width = 700
        chart.Height = 500

        Dim title As New Title()
        title.Text = "雙數列"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        chart.Titles.Add(title)

        chart.ChartAreas.Add("chartAreas")
        chart.Series.Add("series1")
        chart.Series.Add("series2")
        chart.Legends.Add("legends")
        chart.Series("series1").Points.DataBindXY(xValues, y1Values)
        chart.Series("series2").Points.DataBindXY(xValues, y2Values)

        ' 基本設定
        chart.ChartAreas("chartAreas").AxisX.Interval = 1
        chart.ChartAreas("chartAreas").AxisY.Interval = 10
        chart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        chart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5
        chart.ChartAreas("chartAreas").AxisX.Title = "日期"
        chart.ChartAreas("chartAreas").AxisY.Title = "數量"
        chart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        chart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        chart.Series("series1").IsValueShownAsLabel = True
        chart.Series("series1").XValueType = ChartValueType.String
        chart.Series("series1").YValueType = ChartValueType.Int32
        chart.Series("series1").LegendText = "第一根柱"

        chart.Series("series2").IsValueShownAsLabel = True
        chart.Series("series2").XValueType = ChartValueType.String
        chart.Series("series2").YValueType = ChartValueType.Int32
        chart.Series("series2").LegendText = "第二根柱"
    End Sub

End Class