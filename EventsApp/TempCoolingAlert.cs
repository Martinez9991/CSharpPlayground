using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    //Subscriber 2
    internal class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT: Temperature is {e.Temperature} sender is: {sender}");
        }
    }
}
