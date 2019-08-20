using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Strategy
{
    public class DiscountA : IDiscount
    {
        public double Calculate(double price)
        {
            return price * 0.8;
        }
    }
}
