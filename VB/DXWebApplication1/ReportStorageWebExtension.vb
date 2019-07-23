Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.XtraReports.Web.Extensions
Imports DevExpress.XtraReports.UI


Namespace DXWebApplication1
	Public Class ReportStorageWebExtension1
		Inherits ReportStorageWebExtension

		Private brokenReportLayoutPath As String

		Public Sub New(ByVal brokenReportLayoutPath As String)
			Me.brokenReportLayoutPath = brokenReportLayoutPath
		End Sub

		Public Overrides Function CanSetData(ByVal url As String) As Boolean
			Return MyBase.CanSetData(url)
		End Function

		Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
			Return url <> "invalidUrl"
		End Function

		Public Overrides Function GetData(ByVal url As String) As Byte()
			Dim report As XtraReport
			If url = "brokenReportLayout" Then
				report = XtraReport.FromFile(brokenReportLayoutPath)
			ElseIf url = "fileNotFound" Then
				report = XtraReport.FromFile(url)
			ElseIf url = "reportWithCustomException" Then
				report = New XtraReport1()
			ElseIf url = "reportWithException" Then
				report = New XtraReport2()
			ElseIf url = "ValidReport" Then
				report = New XtraReport3()
			Else
				Throw New KeyNotFoundException()
			End If
			Using ms = New MemoryStream()
				report.SaveLayoutToXml(ms)
				Return ms.ToArray()
			End Using
		End Function

		Public Overrides Function GetUrls() As Dictionary(Of String, String)
			Return MyBase.GetUrls()
		End Function

		Public Overrides Sub SetData(ByVal report As XtraReport, ByVal url As String)
			MyBase.SetData(report, url)
		End Sub

		Public Overrides Function SetNewData(ByVal report As XtraReport, ByVal defaultUrl As String) As String
			Return MyBase.SetNewData(report, defaultUrl)
		End Function
	End Class
End Namespace