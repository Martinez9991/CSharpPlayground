using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    internal class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger) 
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work Started!");
            // do all work!
            _logger.Log("Work Done!");
        }
    }
}
