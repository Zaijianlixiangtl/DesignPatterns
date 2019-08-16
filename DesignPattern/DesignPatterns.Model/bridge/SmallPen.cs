using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.bridge
{
    public  class SmallPen : Pen
    {
        public SmallPen(Color color) : base(color)
        {
        }

        public override void Wirte(string msg)
        {
            Console.WriteLine($"{this.color.Colour} Small Pen write {msg}");
        }
    }
}
