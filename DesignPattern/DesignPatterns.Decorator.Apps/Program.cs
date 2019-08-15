using DesignPattern.Repository.Decorator;
using System;

namespace DesignPatterns.Decorator.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Jason ");
            var tshirt = new TShirt();
            var path = new Path();
            var dress = new Dress();
            tshirt.Decorator(person);
            path.Decorator(tshirt);
            dress.Decorator(path);

            dress.Display();

            Console.ReadKey();
        }
    }
}
