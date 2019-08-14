using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.Factory
{
    public class WhiteHuman : HuMan
    {
        public override void Talk()
        {
            Console.WriteLine("I am WhiteHuman");
        }
    }
}
