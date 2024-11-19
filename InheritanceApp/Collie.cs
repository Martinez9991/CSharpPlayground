using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InheritanceApp
{
    //bread of dog
    internal class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts!");
        }
    }
}
