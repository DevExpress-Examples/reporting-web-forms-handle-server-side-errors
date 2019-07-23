Imports System
Imports DevExpress.XtraReports.UI

Namespace DXWebApplication1
	Partial Public Class Viewer
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxWebDocumentViewer1.OpenReport(New XtraReport())
		End Sub
	End Class
End Namespace