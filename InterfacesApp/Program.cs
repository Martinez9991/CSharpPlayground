using System.Net.Http.Headers;

namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Eat("Treat");
            //Cat cat = new Cat();
            //cat.MakeSound();
            //cat.Eat("Cat Food");

            //IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            //PaymentService paymentService = new PaymentService(creditCardProcessor);
            //paymentService.ProcessOrderPayment(100.00m);

            //IPaymentProcessor paypalProcessor = new PaypalProcessor();
            //paymentService = new PaymentService(paypalProcessor);
            //paymentService.ProcessOrderPayment(200.00m);

            // The @ sign in C# is used to denote a verbatim string literal
            //string directoryPath = @"C:\Logs";
            //string filePath = Path.Combine(directoryPath, "log.txt");
            //string message = "This is a log entry";

            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}

            //File.AppendAllText(filePath, message + "\n");

            /* Decoupling: The Application Class depends on the Ilogger interface rather than specific
             * implementations like the Filelogger or Databaselogger
             * this means that you can easily switch the loggin mechanism without changing the 
             * Application class
             */

            ILogger filelogger = new FileLogger();
            Application app = new Application(filelogger);
            app.DoWork();

            ILogger databaselogger = new DatabaseLogger();
            app = new Application(databaselogger);
            app.DoWork();


            Console.ReadKey();
        }
    }
}
