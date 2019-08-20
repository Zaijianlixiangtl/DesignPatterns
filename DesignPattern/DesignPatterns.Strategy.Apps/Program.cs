using DesignPattern.Repository.Strategy;
using System;

namespace DesignPatterns.Strategy.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*策略模式   实际应用时，可以与简单工厂配合使用，或者将具体实现类配置保存在配置文件中
             * 
             * （1）提供了对开闭原则的完美支持，用户可以在不修改原有系统的基础上选择具体算法或行为，也可以灵活地增加新的算法或行为。

　　          （2）避免了多重的if-else条件选择语句，利于系统的维护。

　　          （3）提供了一种算法的复用机制，不同的环境类可以方便地复用这些策略类。*/
            IDiscount discountA = new DiscountA();
            var price = discountA.Calculate(18);
            Console.WriteLine(price);
            IDiscount discountB = new DiscountB();
            price = discountB.Calculate(18);
            Console.WriteLine(price);
            Console.ReadKey();
        }
    }
}
