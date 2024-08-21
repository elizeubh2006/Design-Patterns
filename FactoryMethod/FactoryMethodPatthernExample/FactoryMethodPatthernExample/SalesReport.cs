using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public class SalesReport
    {
        private string reportData;

        public SalesReport()
        {
            // Simulate report data
            reportData = "Sales Report Data";
        }

        public void ExportReports(List<ReportType> reportTypes)
        {
            foreach (var reportType in reportTypes)
            {
                //Create instance and use it
                var reportGenerator = GenerateReportFile.CreateInstanceOf(reportType);
                reportGenerator.GenerateFile(reportData);
            }
        }
    }
}
