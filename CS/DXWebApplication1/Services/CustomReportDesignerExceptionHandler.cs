using System;
using System.IO;
using System.ServiceModel;
using DevExpress.XtraReports.Web.ReportDesigner.Services;

namespace DXWebApplication1.Services {
    public class CustomReportDesignerExceptionHandler : ReportDesignerExceptionHandler {
        public override string GetUnknownExceptionMessage(Exception ex) {
            if (ex is FileNotFoundException) {
#if DEBUG
                return $"Debug mode. {ex.Message}.";
#else
                return "File is not found.";
#endif
            }

            return $"{ex.GetType().Name} occured. See the log file for more details.";
        }

        public override string GetFaultExceptionMessage(FaultException ex) {
            return $"FaultException occurred: {ex.Message}.";
        }
    }
}