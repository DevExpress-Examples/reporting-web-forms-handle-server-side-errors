using System;
using DevExpress.XtraReports.UI;

namespace DXWebApplication1 {    public partial class Viewer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxWebDocumentViewer1.OpenReport(new XtraReport());
        }
    }
}