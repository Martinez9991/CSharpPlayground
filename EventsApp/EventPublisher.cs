using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventsApp.Program;

namespace EventsApp
{
    internal class EventPublisher
    {
        /*
         * The "On" prefix makes it immediately clear that the method
         * is associated with an event it signifies that the method is not just regular method
         * but one that is called when specific event occurs
        */
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message); // Invoke the even if there are any subcribers
        }
    }
}
