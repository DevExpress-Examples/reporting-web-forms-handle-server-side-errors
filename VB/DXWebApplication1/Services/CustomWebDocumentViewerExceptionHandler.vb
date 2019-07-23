Imports System
Imports System.IO
Imports System.ServiceModel
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace DXWebApplication1.Services
	Public Class CustomWebDocumentViewerExceptionHandler
		Inherits WebDocumentViewerExceptionHandler

		Public Overrides Function GetDocumentCreationExceptionMessage(ByVal ex As DocumentCreationException) As String
			Dim customExpressionException = TryCast(ex.GetBaseException(), CustomInvalidRangeException)
			If customExpressionException IsNot Nothing Then
				Return customExpressionException.DetailedMessage
			Else
				Return MyBase.GetDocumentCreationExceptionMessage(ex)
			End If
		End Function

		Public Overrides Function GetFaultExceptionMessage(ByVal faultException As FaultException) As String
			Return "FaultException occurred: " & faultException.Message & "."
		End Function

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
	End Class
End Namespace