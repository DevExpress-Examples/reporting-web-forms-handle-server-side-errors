<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.cs" Inherits="DXWebApplication1.Designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v19.1.Web.WebForms, Version=19.1.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        var showPreview;
        function openReport(report) {
            webReportDesigner.OpenReport(report);
            showPreview = false;
        }

        function reportOpened(s, e) {
            showPreview && s.ShowPreview();
            showPreview = false;
        }

        function openReportPreview(report) {
            openReport(report);
            showPreview = true;
        }

        function customizeParameterEditors(s, e) {
            if (e.parameter.type == "System.DateTime") {
                e.info.editor = $.extend({}, e.info.editor);
                e.info.editor.extendedOptions = $.extend(e.info.editor.extendedOptions, { type: 'date', applyValueMode: 'useButtons' });
            }
        }
    </script>

    <input type="button" style="width: 180px; height: 23px" onclick="openReport('brokenReportLayout')" value="Broken Report Layout" />
    <input type="button" style="width: 150px; height: 23px" onclick="openReport('fileNotFound')" value="File Not Found" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReportPreview('reportWithException')" value="Standard Exception on BeforePrint" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReportPreview('reportWithCustomException')" value="Custom Exception on BeforePrint" />
    <input type="button" style="width: 150px; height: 23px" onclick="openReport('invalidUrl')" value="Invalid Report URL" />

    <dx:ASPxReportDesigner ID="ASPxReportDesigner1" ClientInstanceName="webReportDesigner" runat="server">
        <ClientSideEvents CustomizeParameterEditors="customizeParameterEditors" ReportOpened="reportOpened" />
    </dx:ASPxReportDesigner>
</asp:Content>
