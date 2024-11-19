using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    // Derived Class(Child Class or SubClass)
    // The Class that inherits the members of the base class.
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }
}
