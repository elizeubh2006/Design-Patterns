namespace AbstractFactoryExample
{
    /*
    Abstract Explanation
    The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. In the context of a payment system, this pattern can be used to create different payment processors (e.g., PayPal, Payoneer, MercadoPago, Google Pay) with a unified interface.
    */

    //Components:
    //Abstract Factory: Declares a set of methods for creating abstract products.
    //Concrete Factories: Implement the creation methods for specific products.
    //Abstract Product: Declares an interface for a type of product object.
    //Concrete Products: Implement the abstract product interface.

    //Implementation in C#
    //Let's implement this in a C# console application.

    //Define the Abstract Product Interface
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    //API'S : Implement Concrete Products  -- All implements IPaymentProcessor
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }

    public class PayoneerProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Payoneer payment of {amount:C}");
        }
    }

    public class MercadoPagoProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing MercadoPago payment of {amount:C}");
        }
    }

    public class GooglePayProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Google Pay payment of {amount:C}");
        }
    }

    //Define the Abstract Factory Interface
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatePaymentProcessor();
    }

    //Implement Concrete Factories
    public class PayPalProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalProcessor();
        }
    }

    public class PayoneerProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayoneerProcessor();
        }
    }

    public class MercadoPagoProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new MercadoPagoProcessor();
        }
    }

    public class GooglePayProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new GooglePayProcessor();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessorFactory factory = GetFactory("PayPal");
            IPaymentProcessor processor = factory.CreatePaymentProcessor();
            processor.ProcessPayment(100.00m);

            factory = GetFactory("GooglePay");
            processor = factory.CreatePaymentProcessor();
            processor.ProcessPayment(200.00m);
        }

        static IPaymentProcessorFactory GetFactory(string paymentMethod)
        {
            return paymentMethod switch
            {
                "PayPal" => new PayPalProcessorFactory(),
                "Payoneer" => new PayoneerProcessorFactory(),
                "MercadoPago" => new MercadoPagoProcessorFactory(),
                "GooglePay" => new GooglePayProcessorFactory(),
                _ => throw new ArgumentException("Invalid payment method"),
            };
        }
    }
}
