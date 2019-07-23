Imports System

Namespace DXWebApplication1
    Public Class CustomInvalidRangeException
        Inherits Exception

        Private msg As String

        Public Sub New(ByVal startDate As DateTime, ByVal endDate As DateTime, ByVal prefixMessage As String)
            msg = prefixMessage
            DetailedMessage = prefixMessage & $"\r\n Specified parameters: from '{startDate.ToShortDateString()}' to '{endDate.ToShortDateString()}'."
        End Sub

        Public Property DetailedMessage As String

        Public Overrides ReadOnly Property Message As String
            Get
                Return msg
            End Get
        End Property
    End Class
End Namespace