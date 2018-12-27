<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.cs" Inherits="DXWebApplication1.Designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function openReport(report) {
            webReportDesigner.OpenReport(report);
        }
    </script>

    <input type="button" style="width: 180px; height: 23px" onclick="openReport('brokenReportLayout')" value="Broken Report Layout" />
    <input type="button" style="width: 150px; height: 23px" onclick="openReport('fileNotFound')" value="File Not Found" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReport('reportWithException')" value="Standard Exception on BeforePrint" />
    <input type="button" style="width: 250px; height: 23px" onclick="openReport('reportWithCustomException')" value="Custom Exception on BeforePrint" />
    <input type="button" style="width: 150px; height: 23px" onclick="openReport('invalidUrl')" value="Invalid Report URL" />

    <dx:ASPxReportDesigner ID="ASPxReportDesigner1" ClientInstanceName="webReportDesigner" runat="server">
    </dx:ASPxReportDesigner>
</asp:Content>
