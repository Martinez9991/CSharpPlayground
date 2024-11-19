using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        //Static field to hold the next ID available
        private static int nextId = 0;
        //Read-only instance field intialized fromt he construtor
        private readonly int _id;

        //Backing field for write only property
        private string _password;

        public string Password 
        {
            set 
            {
                _password = value;
            }
        }



        //Read-Only property
        public int Id 
        {
            get 
            {
                return _id;
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContatctNumber { get; set; }

        //Default Construtor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "No Address";
            ContatctNumber = "None";
        }

        /*
        // Custom Construtor
        public Customer(string name, string address, string contactnumber)
        {
            Name = name;
            Address = address;
            ContatctNumber = contactnumber;
        }*/

        //Default/Optional paramenter address contactnumber
        //Custom Contructor
        public Customer(string name,string address = "NA", string contactnumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContatctNumber = contactnumber;
        }

        //Default Paramenter contact number
        public void SetDetails(string name, string address, string contactnumber = "NA")
        {
            Name = name;
            Address = address;
            ContatctNumber = contactnumber;
        }

        public void Getdetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and ID is {_id}");
        }

        public static void DoSomeCustomerStuff() 
        {
            Console.WriteLine("I'm doing some customer stuff");
        }

    }
}
