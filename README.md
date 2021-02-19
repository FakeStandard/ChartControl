# Chart Controls
使用 Chart Controls

# History
| Version | Description | Start Date | Completion Date | Technology |
| -- | -- | -- | -- | -- |
| v1.0 | Chart 使用 | 2021/02/17 || ASP.NET WebForm <br> .NET Framework 4.5 <br> VB |

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
