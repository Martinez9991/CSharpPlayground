using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    internal class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
