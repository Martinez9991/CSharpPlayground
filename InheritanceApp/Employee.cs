using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Employee : Person
    {
        public string JobTitle{ get; private set; }

        public int EmployeeID { get; set; }

        //Dervied class constructor
        public Employee(string name,int age, string jobTitle, int employeeID) : base(name,age) // Calling the base class constructor
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (derived class) construtor called.");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();//Call method from base class
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }
}
