using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Strategy
{
    public class DiscountB : IDiscount
    {
        public double Calculate(double price)
        {
            if (price > 8)
            {
                price -= 2;
            }
            return price;
        }
    }
}
