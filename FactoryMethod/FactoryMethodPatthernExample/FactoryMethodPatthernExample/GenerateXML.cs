using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public class GenerateXML : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating XML report...");
            // Simulate API call to generate XML
        }
    }
}
