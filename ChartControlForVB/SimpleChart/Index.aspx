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
            <iframe id="singleChart" name="singleChart" src="SingleSequence.aspx" width="850" height="600" frameborder="0"></iframe>
        </div>

        <h3>兩個數列</h3>
        <hr />
        <div>
            <iframe id="doubleChart" name="doubleChart" src="DoubleSequence.aspx" width="850" height="600" frameborder="0"></iframe>
        </div>

        <h3>3D 直條圖</h3>
        <hr />
        <div>
            <iframe id="3DChart" name="3DChart" src="3D.aspx" width="850" height="600" frameborder="0"></iframe>
        </div>
    </form>
</body>
</html>
