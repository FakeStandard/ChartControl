Imports System.Web.UI.DataVisualization.Charting
Imports System.Drawing

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = True Then
            Return
        End If

        SingleBind()
        DoubleBind()
        DimensionalBind()
        PieBind()

    End Sub

    ''' <summary>
    ''' 單一數列圖表
    ''' </summary>
    Sub SingleBind()
        Dim xValues As String() = {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"}
        Dim yValues As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}

        SingleChart.Width = 700
        SingleChart.Height = 500

        Dim title As New Title()
        title.Text = "預設為長條圖"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        SingleChart.Titles.Add(title)

        SingleChart.ChartAreas.Add("chartAreas")
        SingleChart.Series.Add("series")
        SingleChart.Legends.Add("legends")
        SingleChart.Series("series").Points.DataBindXY(xValues, yValues)

        ' ChartAreas
        SingleChart.ChartAreas("chartAreas").AxisX.MajorGrid.Enabled = False
        SingleChart.ChartAreas("chartAreas").AxisY.MajorGrid.Enabled = True

        SingleChart.ChartAreas("chartAreas").BackColor = Color.LawnGreen

        SingleChart.ChartAreas("chartAreas").AxisX.MajorGrid.LineColor = Color.Empty
        SingleChart.ChartAreas("chartAreas").AxisY.MajorGrid.LineColor = Color.Gold

        SingleChart.ChartAreas("chartAreas").AxisX.IsLabelAutoFit = True
        SingleChart.ChartAreas("chartAreas").AxisY.IsLabelAutoFit = True

        SingleChart.ChartAreas("chartAreas").AxisX.LabelStyle.IsStaggered = True
        SingleChart.ChartAreas("chartAreas").AxisY.LabelStyle.IsStaggered = True

        SingleChart.ChartAreas("chartAreas").AxisX.LabelStyle.Angle = -90
        SingleChart.ChartAreas("chartAreas").AxisY.LabelStyle.Angle = 45

        SingleChart.ChartAreas("chartAreas").AxisY.Minimum = -10
        SingleChart.ChartAreas("chartAreas").AxisY.Maximum = 100

        SingleChart.ChartAreas("chartAreas").AxisX.Interval = 1
        SingleChart.ChartAreas("chartAreas").AxisY.Interval = 10

        SingleChart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        SingleChart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5

        SingleChart.ChartAreas("chartAreas").AxisX.IntervalOffset = 3
        SingleChart.ChartAreas("chartAreas").AxisY.IntervalOffset = -1

        SingleChart.ChartAreas("chartAreas").AxisX.IsInterlaced = True
        SingleChart.ChartAreas("chartAreas").AxisY.IsInterlaced = False

        SingleChart.ChartAreas("chartAreas").AxisX.IsMarginVisible = False
        SingleChart.ChartAreas("chartAreas").AxisY.IsMarginVisible = True

        SingleChart.ChartAreas("chartAreas").AxisX.Title = "日期"
        SingleChart.ChartAreas("chartAreas").AxisY.Title = "數量"

        SingleChart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        SingleChart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        ' Series
        SingleChart.Series("series").Points.DataBindXY(xValues, yValues)
        SingleChart.Series("series").ChartType = SeriesChartType.Line
        SingleChart.Series("series").IsValueShownAsLabel = True

        SingleChart.Series("series").MarkerSize = 10
        SingleChart.Series("series").MarkerStyle = MarkerStyle.Circle

        SingleChart.Series("series").Color = Color.FromArgb(255, 255, 100, 65)
        SingleChart.Series("series").Font = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        SingleChart.Series("series").LabelForeColor = Color.DeepSkyBlue
        SingleChart.Series("series").LabelBackColor = Color.FromArgb(50, 255, 100, 65)

        SingleChart.Series("series").XValueType = ChartValueType.String
        SingleChart.Series("series").YValueType = ChartValueType.Int32

        SingleChart.Series("series").LegendText = "隨便一條線"

        SingleChart.Series("series").BorderWidth = 5
        SingleChart.Series("series").BorderColor = Color.DarkGray
        SingleChart.Series("series").BorderDashStyle = ChartDashStyle.Dash

        ' Legends
        SingleChart.Legends("legends").BorderWidth = 3
        SingleChart.Legends("legends").BorderColor = Color.Yellow
        SingleChart.Legends("legends").BorderDashStyle = ChartDashStyle.Dot

        SingleChart.Legends("legends").BackColor = Color.DarkGray
        SingleChart.Legends("legends").BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal

        ' 指出資料點索引是否用於 X 軸或是自訂 X 軸資料
        'chart.Series("series").IsXValueIndexed = False

    End Sub

    ''' <summary>
    ''' 兩個數列圖表
    ''' </summary>
    Sub DoubleBind()
        ' 建立 x,y 軸資料
        Dim xValues As String() = {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"}
        Dim y1Values As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}
        Dim y2Values As Integer() = {33, 14, 19, 40, 27, 53, 77, 8, 23, 17, 61, 37}

        DoubleChart.Width = 700
        DoubleChart.Height = 500

        Dim title As New Title()
        title.Text = "雙數列"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        DoubleChart.Titles.Add(title)

        DoubleChart.ChartAreas.Add("chartAreas")
        DoubleChart.Series.Add("series1")
        DoubleChart.Series.Add("series2")
        DoubleChart.Legends.Add("legends")
        DoubleChart.Series("series1").Points.DataBindXY(xValues, y1Values)
        DoubleChart.Series("series2").Points.DataBindXY(xValues, y2Values)

        ' 基本設定
        DoubleChart.ChartAreas("chartAreas").AxisX.Interval = 1
        DoubleChart.ChartAreas("chartAreas").AxisY.Interval = 10
        DoubleChart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        DoubleChart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5
        DoubleChart.ChartAreas("chartAreas").AxisX.Title = "日期"
        DoubleChart.ChartAreas("chartAreas").AxisY.Title = "數量"
        DoubleChart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        DoubleChart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        DoubleChart.Series("series1").IsValueShownAsLabel = True
        DoubleChart.Series("series1").XValueType = ChartValueType.String
        DoubleChart.Series("series1").YValueType = ChartValueType.Int32
        DoubleChart.Series("series1").LegendText = "第一根柱"

        DoubleChart.Series("series2").IsValueShownAsLabel = True
        DoubleChart.Series("series2").XValueType = ChartValueType.String
        DoubleChart.Series("series2").YValueType = ChartValueType.Int32
        DoubleChart.Series("series2").LegendText = "第二根柱"
    End Sub

    ''' <summary>
    ''' 3D 數列圖表
    ''' </summary>
    Sub DimensionalBind()
        ' 建立 x,y 軸資料
        Dim xValues As String() = {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"}
        Dim yValues As Integer() = {15, 25, 18, 35, 79, 12, 33, 46, 37, 29, 5, 51}

        DimensionalChart.Width = 700
        DimensionalChart.Height = 500

        Dim title As New Title()
        title.Text = "3D 效果"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        DimensionalChart.Titles.Add(title)

        DimensionalChart.ChartAreas.Add("chartAreas")
        DimensionalChart.Series.Add("series")
        DimensionalChart.Legends.Add("legends")
        DimensionalChart.Series("series").Points.DataBindXY(xValues, yValues)

        ' 基本設定
        DimensionalChart.ChartAreas("chartAreas").AxisX.Interval = 1
        DimensionalChart.ChartAreas("chartAreas").AxisY.Interval = 10
        DimensionalChart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
        DimensionalChart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5
        DimensionalChart.ChartAreas("chartAreas").AxisX.Title = "日期"
        DimensionalChart.ChartAreas("chartAreas").AxisY.Title = "數量"
        DimensionalChart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
        DimensionalChart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

        DimensionalChart.Series("series").IsValueShownAsLabel = True
        DimensionalChart.Series("series").XValueType = ChartValueType.String
        DimensionalChart.Series("series").YValueType = ChartValueType.Int32
        DimensionalChart.Series("series").LegendText = "隨便一根柱"

        ' 3D 相關設定
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.Enable3D = True
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.Rotation = 10
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.Inclination = 10
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.PointDepth = 100
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.PointGapDepth = 1000
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.WallWidth = 30
        DimensionalChart.ChartAreas("chartAreas").Area3DStyle.Perspective = 50
    End Sub

    ''' <summary>
    ''' 圓餅圖
    ''' </summary>
    Sub PieBind()
        Dim xValues = {"保險費用", "生活飲食", "日常用品", "交通", "電信費"}
        Dim yValues = {3010, 9266, 1850, 2600, 599}

        PieChart.Width = 700
        PieChart.Height = 500

        Dim title As New Title()
        title.Text = "圓餅圖"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        PieChart.Titles.Add(title)

        PieChart.ChartAreas.Add("chartAreas")
        PieChart.Series.Add("series")
        PieChart.Legends.Add("legends")
        PieChart.Series("series").Points.DataBindXY(xValues, yValues)

        PieChart.ChartAreas("chartAreas").Area3DStyle.Enable3D = True
        PieChart.Series("series").ChartType = SeriesChartType.Pie
        'PieChart.Series("series")("PieLabelStyle") = "Disabled"
        'PieChart.Series("series")("PieLabelStyle") = "Inside"
        PieChart.Series("series")("PieLabelStyle") = "OutSide"
        PieChart.Series("series")("PieDrawingStyle") = "Default"
    End Sub
End Class