using DesignPattern.Repository.TemplateMethod;
using System;

namespace DesignPatterns.Template.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            //模板方法模式
            CookAbstract cookEgg = new CookEgg();
            cookEgg.Cook();
            CookAbstract cookPotato = new CookPotato();
            cookPotato.Cook();

            Console.ReadKey();
        }
    }
}
