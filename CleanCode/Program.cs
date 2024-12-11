using CleanCode.Models;
using CleanCode.Services;

namespace CleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clarity and precision in naming
            // "bad"
            int n = 0;
            string s = "John";

            //"good"
            int studentCount = 100;
            string studentName = "John";

            //OrderProcessor orderProcessor = new OrderProcessor();
            //Order order = new Order();

            //if (OrderProcessor.IsValid(Order))
            //{
            //    Console.WriteLine("Order is valid");
            //}

            //foreach (int i in new int[1,2,3])
            //{
            //    Console.WriteLine(i);
            //}



            // List<Order> orders = new List<Order>
            // { new Order { Id = 1, ProductName = "Laptop" ,Quantity = 2, Price = 1500 },
            // new Order { Id = 2, ProductName = "Phone" ,Quantity = 2, Price = 500 },
            // };

            //OrderPrinter printer = new OrderPrinter();
            //printer.PrintOrderDetails(orders);

            //Open-Closed Principle(OCP) -- Modify/Extend methods from a base class in a new class 

            //Invoice invoice = new Invoice { Amount = 100};
            //BillingService billingService = new BillingService(); 
            //double total = billingService.CalculateTotal(invoice);
            //Console.WriteLine($"Total: {total}");
            //DiscountedInvoice discountedInvoice = new DiscountedInvoice { Amount = 100, Discount = 25 };
            //DiscountedBillingService discountedBillingService = new DiscountedBillingService();
            //Console.WriteLine(discountedBillingService.CalculateTotal(discountedInvoice));

            //Liskov Substitution Principle---- replace derived class with the base classes without crashing the program

            //Bird sparow = new Bird();
            //sparow.Fly();

            //Bird penguin = new Penguin();
            //penguin.Fly();//This will throw an exception

            /*
            //Bird sparow = new Bird();
            //sparow.Fly();

            //Bird penguin = new Bird();
            //penguin.Fly();
             */

            //Interface Segregation Principle(ISP) ---- when a class is only requires specfic a method from the interface then split the interface in two

            //IWorker human = new IWorker();
            //human.Work();
            //human.Eat();

            //IWorker robot = new Robot();
            //robot.Work();
            //try
            //{
            //    robot.Eat();
            //}
            //catch (NotImplementedException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Worker human = new Worker();
            //human.Work();
            //human.Eat();

            //IWorkable robot = new Robot();
            //robot.Work();

            // Dependecy Inversion Principle(DIP) --- High-level parts of your code (the big-picture logic) should not depend directly on low-level parts (the details). Both should depend on shared, abstract interfaces.

            IEmailService emailService = new EmailService();
            Notification notification = new Notification(emailService);
            //Notification notification = new Notification();
            //notification.Send = ("Hello, this is a notification.");
            notification.Send("Hello, this is a notification");

            Console.ReadKey();

        }

        public void ReadFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found" + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured" + ex.Message);
            }
        }

    }

    public class MathUtils()
    {
        //Not what but why
        // We are using a recursive apporach for the calculation BECAUSE it's more "intuitive"
        public int CalculateFactorial(int number)
        {
            //"calculations" 
            return number * 100;
        }


        //TODO : Implement the binary search algoritm
        // Using binary search her to improve the performance for large datasets
        public int BinarySearch()
        {
            //does the binary search
            return -1;
        }
    }

    //Open-Closed Principle(OCP) -- Modify/Extend methods from a base class in a new class 
    public class Invoice
    {
        public double Amount { get; set; }
    }

    public class DiscountedInvoice : Invoice 
    {
        public double Discount { get; set; }
    }

    public class BillingService
    {
        public virtual double CalculateTotal(Invoice invoice)
        {
            //base implementation for calculation total
            return invoice.Amount;
        }
    }

    public class DiscountedBillingService : BillingService
    {
        public override double CalculateTotal(Invoice invoice)
        {
            if (invoice is DiscountedInvoice discountedInvoice)
            {
                return discountedInvoice.Amount - discountedInvoice.Discount;
            }
            return base.CalculateTotal(invoice);
        }
    }

    // Liskov Substitution Principle ---- replace derived class with the base classes without crashing the program
    public class Bird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Chrip!");
        }
        //public virtual void Fly()
        //{
        //    Console.WriteLine("Flying!");
        //}
    }

    public class Sparow : Bird , IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }

    public class Penguin : Bird
    {
        public override void MakeSound() 
        {
            base.MakeSound();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    //Interface Segregation Principle(ISP) ---- when a class is only requires specfic a method from the interface then split the interface in two
    //public interface IWorker
    //{
    //    void Work();

    //    void Eat();
    //}

    public interface IWorkable
    {
        void Work();

    }
    public interface IEatable
    {
        void Eat();
    }


    public class Worker : IWorkable,IEatable
    {
        public void Work() 
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public class Robot : IWorkable //IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }

        //public void Eat()
        //{
        //    //Robots do not eat, but are force to implement this method
        //    throw new NotImplementedException();
        //}
    }

    // Dependecy Inversion Principle(DIP) --- High-level parts of your code (the big-picture logic) should not depend directly on low-level parts (the details). Both should depend on shared, abstract interfaces.


    public interface IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email {to} with subject{subject}");
        }
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email {to} with subject{subject}");
        }
    }

    public class Notification
    {
        //private readonly EmailService _emailService;
        private readonly IEmailService _emailService;

        public Notification(IEmailService emailService)
        {
            //_emailService = new EmailService();
            _emailService = emailService;
        }

        public void Send(string message)
        {
            _emailService.SendEmail("user@example.com", "Notifaication", message);
        }

        public class MockEmailService : IEmailService
        {
            public void SendEmail(string to, string subject, string body)
            {
                throw new NotImplementedException();
            }
        }
    }

}
