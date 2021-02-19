Imports System.Web.UI.DataVisualization.Charting
Imports System.Drawing
Public Class _3D
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
        Dim yValues As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}

        chart.Width = 700
        chart.Height = 500

        Dim title As New Title()
        title.Text = "3D 效果"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        chart.Titles.Add(title)

        chart.ChartAreas.Add("chartAreas")
        chart.Series.Add("series")
        chart.Legends.Add("legends")
        chart.Series("series").Points.DataBindXY(xValues, yValues)

        ' 基本設定
        chart.ChartAreas("chartAreas").AxisX.Interval = 1
        chart.ChartAreas("chartAreas").AxisY.Interval = 10
        chart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        chart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5
        chart.ChartAreas("chartAreas").AxisX.Title = "日期"
        chart.ChartAreas("chartAreas").AxisY.Title = "數量"
        chart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        chart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        chart.Series("series").IsValueShownAsLabel = True
        chart.Series("series").XValueType = ChartValueType.String
        chart.Series("series").YValueType = ChartValueType.Int32
        chart.Series("series").LegendText = "隨便一根柱"

        ' 3D 相關設定
        chart.ChartAreas("chartAreas").Area3DStyle.Enable3D = True
        chart.ChartAreas("chartAreas").Area3DStyle.Rotation = 10
        chart.ChartAreas("chartAreas").Area3DStyle.Inclination = 10
        chart.ChartAreas("chartAreas").Area3DStyle.PointDepth = 100
        chart.ChartAreas("chartAreas").Area3DStyle.PointGapDepth = 1000
        chart.ChartAreas("chartAreas").Area3DStyle.WallWidth = 30
        chart.ChartAreas("chartAreas").Area3DStyle.Perspective = 50
    End Sub

End Class