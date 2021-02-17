# Chart Controls
使用 Chart Controls

# History
| Version | Description | Start Date | Completion Date | Technology |
| -- | -- | -- | -- | -- |
| v1.0 | Chart 使用 | 2021/02/17 || ASP.NET WebForm <br> .NET Framework 4.5 <br> VB |

# Note
- Annotations：圖形註解集合
- ChartArea：圖形區域集合
- Series：圖形集合
- Legend：Series的圖例集合
- Title：圖形標題集合

---
一個 Chart Control 可以有多個 ChartArea，一個 ChartArea 可以有多個 Series，一個 Series 只對應一個 Legend。

### 常用屬性

Width、Heigth：調整長寬
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

ChartArea：添加繪圖區
```VB
chart.ChartAreas.Add("ChartLine")

' 繪圖區後背 XY 格線設置為空(預設為黑線)
chart.ChartAreas("ChartLine").AxisX.MajorGrid.LineColor = Color.Empty
chart.ChartAreas("ChartLine").AxisY.MajorGrid.LineColor = Color.Empty

' X 軸座標標籤旋轉 -90 度
chart.ChartAreas("ChartLine").AxisX.LabelStyle.Angle = -90

' X 軸座標最小值
chart.ChartAreas("ChartLine").AxisY.Minimum = -1

' X 軸座標間距
chart.ChartAreas("ChartLine").AxisX.Interval = interval

' X、Y 軸說明、說明字體
chart.ChartAreas("ChartLine").AxisX.Title = "日期"
chart.ChartAreas("ChartLine").AxisY.Title = "數量"
chart.ChartAreas("ChartLine").AxisX.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)
chart.ChartAreas("ChartLine").AxisY.TitleFont = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

' X 軸是否隔行變色
chart.ChartAreas("ChartLine").AxisX.IsInterlaced = True

' X 軸邊界不留空格
chart.ChartAreas("ChartLine").AxisX.IsMarginVisible  = False
```

Series：添加序列
```VB
chart.Series.Add("ChartSequence")

' 序列呈現方式(折線、柱狀等圖形類型)
chart.Series("ChartSequence").ChartType = SeriesChartType.Line

' 綁定資料
chart.Series("ChartSequence").Points.DataBindXY(arrayX, arrayY)

' 數值顯示在線上
chart.Series("ChartSequence").IsValueShownAsLabel = False

' 標記點的大小、形狀、顏色、字體
chart.Series("ChartSequence").MarkerSize = 3
chart.Series("ChartSequence").MarkerStyle = MarkerStyle.Circle
chart.Series("ChartSequence").Color = Color.FromArgb(255, 255, 100, 65)
chart.Series("ChartSequence").Font = New Font("Trebuchet MS", 14.0F, FontStyle.Bold)

' 標記點標籤的文字和背景色彩
chart.Series("ChartSequence").LabelForeColor = Color.FromArgb(255, 0, 0)
chart.Series("ChartSequence").LabelBackColor = Color.FromArgb(50, 255, 100, 65)

' 設置 x 軸資料的型別
chart.Series("ChartSequence").XValueType = ChartValueType.String

' 指出資料點索引是否用於 X 軸或是自訂 X 軸資料
chart.Series("ChartSequence").IsXValueIndexed = True
```
# Troubleshooting
### :calendar: 2021/02/17
將 Chart 控制項添加到頁面上，引發下列錯誤
> 找不到要求類型 'GET' 的 HTTP 處理常式。
> 
> 描述: 在執行目前 Web 要求的過程中發生未處理的例外狀況。請檢閱堆疊追蹤以取得錯誤的詳細資訊，以及在程式碼中產生的位置。
>
> 例外狀況詳細資訊: System.Web.HttpException: 找不到要求類型 'GET' 的 HTTP 處理常式。

一般解決辦法為修改 Web.config 設定，將下列程式碼添加到 config 設定
```xml
<appSettings>
  <!--網站根目錄底下要建立 TempImages 資料夾-->
  <add key="ChartImageHandler" value="storage=file;timeout=20;url=~/TempImages;" />
</appSettings>

<system.web>
  <httpHandlers>
    <!--Chart Control 必要項目-->
    <add path="ChartImg.axd" verb="GET,HEAD,POST" type="System.Web.UI.DataVisualization.Charting.ChartHttpHandler, System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" validate="false"/>
  </httpHandlers>
  <pages>
    <controls>
      <!--Chart Control 必要項目-->
      <add tagPrefix="asp" namespace="System.Web.UI.DataVisualization.Charting" assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"/>
    </controls>
  </pages>
</system.web>

<system.webServer>
  <handlers>
    <remove name="ChartImageHandler"/>
    <add name="ChartImageHandler" preCondition="integratedMode" verb="POST,GET,HEAD" path="ChartImg.axd" type="System.Web.UI.DataVisualization.Charting.ChartHttpHandler, System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
  </handlers>
</system.webServer>
```

### :calendar: 2021/02/17
同場加映，依照上述程式碼重新啟動後得到新的問題
> HTTP Error 500.23 - Internal Server Error
> 
> 偵測出 ASP.NET 設定沒有套用到整合式 Managed 管線模式。
> 
> 最有可能的原因:
> 此應用程式可以在 system.web/httpHandlers 區段中定義設定。

解決辦法在 system.webServer 添加下列片段
```xml
<system.webServer>
  <validation validateIntegratedModeConfiguration="false" />
</system.webServer>
```

# Reference
[Chart Control Troubleshooting](https://dotblogs.com.tw/shadow/2011/03/10/21762)
