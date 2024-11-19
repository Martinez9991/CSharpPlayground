using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp
{
    internal class Builder : IToolUser
    {

        //public Hammer Hammer { get; set; }
        //public Saw Saw { get; set; }
        private Hammer _hammer;
        private Saw _saw;

        //Constructor Dependency Injection(DI)
        //public Builder(Hammer hammer,Saw saw) 
        //{
        //    _hammer = hammer; 
        //    _saw = saw;
        //}

        //public Builder()
        //{
        //    _hammer = new Hammer(); // Builder is responsible for creating its dependencies
        //    _saw = new Saw();
        //}

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House Built!");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }

        //public void BuildHouse()
        //{
        //    Hammer.Use();
        //    Saw.Use();
        //    Console.WriteLine("House Built!");
        //}

    }
}
