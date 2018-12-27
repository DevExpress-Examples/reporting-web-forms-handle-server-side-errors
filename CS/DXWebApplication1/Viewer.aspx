<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.cs" Inherits="DXWebApplication1.Viewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        var timeOut;
        function openReport(report) {
            webDocumentViewer.OpenReport(report);
        }

        function PerformDocumentOperation() {
            webDocumentViewer.PerformCustomDocumentOperation();
            webDocumentViewer.DocumentReady.RemoveHandler(PerformDocumentOperation);
        }

        function generateFaultException() {
            webDocumentViewer.DocumentReady.AddHandler(PerformDocumentOperation)
            webDocumentViewer.OpenReport("ValidReport");
        }
    </script>

    <input type="button" style="width: 180px; height: 23px" onclick="openReport('brokenReportLayout')" value="Broken Report Layout" />
    <input type="button" style="width: 150px; height: 23px" onclick="openReport('fileNotFound')" value="File Not Found" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReport('reportWithException')" value="Standard Exception on BeforePrint" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReport('reportWithCustomException')" value="Custom Exception on BeforePrint" />
    <input type="button" style="width: 200px; height: 23px" onclick="generateFaultException()" value="Custom Document Operation" />

    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" ClientInstanceName="webDocumentViewer" runat="server">
    </dx:ASPxWebDocumentViewer>
</asp:Content>