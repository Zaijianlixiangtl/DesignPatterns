using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.TemplateMethod
{
    public class CookPotato : CookAbstract
    {
        protected override void Addoil()
        {
            Console.WriteLine("放植物油");
        }
        public override void AddFood()
        {
            Console.WriteLine("放土豆");
        }
    }
}
