﻿Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Public Class XtraReport3
	Inherits DevExpress.XtraReports.UI.XtraReport

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

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
		' XtraReport3
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail})
		Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
		Me.Version = "18.2"
		DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
