using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.bridge
{
    public class MiddlePen : Pen
    {
        public MiddlePen(Color color) : base(color)
        {
        }

        public override void Wirte(string msg)
        {
            Console.WriteLine($"{this.color.Colour} Middle Pen write {msg}");
        }
    }
}
