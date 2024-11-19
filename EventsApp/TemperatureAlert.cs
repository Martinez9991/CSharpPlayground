using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    //Subscriber
    internal class TemperatureAlert
    {
        //public void OnTemperatureChanged(string message)
        //{
        //    Console.WriteLine("Alert: "+ message);
        //}

        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: Temperature is {e.Temperature} sender is: {sender}");
        }
    }
}
