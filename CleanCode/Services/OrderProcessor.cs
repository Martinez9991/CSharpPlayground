using CleanCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Services
{
    //Naming Classes and methods
    public class OrderProcessor
    {
        //Naming Boolean fields/Methods/Props
        private bool hasErros = false;
        private bool hasValid = true;

        public void ProcessOrder() //verbs
        { }

        public void PrintOrder()
        { }

        public void DeleteOrder()
        { }


        public void ProcessOrder(Order order)
        {
            //validate order
            if (order.Quantity > 0)
            {
                if (IsValid(order))
                {
                    SaveOrder(order);
                    NotifyOrder(order);
                }

                ////save order
                //Console.WriteLine("Order saved");
                ////notify customer
                //Console.WriteLine("Customer notified");
            }
        }

        public bool IsValid(Order order)
        {
            //TODO: Validate Order logic
            return false;
        }
        private void SaveOrder(Order order)
        {
            //TODO: Save Order logic
        }

        private void NotifyOrder(Order order)
        {
            //TODO: Notify Order logic
        }



    }
}
