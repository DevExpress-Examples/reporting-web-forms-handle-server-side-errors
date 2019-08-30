Imports System
Imports DevExpress.XtraReports.UI
Imports DXWebApplication1

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits XtraReport

	Private TopMargin As TopMarginBand
	Private BottomMargin As BottomMarginBand
	Private Detail As DetailBand
	Private xrLabel1 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrLabel2 As XRLabel
	Private StartDate As DevExpress.XtraReports.Parameters.Parameter
	Private EndDate As DevExpress.XtraReports.Parameters.Parameter

	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.StartDate = New DevExpress.XtraReports.Parameters.Parameter()
		Me.EndDate = New DevExpress.XtraReports.Parameters.Parameter()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' TopMargin
		' 
		Me.TopMargin.Name = "TopMargin"
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
		Me.Detail.Name = "Detail"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
		Me.xrLabel1.Multiline = True
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(217.7083F, 23F)
		Me.xrLabel1.Text = "Test Report. Specified Range:"
		' 
		' StartDate
		' 
		Me.StartDate.Description = "Start Date"
		Me.StartDate.Name = "StartDate"
		Me.StartDate.Type = GetType(Date)
		Me.StartDate.ValueInfo = "2019-01-01"
		' 
		' EndDate
		' 
		Me.EndDate.Description = "End Date"
		Me.EndDate.Name = "EndDate"
		Me.EndDate.Type = GetType(Date)
		Me.EndDate.ValueInfo = "2019-02-01"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?StartDate")})
		Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(241.6667F, 10.00001F)
		Me.xrLabel2.Multiline = True
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
		Me.xrLabel2.SizeF = New System.Drawing.SizeF(118.75F, 23F)
		Me.xrLabel2.Text = "xrLabel2"
		Me.xrLabel2.TextFormatString = "{0:d}"
		' 
		' xrLabel3
		' 
		Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?EndDate")})
		Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(390.625F, 10.00001F)
		Me.xrLabel3.Multiline = True
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
		Me.xrLabel3.SizeF = New System.Drawing.SizeF(122.9167F, 23F)
		Me.xrLabel3.Text = "xrLabel3"
		Me.xrLabel3.TextFormatString = "{0:d}"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
		Me.Font = New System.Drawing.Font("Arial", 9.75F)
		Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.StartDate, Me.EndDate})
		Me.Version = "18.2"
		DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	Protected Overrides Sub BeforeReportPrint()
'INSTANT VB NOTE: The variable startDate was renamed since Visual Basic does not handle local variables named the same as class members well:
		Dim startDate_Renamed = CDate(StartDate.Value)
'INSTANT VB NOTE: The variable endDate was renamed since Visual Basic does not handle local variables named the same as class members well:
		Dim endDate_Renamed = CDate(EndDate.Value)
		If endDate_Renamed - startDate_Renamed > TimeSpan.FromDays(14) Then
			Throw New CustomInvalidRangeException(startDate_Renamed, endDate_Renamed, $"CustomInvalidRangeException occurred. Specified range exceeds 14 days.")
		ElseIf endDate_Renamed < startDate_Renamed Then
			Throw New CustomInvalidRangeException(startDate_Renamed, endDate_Renamed, $"CustomInvalidRangeException occurred. End date should be greater than Start date.")
		End If
		MyBase.BeforeReportPrint()
	End Sub

	Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As EventArgs)


	End Sub

	#End Region
End Class
