namespace FactoryMethodPatthernExample
{
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
