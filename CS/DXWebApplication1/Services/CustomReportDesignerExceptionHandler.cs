using System;
using System.IO;
using System.ServiceModel;
using DevExpress.XtraReports.Web.ReportDesigner.Services;

namespace DXWebApplication1.Services {
	public class CustomReportDesignerExceptionHandler : ReportDesignerExceptionHandler {
		public override string GetUnknownExceptionMessage(Exception ex) {
			if (ex is FileNotFoundException)
				return "FileNotFoundException occured.";
			return ex.Message;
		}

		public override string GetFaultExceptionMessage(FaultException ex) {
			return "FaultException occured.";
		}
	}
}