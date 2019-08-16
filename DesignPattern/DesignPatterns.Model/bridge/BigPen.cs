using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.bridge
{
    public class BigPen : Pen
    {
        public BigPen(Color color) : base(color)
        {
        }

        public override void Wirte(string msg)
        {
            Console.WriteLine($"{this.color.Colour} Big Pen write {msg}");
        }
    }
}
