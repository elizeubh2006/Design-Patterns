using System.Xml.Linq;

namespace VisitorDesignPattern
{
//1. Define the Element Interface:

public interface IFinancialInstrument
    {
        void Accept(IVisitor visitor);
    }

//2. Implement Concrete Elements:

public class Stock : IFinancialInstrument
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        } 
    }

    public class Bond : IFinancialInstrument
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class MutualFund : IFinancialInstrument
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

//3.Define the Visitor Interface:

public interface IVisitor
    {
        void Visit(Stock stock);
        void Visit(Bond bond);
        void Visit(MutualFund mutualFund);
    }

//1. Implement Concrete Visitors:

public class AnnualReportVisitor : IVisitor
    {
        public void Visit(Stock stock)
        {
            Console.WriteLine("Generating annual report for stock.");
        }

        public void Visit(Bond bond)
        {
            Console.WriteLine("Generating annual report for bond.");
        }

        public void Visit(MutualFund mutualFund)
        {
            Console.WriteLine("Generating annual report for mutual fund.");
        }
    }

    public class TaxReportVisitor : IVisitor
    {
        public void Visit(Stock stock)
        {
            Console.WriteLine("Generating tax report for stock.");
        }

        public void Visit(Bond bond)
        {
            Console.WriteLine("Generating tax report for bond.");
        }

        public void Visit(MutualFund mutualFund)
        {
            Console.WriteLine("Generating tax report for mutual fund.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFinancialInstrument> instruments = new List<IFinancialInstrument> { new Stock(), new Bond(), new MutualFund() };

            IVisitor annualReportVisitor = new AnnualReportVisitor();
            IVisitor taxReportVisitor = new TaxReportVisitor();

            foreach (var instrument in instruments)
            {
                instrument.Accept(annualReportVisitor);
                instrument.Accept(taxReportVisitor);
            }
        }
    }
}
