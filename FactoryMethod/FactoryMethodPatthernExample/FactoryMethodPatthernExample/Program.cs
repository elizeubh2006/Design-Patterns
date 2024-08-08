namespace FactoryMethodPatthernExample
{
    //Step-by-Step Implementation
    //Define the Report Type Enum
    //Create the GenerateReportFile Superclass
    //Create Concrete Report Generators
    //Implement the Sales Report Class
    //Simulate the Export in the Main Method

    //Define the Report Type Enum
    public enum ReportType
    {
        PDF,
        HTML,
        XLSX,
        XML,
        PRINT,
        IMAGE,
        DOC
    }

    //Create the GenerateReportFile Superclass
    public abstract class GenerateReportFile
    {
        public abstract void GenerateFile(string reportData);

        public static GenerateReportFile CreateInstanceOf(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.PDF:
                    return new GeneratePDF();
                case ReportType.HTML:
                    return new GenerateHTML();
                case ReportType.XLSX:
                    return new GenerateXLSX();
                case ReportType.XML:
                    return new GenerateXML();
                case ReportType.PRINT:
                    return new GeneratePrint();
                case ReportType.IMAGE:
                    return new GenerateImage();
                case ReportType.DOC:
                    return new GenerateWordDoc();
                default:
                    throw new ArgumentException("Invalid report type");
            }
        }
    }

    //Create Concrete Report Generators
    public class GeneratePDF : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating PDF report...");
            // Simulate API call to generate PDF
        }
    }

    public class GenerateHTML : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating HTML report...");
            // Simulate API call to generate HTML
        }
    }

    public class GenerateXLSX : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating XLSX report...");
            // Simulate API call to generate XLSX
        }
    }

    public class GenerateXML : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating XML report...");
            // Simulate API call to generate XML
        }
    }

    public class GenerateWordDoc : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating DOC report...");
            // Simulate API call to generate DOC
        }
    }

    public class GeneratePrint : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Printing report...");
            // Simulate API call to print the report
        }
    }

    public class GenerateImage : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating JPEG report...");
            // Simulate API call to generate JPEG
        }
    }

    //Implement the Sales Report Class
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
                var reportGenerator = GenerateReportFile.CreateInstanceOf(reportType);
                reportGenerator.GenerateFile(reportData);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesReport salesReport = new SalesReport();

            Console.WriteLine("Enter the formats to export the report (PDF, HTML, XLSX, XML, PRINT, IMAGE, DOC) separated by commas: ");
            string input = Console.ReadLine();
            var formats = input.Split(',');

            List<ReportType> reportTypes = new List<ReportType>();

            foreach (var format in formats)
            {
                if (Enum.TryParse(format.Trim(), true, out ReportType reportType))
                {
                    reportTypes.Add(reportType);
                }
                else
                {
                    Console.WriteLine($"Invalid format: {format}");
                }
            }

            salesReport.ExportReports(reportTypes);
            Console.WriteLine("Reports exported successfully.");
        }
    }
}
