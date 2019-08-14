using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.Factory
{
    public class BlackHuman : HuMan
    {
        public override void Talk()
        {
            Console.WriteLine("I am BlackHuman");
        }
    }
}
