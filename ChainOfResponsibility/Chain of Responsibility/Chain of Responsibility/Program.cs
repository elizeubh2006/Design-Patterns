namespace Chain_of_Responsibility
{
    //Define the Handler Interface:

    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Handle(User user);
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Role { get; set; }
        public List<string> Permissions { get; set; }
        public string InitialPage { get; set; }
    }

    //Create Concrete Handlers:

    public class GoogleSSOHandler : Handler
    {
        public override void Handle(User user)
        {
            // Mock Google SSO authentication
            if (user.Username == "testuser" && user.Password == "password")
            {
                user.IsAuthenticated = true;
                Console.WriteLine("User authenticated via Google SSO.");
            }

            _nextHandler?.Handle(user);
        }
    }

    public class RoleServiceHandler : Handler
    {
        public override void Handle(User user)
        {
            if (user.IsAuthenticated)
            {
                // Mock role assignment
                user.Role = "Manager";
                user.Permissions = new List<string> { "ViewDashboard", "ApprovePurchase" };
                Console.WriteLine("User role and permissions assigned.");
            }

            _nextHandler?.Handle(user);
        }
    }

    public class MenuServiceHandler : Handler
    {
        public override void Handle(User user)
        {
            if (user.IsAuthenticated)
            {
                // Mock menu creation
                Console.WriteLine("Menu created based on user permissions.");
            }

            _nextHandler?.Handle(user);
        }
    }

    public class RedirectingServiceHandler : Handler
    {
        public override void Handle(User user)
        {
            if (user.IsAuthenticated)
            {
                // Mock redirection based on role
                if (user.Role == "Manager")
                {
                    user.InitialPage = "Dashboard";
                }
                else if (user.Role == "Buyer")
                {
                    user.InitialPage = "PurchaseReport";
                }

                Console.WriteLine($"User redirected to {user.InitialPage}.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create handlers
            var googleSSOHandler = new GoogleSSOHandler();
            var roleServiceHandler = new RoleServiceHandler();
            var menuServiceHandler = new MenuServiceHandler();
            var redirectingServiceHandler = new RedirectingServiceHandler();

            // Set up the chain
            googleSSOHandler.SetNext(roleServiceHandler);
            roleServiceHandler.SetNext(menuServiceHandler);
            menuServiceHandler.SetNext(redirectingServiceHandler);

            // Mock user data
            var user = new User
            {
                Username = "testuser",
                Password = "password"
            };

            // Process user login
            googleSSOHandler.Handle(user);
        }
    }
}
