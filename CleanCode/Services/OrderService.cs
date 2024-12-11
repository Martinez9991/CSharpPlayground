using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.Models;

namespace CleanCode.Services
{
    //Single Responsability Principle(SRP)
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        private OrderLogger orderLogger = new OrderLogger();
        private OrderNotifier orderNotifier = new OrderNotifier();

        public void AddOrder(Order order)
        {
            orders.Add(order);
            orderLogger.LogOrder(order);
            orderNotifier.NotifyCustomer(order);
            //LogOrder(order);
            //NotifyCustomer(order);
        }

        //private void LogOrder(Order order)
        //{
        //    //Log the order to a file
        //    Console.WriteLine($"Order {order.Id} logged.");
        //}

        //private void NotifyCustomer(Order order)
        //{
        //    // send a notification to the customer
        //    Console.WriteLine($"Customer notified for order {order.Id}.");
        //}

    }

    public class OrderLogger
    {
        public void LogOrder(Order order)
        {
            //Log the order to a file
            Console.WriteLine($"Order {order.Id} logged.");
        }
    }

    public class OrderNotifier
    {
        public void NotifyCustomer(Order order)
        {
            // send a notification to the customer
            Console.WriteLine($"Customer notified for order {order.Id}.");
        }
    }

}
