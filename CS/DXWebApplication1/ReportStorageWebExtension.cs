using System.Collections.Generic;
using System.IO;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.UI;


namespace DXWebApplication1 {
	public class ReportStorageWebExtension1 : ReportStorageWebExtension {

		private string brokenReportLayoutPath;

		public ReportStorageWebExtension1(string brokenReportLayoutPath) {
			this.brokenReportLayoutPath = brokenReportLayoutPath;
		}

		public override bool CanSetData(string url) {
			return base.CanSetData(url);
		}

		public override bool IsValidUrl(string url) {
			return url != "invalidUrl";
		}

		public override byte[] GetData(string url) {
			XtraReport report;
			if (url == "brokenReportLayout") {
				report = XtraReport.FromFile(brokenReportLayoutPath);
			} else if (url == "fileNotFound") { 
				report = XtraReport.FromFile(url);
			} else if (url == "reportWithCustomException") {
				report = new XtraReport1();
			} else if (url == "reportWithException") {
				report = new XtraReport2();
			} else if (url == "ValidReport") {
				report = new XtraReport3();
			} 
			else
				throw new KeyNotFoundException();
			using (var ms = new MemoryStream()) {
				report.SaveLayoutToXml(ms);
				return ms.ToArray();
			}
		}

		public override Dictionary<string, string> GetUrls() {
			return base.GetUrls();
		}

		public override void SetData(XtraReport report, string url) {			
			base.SetData(report, url);
		}

		public override string SetNewData(XtraReport report, string defaultUrl) {
			return base.SetNewData(report, defaultUrl);
		}
	}
}