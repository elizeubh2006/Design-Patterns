namespace SingletonPatternExample
{
    //Step-by-Step Implementation
    //Create the Logger Singleton Class
    //Create the Invoice Service
    //Create the Communication Service
    //Simulate the Services in the Main Method

    //Logger Singleton Class
    using System;
    using System.Collections.Generic;

    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object lockObject = new object();
        private List<string> logEntries;

        private Logger()
        {
            logEntries = new List<string>();
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }

        public void Log(string user, string action)
        {
            lock (lockObject)
            {
                string logEntry = $"{DateTime.Now}: User '{user}' performed action '{action}'";
                logEntries.Add(logEntry);
                Console.WriteLine(logEntry);
            }
        }

        public IEnumerable<string> GetLogEntries()
        {
            return logEntries;
        }
    }

    //Invoice Service
    public class InvoiceService
    {
        public void WriteToInvoiceItems(string user, string item)
        {
            // Simulate writing to the Invoice Items table
            Logger.Instance.Log(user, $"Added item '{item}' to Invoice Items table");
        }
    }

    //Communication Service
    public class CommunicationService
    {
        public void SendWhatsAppMessage(string user, string message)
        {
            // Simulate sending a WhatsApp message
            Logger.Instance.Log(user, $"Sent WhatsApp message: '{message}'");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            InvoiceService invoiceService = new InvoiceService();
            CommunicationService communicationService = new CommunicationService();

            // Simulate actions
            invoiceService.WriteToInvoiceItems("Alice", "Item1");
            invoiceService.WriteToInvoiceItems("Bob", "Item2");
            communicationService.SendWhatsAppMessage("Alice", "Hello, this is a test message!");
            communicationService.SendWhatsAppMessage("Bob", "Your invoice has been updated.");

            // Display all log entries
            Console.WriteLine("\nLog Entries:");
            foreach (var logEntry in Logger.Instance.GetLogEntries())
            {
                Console.WriteLine(logEntry);
            }
        }
    }
}
