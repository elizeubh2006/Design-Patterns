using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public class GenerateWordDoc : GenerateReportFile
    {
        public override void GenerateFile(string reportData)
        {
            Console.WriteLine("Generating DOC report...");
            // Simulate API call to generate DOC
        }
    }
}
