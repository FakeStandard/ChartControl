<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="SimpleChart.Index" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>單一數列</h3>
        <hr />
        <div>
            <asp:Chart ID="SingleChart" runat="server" BackImageTransparentColor="255, 128, 0"></asp:Chart>
        </div>

        <h3>兩個數列</h3>
        <hr />
        <div>
            <asp:Chart ID="DoubleChart" runat="server" BackImageTransparentColor="255, 128, 0"></asp:Chart>
        </div>

        <h3>3D 直條圖</h3>
        <hr />
        <div>
            <asp:Chart ID="DimensionalChart" runat="server" BackImageTransparentColor="255, 128, 0"></asp:Chart>
        </div>
    </form>
</body>
</html>
