using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            //Implement the logic to log a message to the database
            Console.WriteLine($"Logging into database. {message}");
        }
    }
}
