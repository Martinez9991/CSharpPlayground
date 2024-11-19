using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    // Base Class (Parent or Superclass): the class whose members are inherited
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal make a generic sound");
        }
    }
}
