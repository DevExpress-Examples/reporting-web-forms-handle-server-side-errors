using System;
using System.IO;
using System.ServiceModel;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace DXWebApplication1.Services {
	public class CustomWebDocumentViewerExceptionHandler : WebDocumentViewerExceptionHandler {
		public override string GetDocumentCreationExceptionMessage(DocumentCreationException ex) {
			if (ex.InnerException.InnerException is MyCustomException) {
				return ex.InnerException.InnerException.Message;
			} else {
				return "NotImplementedException occured.";
			};
		}

		public override string GetFaultExceptionMessage(FaultException faultException) {
			return "FaultException occured.";
		}
	
		public override string GetUnknownExceptionMessage(Exception ex) {
			if (ex is FileNotFoundException)
				return "FileNotFoundException occured.";
			return ex.Message;
		}
	}
}