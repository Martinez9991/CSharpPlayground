using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Services
{
    /// <summary>
    /// Provides functionalities fro handling customers
    /// </summary>
    /// <param name="customerId">the id for the customer to retrive</param>
    /// <returns>returns the customer found by name</returns>
    internal class CustomerService
    {
        public const int MAX_CUSTOMERS = 100; //ALL_CAPS

        public int CustomerCount { get; set; } //Pascal Case(proprety)

        private string lastCustomerName = "John"; //camelCase(private fields)
        private string _customerName = "John"; //camelCase with underscore(private fields)

        public string GetCustomerName(int customerId) //camelCase(parameter)
        {
            string customerName = "John Doe"; //camelCase(local variable)
            return customerName;
        }

        public CustomerService(string customerName)
        {
            _customerName = customerName;
            //customerName = customerName --might cause conflict
            this.lastCustomerName = customerName;
        }

        //bad 
        public void Save()
        {

        }

        //good
        public void SaveCustomer()
        {

        }

        public void SaveCustomerName()
        {

        }

        //IS , GET ,SET , HAS , CAN
        public void SetCustomerName()
        {

        }

        public bool HasErrors()
        {
            return false;
        }

        public bool CanReceiveEmails()
        {
            return true;
        }
    }
}
