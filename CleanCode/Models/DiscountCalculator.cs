using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Models
{
    public enum CustomerType
    {
        Regular,
        Premium,
        Employee
    }
    public class DiscountCalculator
    {
        private const int DISCOUNT_THRESHOLD = 1000;

        //DRY
        // this function does all of the function that the other calculate functions do in one method
        public double CalculateDiscount(CustomerType customerType, double totalAmount)
        {
            double discount = 0;
            switch (customerType)
            {
                case CustomerType.Regular:
                    discount = totalAmount > DISCOUNT_THRESHOLD ? 0.10 : 0.05;
                    break;
                case CustomerType.Premium:
                    discount = totalAmount > DISCOUNT_THRESHOLD ? 0.15 : 0.10;
                    break;
                case CustomerType.Employee:
                    discount = totalAmount > DISCOUNT_THRESHOLD ? 0.20 : 0.15;
                    break;
                default:
                    break;
            }
            return totalAmount * discount;
        }

        //public double CalculateDiscountForRegularCustomer(double totalAmount)
        //{
        //    if (totalAmount > 1000)
        //    {
        //        return totalAmount * 0.1; // 10% discount
        //    }
        //    else
        //    {
        //        return totalAmount * 0.05; // 5% discount
        //    }
        //}

        //public double CalculateDiscountForPremiumCustomer(double totalAmount)
        //{
        //    if (totalAmount > 1000)
        //    {
        //        return totalAmount * 0.15; // 15% discount
        //    }
        //    else
        //    {
        //        return totalAmount * 0.10; // 10% discount
        //    }
        //}

        //public double CalculateDiscountForEmployeeCustomer(double totalAmount)
        //{
        //    if (totalAmount > 1000)
        //    {
        //        return totalAmount * 0.20; // 20% discount
        //    }
        //    else
        //    {
        //        return totalAmount * 0.15; // 15% discount
        //    }
        //}
    }
}
