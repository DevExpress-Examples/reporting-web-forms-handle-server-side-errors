using System;
using DevExpress.XtraReports.UI;
using DXWebApplication1;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : XtraReport {
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private DevExpress.XtraReports.Parameters.Parameter StartDate;
    private DevExpress.XtraReports.Parameters.Parameter EndDate;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport1() {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.StartDate = new DevExpress.XtraReports.Parameters.Parameter();
        this.EndDate = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // TopMargin
        // 
        this.TopMargin.Name = "TopMargin";
        // 
        // BottomMargin
        // 
        this.BottomMargin.Name = "BottomMargin";
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
        this.Detail.Name = "Detail";
        // 
        // xrLabel1
        // 
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
        this.xrLabel1.Multiline = true;
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(217.7083F, 23F);
        this.xrLabel1.Text = "Test Report. Specified Range:";
        // 
        // StartDate
        // 
        this.StartDate.Description = "Start Date";
        this.StartDate.Name = "StartDate";
        this.StartDate.Type = typeof(System.DateTime);
        this.StartDate.ValueInfo = "2019-01-01";
        // 
        // EndDate
        // 
        this.EndDate.Description = "End Date";
        this.EndDate.Name = "EndDate";
        this.EndDate.Type = typeof(System.DateTime);
        this.EndDate.ValueInfo = "2019-02-01";
        // 
        // xrLabel2
        // 
        this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?StartDate")});
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(241.6667F, 10.00001F);
        this.xrLabel2.Multiline = true;
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(118.75F, 23F);
        this.xrLabel2.Text = "xrLabel2";
        this.xrLabel2.TextFormatString = "{0:d}";
        // 
        // xrLabel3
        // 
        this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?EndDate")});
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(390.625F, 10.00001F);
        this.xrLabel3.Multiline = true;
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(122.9167F, 23F);
        this.xrLabel3.Text = "xrLabel3";
        this.xrLabel3.TextFormatString = "{0:d}";
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
        this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StartDate,
            this.EndDate});
        this.Version = "18.2";
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    protected override void BeforeReportPrint() {
        var startDate = (DateTime)StartDate.Value;
        var endDate = (DateTime)EndDate.Value;
        if (endDate - startDate > TimeSpan.FromDays(14)) {
            throw new CustomInvalidRangeException(startDate, endDate, $"CustomInvalidRangeException occurred. Specified range exceeds 14 days.");
        } else if (endDate < startDate) {
            throw new CustomInvalidRangeException(startDate, endDate, $"CustomInvalidRangeException occurred. End date should be greater than Start date.");
        }
        base.BeforeReportPrint();
    }

    private void XtraReport1_BeforePrint(object sender, EventArgs e) {


    }

    #endregion
}
