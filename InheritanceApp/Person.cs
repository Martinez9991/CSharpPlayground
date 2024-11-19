using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        //Base class constructor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person construtor called.");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age : {Age}");
        }

        /// <summary>
        /// Makes our object older!
        /// </summary>
        /// <param name="years">The parameter that indidcates the ammout of years of the object should age</param>
        /// <returns>Return the new age after aging/becoming older</returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;

            return Age;
        }

    }
}
