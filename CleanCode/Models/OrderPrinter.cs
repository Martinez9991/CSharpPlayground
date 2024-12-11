using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Models
{
    public class OrderPrinter
    {
        //KISS
        public void PrintOrderDetails(List<Order> orders)
        {
            double totalPrice = 0;
            foreach (var order in orders)
            {
                if (order.Quantity > 0 && order.Price > 0)
                {
                    double total = order.Quantity * order.Price;
                    Console.WriteLine("Order ID : " + order.Id);
                    Console.WriteLine("Product : " + order.ProductName);
                    Console.WriteLine("Quantity : " + order.Quantity);
                    Console.WriteLine("Price : " + order.Price);
                    Console.WriteLine("Total : " + total);
                    Console.WriteLine("----------");
                    totalPrice += order.Quantity * order.Price;
                }
            }

            Console.WriteLine("Total Price: " + totalPrice);
            //foreach (var order in orders) 
            //{
            //    if (order.Quantity > 0 && order.Price > 0)
            //    {
            //        double total = order.Quantity * order.Price;
            //        Console.WriteLine("Order ID : " + order.Id);
            //        Console.WriteLine("Product : " + order.ProductName);
            //        Console.WriteLine("Quantity : " + order.Quantity);
            //        Console.WriteLine("Price : " + order.Price);
            //        Console.WriteLine("Total : " + total);
            //        Console.WriteLine("----------");
            //    }
            //}

            //double totalPrice = 0;
            //foreach (var order in orders)
            //{
            //    if (order.Quantity > 0 && order.Price > 0)
            //    {
            //        totalPrice += order.Quantity * order.Price;
            //    }
            //}
            //Console.WriteLine("Total Price: " + totalPrice);
        }
    }
}
