Imports System
Imports System.IO
Imports System.ServiceModel
Imports DevExpress.XtraReports.Web.ReportDesigner.Services

Namespace DXWebApplication1.Services
	Public Class CustomReportDesignerExceptionHandler
		Inherits ReportDesignerExceptionHandler

		Public Overrides Function GetUnknownExceptionMessage(ByVal ex As Exception) As String
			If TypeOf ex Is FileNotFoundException Then
#If DEBUG Then
				Return "Debug mode. " & ex.Message & "."
#Else
				Return "File is not found."
#End If
			End If

			Return ex.GetType().Name & " occurred. See the log file for more details."
		End Function

		Public Overrides Function GetFaultExceptionMessage(ByVal ex As FaultException) As String
			Return "FaultException occurred: " & ex.Message & "."
		End Function
	End Class
End Namespace