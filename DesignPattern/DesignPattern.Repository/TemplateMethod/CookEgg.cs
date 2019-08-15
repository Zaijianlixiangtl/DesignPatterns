using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.TemplateMethod
{
    public class CookEgg : CookAbstract
    {
        public override void AddFood()
        {
            Console.WriteLine("放鸡蛋");
        }
    }
}
