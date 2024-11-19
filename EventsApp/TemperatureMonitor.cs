using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventsApp.Program;

namespace EventsApp
{
    internal class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TempuratureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature 
        {
            get
            {
                return _temperature;
            }
            set 
            {
                //_temperature = value;
                //if (_temperature > 30)
                //{
                //    //Raise Event!!!
                //    RaiseTemperatureChangedEvent("Temperature is above threshold");
                //}

                if (_temperature != value) 
                {
                    _temperature = value;
                    //Raise event!!!!
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        //protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs e)
        //{
        //    OnTemperatureChanged?.Invoke(e);
        //}

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            //Letting every subscriber know!
            TemperatureChanged?.Invoke(this,e);
        }


    }
}
