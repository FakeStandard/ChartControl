Imports System.Web.UI.DataVisualization.Charting
Imports System.Drawing

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = True Then
            Return
        End If

        SimpleBind()

    End Sub
    Sub SimpleBind()
        ' 建立 x,y 軸資料
        Dim xValues As String() = {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"}
        Dim yValues As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}

        chart.Width = 700
        chart.Height = 500

        Dim title As New Title()
        title.Text = "預設為長條圖"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        chart.Titles.Add(title)

        chart.ChartAreas.Add("chartAreas")
        chart.Series.Add("series")
        chart.Legends.Add("legends")
        chart.Series("series").Points.DataBindXY(xValues, yValues)

        ' ChartAreas
        chart.ChartAreas("chartAreas").AxisX.MajorGrid.Enabled = False
        chart.ChartAreas("chartAreas").AxisY.MajorGrid.Enabled = True

        chart.ChartAreas("chartAreas").BackColor = Color.LawnGreen

        chart.ChartAreas("chartAreas").AxisX.MajorGrid.LineColor = Color.Empty
        chart.ChartAreas("chartAreas").AxisY.MajorGrid.LineColor = Color.Gold

        chart.ChartAreas("chartAreas").AxisX.IsLabelAutoFit = True
        chart.ChartAreas("chartAreas").AxisY.IsLabelAutoFit = True

        chart.ChartAreas("chartAreas").AxisX.LabelStyle.IsStaggered = True
        chart.ChartAreas("chartAreas").AxisY.LabelStyle.IsStaggered = True

        chart.ChartAreas("chartAreas").AxisX.LabelStyle.Angle = -90
        chart.ChartAreas("chartAreas").AxisY.LabelStyle.Angle = 45

        chart.ChartAreas("chartAreas").AxisY.Minimum = -10
        chart.ChartAreas("chartAreas").AxisY.Maximum = 100

        chart.ChartAreas("chartAreas").AxisX.Interval = 1
        chart.ChartAreas("chartAreas").AxisY.Interval = 10

        chart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        chart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5

        chart.ChartAreas("chartAreas").AxisX.IntervalOffset = 3
        chart.ChartAreas("chartAreas").AxisY.IntervalOffset = -1

        chart.ChartAreas("chartAreas").AxisX.IsInterlaced = True
        chart.ChartAreas("chartAreas").AxisY.IsInterlaced = False

        chart.ChartAreas("chartAreas").AxisX.IsMarginVisible = False
        chart.ChartAreas("chartAreas").AxisY.IsMarginVisible = True

        chart.ChartAreas("chartAreas").AxisX.Title = "日期"
        chart.ChartAreas("chartAreas").AxisY.Title = "數量"

        chart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        chart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        ' Series
        chart.Series("series").Points.DataBindXY(xValues, yValues)
        chart.Series("series").ChartType = SeriesChartType.Line
        chart.Series("series").IsValueShownAsLabel = True

        chart.Series("series").MarkerSize = 10
        chart.Series("series").MarkerStyle = MarkerStyle.Circle

        chart.Series("series").Color = Color.FromArgb(255, 255, 100, 65)
        chart.Series("series").Font = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        chart.Series("series").LabelForeColor = Color.DeepSkyBlue
        chart.Series("series").LabelBackColor = Color.FromArgb(50, 255, 100, 65)

        chart.Series("series").XValueType = ChartValueType.String
        chart.Series("series").YValueType = ChartValueType.Int32

        chart.Series("series").LegendText = "隨便一條線"

        chart.Series("series").BorderWidth = 5
        chart.Series("series").BorderColor = Color.DarkGray
        chart.Series("series").BorderDashStyle = ChartDashStyle.Dash

        ' Legends
        chart.Legends("legends").BorderWidth = 3
        chart.Legends("legends").BorderColor = Color.Yellow
        chart.Legends("legends").BorderDashStyle = ChartDashStyle.Dot

        chart.Legends("legends").BackColor = Color.DarkGray

        ' 指出資料點索引是否用於 X 軸或是自訂 X 軸資料
        'chart.Series("series").IsXValueIndexed = False

    End Sub

End Class