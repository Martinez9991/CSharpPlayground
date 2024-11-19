using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    //It's internal, which means that
    //it can only be acessed from
    //within the same assembly
    internal class Car
    {
        //static "fields"
        public static int NumberOfCars = 0;

        //member variable
        // private hides the variable from other classes
        //private string _model = "";
        private string _brand = "";
        //private bool _isLuxury;

        // Property
        //With lambda expressions
        //public string Model { get => _model; set => _model = value; }

        public string Model { get; set; }

        public string Brand {

            get 
            {
                if (IsLuxury)
                {
                    return _brand + " -  Luxury Edition";
                }
                else 
                {
                    return _brand;
                }
            }

            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get; set; }

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Custom Construtor
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {Brand} of the model {Model} has been created!" );
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm in a {Model} and I'm driving!");
        }


    }
}
