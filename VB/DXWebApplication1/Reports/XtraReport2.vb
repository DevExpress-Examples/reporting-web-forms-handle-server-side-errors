Imports System
Imports DevExpress.XtraReports.UI

Public Class XtraReport2
	Inherits XtraReport

	Private TopMargin As TopMarginBand
	Private BottomMargin As BottomMarginBand
	Private Detail As DetailBand
	Private xrLabel1 As XRLabel

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
'		Me.BeforePrint += XtraReport2_BeforePrint
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
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.Detail.Name = "Detail"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(33.33333F, 10.00001F)
		Me.xrLabel1.Multiline = True
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
		Me.xrLabel1.Text = "xrLabel1"
		' 
		' XtraReport2
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
		Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
		Me.Version = "18.2"
		DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	Private Sub XtraReport2_BeforePrint(ByVal sender As Object, ByVal e As EventArgs)
		Throw New NotImplementedException()
	End Sub
	#End Region
End Class
