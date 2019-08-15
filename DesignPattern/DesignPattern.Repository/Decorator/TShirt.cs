using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Decorator
{
    public class TShirt : Finery
    {
        public override void Display()
        {
            Console.WriteLine(" Tshirt ");
            base.Display();
        }
    }

    public class Path : Finery
    {
        public override void Display()
        {
            Console.WriteLine(" Path ");
            base.Display();
        }
    }

    public class Dress : Finery
    {
        public override void Display()
        {
            Console.WriteLine(" Dress ");
            base.Display();
        }
    }
}
