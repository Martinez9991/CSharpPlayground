namespace EventsApp
{
    internal class Program
    {
        public delegate void Notify(string message);

        //public delegate void TempuratureChangeHandler(string message);

        static void Main(string[] args)
        {
            //EventPublisher publisher = new EventPublisher();
            //EventSubscriber subscriber = new EventSubscriber();
            //publisher.OnNotify += subscriber.OnEventRaised;

            //publisher.RaiseEvent("test");

            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            //monitor.OnTemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
