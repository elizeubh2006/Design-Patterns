using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatthernExample
{
    public abstract class GenerateReportFile
    {
        public abstract void GenerateFile(string reportData);

        //Factory method that generate the concrete object directly
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

}
