using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public class GeneratePrint : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Printing report...");
            // Simulate API call to print the report
        }
    }
}
