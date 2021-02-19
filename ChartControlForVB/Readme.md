# Note
圖表包含以下五個物件，一個 Chart Control 可以有多個 ChartArea，一個 ChartArea 可以有多個 Series，一個 Series 只對應一個 Legend。
- Annotations：圖表註解集合
- ChartArea：圖表區域
- Series：圖表數列
- Legend：圖表圖例
- Title：圖形標題

```VB
' 添加圖表區域集合
chart.ChartAreas.Add("chartAreas")

' 添加數據序列集合
chart.Series.Add("series")

' 添加圖例集合
chart.Legends.Add("legends")

' 綁定 x,y 軸資料
chart.Series("series").Points.DataBindXY(xValues, yValues)
```
## :cactus: Chart Property
Width、Heigth：調整寬度與高度
``` VB
chart.Width = 1500
chart.Height = 500
```

Title：標題設置
```VB
Dim title As New Title()
title.Text = "title"
title.Font = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
title.Alignment = ContentAlignment.MiddleCenter
chart.Titles.Add(title)

' 或使用 default 值建立標題
chart.Title.Add("title")
```

## :cactus: CharAreas Property

BackColor：ChartAreas 背景色彩
```VB
chart.ChartAreas("chartAreas").BackColor = Color.LawnGreen
```

MajorGrid.Enabled：顯示座標網格（圖表區域背景隔線）是否可見
```VB
chart.ChartAreas("chartAreas").AxisX.MajorGrid.Enabled = False
chart.ChartAreas("chartAreas").AxisY.MajorGrid.Enabled = True
```

MajorGrid.LineColor：圖表區域背景格線預設顯示黑線，透過 AxisX.MajorGrid.LineColor 將 X 軸底線設置為空，同理將 Y 軸底線設置為金色
```VB
chart.ChartAreas("chartAreas").AxisX.MajorGrid.LineColor = Color.Empty
chart.ChartAreas("chartAreas").AxisY.MajorGrid.LineColor = Color.Gold
```

LabelStyle.Angle：座標標籤角度（default：0）
```VB
chart.ChartAreas("chartAreas").AxisX.LabelStyle.Angle = -90
chart.ChartAreas("chartAreas").AxisY.LabelStyle.Angle = 45
```

Maximum、Minimum：座標標籤最大值與最小值
```VB
chart.ChartAreas("chartAreas").AxisY.Minimum = -10
chart.ChartAreas("chartAreas").AxisY.Maximum = 100
```

Interval：座標標籤的間隔，若要顯示 X 軸所有座標，請設置為 1
```VB
chart.ChartAreas("chartAreas").AxisX.Interval = 1
chart.ChartAreas("chartAreas").AxisY.Interval = 10
```

IntervalAutoMode：判斷座標軸是否使用固定數目的間隔，或間隔數目取決於座標軸的大小
```VB
chart.ChartAreas("chartAreas").AxisX.IntervalAutoMode = 2
chart.ChartAreas("chartAreas").AxisY.IntervalAutoMode = 5
```

IntervalOffset：座標軸的間隔偏移
```VB
chart.ChartAreas("chartAreas").AxisX.IntervalOffset = 3
chart.ChartAreas("chartAreas").AxisY.IntervalOffset = -1
```

IsInterlaced：座標軸呈現交錯式帶狀線（default：false）
```VB
chart.ChartAreas("chartAreas").AxisX.IsInterlaced = True
chart.ChartAreas("chartAreas").AxisY.IsInterlaced = False
```

IsMarginVisble：是否使用座標軸邊界，True 會為第一個和最後一個資料點與圖表區域框線之間加入間距(即部分空白)，反之（default：true）
```VB
chart.ChartAreas("chartAreas").AxisX.IsMarginVisible = False
chart.ChartAreas("chartAreas").AxisY.IsMarginVisible = True
```

Title、TitleFont：座標值標題以及座標值標題字型
```VB
chart.ChartAreas("chartAreas").AxisX.Title = "日期"
chart.ChartAreas("chartAreas").AxisY.Title = "數量"

chart.ChartAreas("chartAreas").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
chart.ChartAreas("chartAreas").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
```

LabelStyle.IsStaggered：標籤是否採用上下/左右位移來呈現，有個值得注意的地方，若先前已經設置標籤角度，再設置該屬性後，標籤角度會回到預設。
```VB
chart.ChartAreas("chartAreas").AxisX.LabelStyle.IsStaggered = True
chart.ChartAreas("chartAreas").AxisY.LabelStyle.IsStaggered = True
```

IsLabelAutoFit：座標軸標籤是否自動調整大小
```VB
chart.ChartAreas("chartAreas").AxisX.IsLabelAutoFit = True
chart.ChartAreas("chartAreas").AxisY.IsLabelAutoFit = True
```

Area3DStyle.Enabled3D：啟用和關閉圖表區的 3D 效果
```VB
chart.ChartAreas("chartAreas").Area3DStyle.Enable3D = True
```

Area3DStyle.Rotation：圖表區域垂直座標的旋轉角度，0 度會為正面，90 度視角為圖表側邊
```VB
chart.ChartAreas("chartAreas").Area3DStyle.Rotation = 10
```

Area3DStyle.Inclination：圖表區域水平座標旋轉角度
```VB
chart.ChartAreas("chartAreas").Area3DStyle.Inclination = 10
```

Area3DStyle.PointDepth、Area3DStyle.PointGapDepth：3D 圖表區域中資料點的深度、數列之間的距離
```VB
chart.ChartAreas("chartAreas").Area3DStyle.PointDepth = 100
chart.ChartAreas("chartAreas").Area3DStyle.PointGapDepth = 1000
```

Area3DStyle.WallWidth：3D 圖表區域的背景牆寬度
```VB
chart.ChartAreas("chartAreas").Area3DStyle.WallWidth = 30
```

Area3DStyle.Perspective：3D 圖表區域的透視百分比
```VB
chart.ChartAreas("chartAreas").Area3DStyle.Perspective = 50
```

## :cactus: Series Property
Points.DataBindXY：將資料分別綁定於 XY 軸，xValues、yValues 分別為 ArrayList
```VB
chart.Series("series").Points.DataBindXY(xValues, yValues)
```

Points.DataBind：將 DataTable 資料綁定到 Chart，並指定 XY 軸要綁定的欄位名稱
```VB
' 方法一
chart.Series("series").Points.DataBind(dt, "Month", "Amount", "")

' 方法二
chart.DataSource = dt
chart.Series("series").XValueMember = "Month"
chart.Series("series").YValueMembers = "Amount"
chart.DataBind()
```

ChartType：數列呈現的圖表類型，可呈現長條、折線、圓餅等類型（default：SeriesChartType.Column 長條圖）
```VB
chart.Series("series").ChartType = SeriesChartType.Line
```

IsValueShowAsLabel：是否顯示資料點的數值（default：false）
```VB
chart.Series("series").IsValueShownAsLabel = True
```

MarkerSize、MarkerStyle：資料點大小以及樣式
```VB
chart.Series("series").MarkerSize = 10
chart.Series("series").MarkerStyle = MarkerStyle.Square
```

Color、Font：資料點顏色及資料點字型
```VB
chart.Series("series").Color = Color.FromArgb(255, 255, 100, 65)
chart.Series("series").Font = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
```

LabelForeColor、LabelBackColor：資料點標籤的文字色彩及背景色彩
```VB
chart.Series("series").LabelForeColor = Color.DeepSkyBlue
chart.Series("series").LabelBackColor = Color.FromArgb(50, 255, 100, 65)
```

XValueType、YValueType：沿座標繪製的實質型別
```VB
chart.Series("series").XValueType = ChartValueType.String
chart.Series("series").YValueType = ChartValueType.Int32
```

LegendText：圖表圖例文字
```VB
chart.Series("series").LegendText = "隨便一條線"
```

BorderWidth、BorderColor、BorderDashStyle：設置資料點的框線寬度、資料點框線色彩、資料點框線樣式
```VB
chart.Series("series").BorderWidth = 5
chart.Series("series").BorderColor = Color.DarkGray
chart.Series("series").BorderDashStyle = ChartDashStyle.Dash
```

## :cactus: Legends Property

BorderWidth、BorderColor、BorderDashStyle：設置圖表圖例框線寬度、顏色、樣式
```VB
chart.Legends("legends").BorderWidth = 3
chart.Legends("legends").BorderColor = Color.Yellow
chart.Legends("legends").BorderDashStyle = ChartDashStyle.Dot
```

BackColor：圖表圖例背景色
```VB
chart.Legends("legends").BackColor = Color.DarkGray
```
