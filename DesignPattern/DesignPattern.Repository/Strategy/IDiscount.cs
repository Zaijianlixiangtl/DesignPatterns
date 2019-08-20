using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Strategy
{
    public interface IDiscount
    {
        double Calculate(double price);
    }
}
