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

        ' 設定長寬
        chart.Width = 700
        chart.Height = 500

        ' 建立標題並添加
        Dim title As New Title()
        title.Text = "預設為長條圖"
        title.Font = New Font("標楷體", 16.0F, FontStyle.Underline)
        title.Alignment = ContentAlignment.MiddleCenter
        chart.Titles.Add(title)

        ' 添加圖表區域集合
        chart.ChartAreas.Add("chartAreas")
        ' 添加數據序列集合
        chart.Series.Add("series")
        ' 添加圖例集合
        chart.Legends.Add("legends")

        ' 綁定 x,y 軸資料
        chart.Series("series").Points.DataBindXY(xValues, yValues)
    End Sub

End Class