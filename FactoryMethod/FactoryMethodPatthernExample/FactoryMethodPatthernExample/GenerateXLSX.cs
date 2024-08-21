using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public class GenerateXLSX : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating XLSX report...");
            // Simulate API call to generate XLSX
        }
    }
}
