Imports System.Web.UI.DataVisualization.Charting
Imports System.Drawing

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = True Then
            Return
        End If

    End Sub
End Class