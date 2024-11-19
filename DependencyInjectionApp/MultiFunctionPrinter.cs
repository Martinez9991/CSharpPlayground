using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp
{
    internal class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document!");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning Document!");
        }
    }
}
