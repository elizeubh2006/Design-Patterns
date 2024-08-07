namespace ObserverDesignPattern
{
    //Define the Observer Interface:

    public interface IRequestObserver
    {
        void Update(Request request);
    }

    //Define the Subject Interface:

    public interface IRequestMonitor
    {
        void RegisterObserver(IRequestObserver observer);
        void RemoveObserver(IRequestObserver observer);
        void NotifyObservers(Request request);
    }

    //Implement the Concrete Subject: Class that represent my Table repository (business layer) with the approvable requestes of truck entry
    public class RequestMonitor : IRequestMonitor
    {
        private List<IRequestObserver> observers = new List<IRequestObserver>();
        private List<Request> requests = new List<Request>();

        public void RegisterObserver(IRequestObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IRequestObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(Request request)
        {
            foreach (var observer in observers)
            {
                observer.Update(request);
            }
        }

        public void AddRequest(Request request)
        {
            requests.Add(request);
            if (request.Status == "Pending Approval")
            {
                NotifyObservers(request);
            }
        }

        public void UpdateRequestStatus(int requestId, string status)
        {
            var request = requests.FirstOrDefault(r => r.Id == requestId);
            if (request != null)
            {
                request.Status = status;
                if (status == "Approved")
                {
                    NotifyObservers(request);
                }
            }
        }
    }

    //Implement Concrete Observers:

    public class EmailService : IRequestObserver
    {
        public void Update(Request request)
        {
            Console.WriteLine($"Sending email for request {request.Id} to managers.");
        }
    }

    public class WhatsAppService : IRequestObserver
    {
        public void Update(Request request)
        {
            Console.WriteLine($"Sending WhatsApp message for request {request.Id}.");
        }
    }

    public class SmsService : IRequestObserver
    {
        public void Update(Request request)
        {
            Console.WriteLine($"Sending SMS for request {request.Id}.");
        }
    }

    public class PushNotificationService : IRequestObserver
    {
        public void Update(Request request)
        {
            Console.WriteLine($"Sending push notification for request {request.Id}.");
        }
    }

    public class GateControlService : IRequestObserver
    {
        public void Update(Request request)
        {
            if (request.Status == "Approved")
            {
                Console.WriteLine($"Opening gate for request {request.Id}.");
            }
        }
    }

    public class SecurityNotificationService : IRequestObserver
    {
        public void Update(Request request)
        {
            if (request.Status == "Approved")
            {
                Console.WriteLine($"Notifying security with photo and license plate for request {request.Id}.");
            }
        }
    }

    //Define the Request Class: This repesents my table model
    public class Request
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string DriverPhoto { get; set; }
        public string LicensePlate { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestMonitor requestMonitor = new RequestMonitor();

            IRequestObserver emailService = new EmailService();
            IRequestObserver whatsappService = new WhatsAppService();
            IRequestObserver smsService = new SmsService();
            IRequestObserver pushNotificationService = new PushNotificationService();
            IRequestObserver gateControlService = new GateControlService();
            IRequestObserver securityNotificationService = new SecurityNotificationService();

            requestMonitor.RegisterObserver(emailService);
            requestMonitor.RegisterObserver(whatsappService);
            requestMonitor.RegisterObserver(smsService);
            requestMonitor.RegisterObserver(pushNotificationService);
            requestMonitor.RegisterObserver(gateControlService);
            requestMonitor.RegisterObserver(securityNotificationService);

            Request newRequest = new Request { Id = 1, Status = "Pending Approval", DriverPhoto = "photo.jpg", LicensePlate = "ABC-1234" };
            requestMonitor.AddRequest(newRequest);

            // Simulate approval
            requestMonitor.UpdateRequestStatus(1, "Approved");
        }
    }
}
