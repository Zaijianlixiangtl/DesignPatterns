using DesignPattern.Repository.Factory;
using DesignPattern.Repository.SimpleFactory;
using DesignPatterns.Model.Enum;
using System;

namespace DesignPatterns.Factory.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式
            var whiteHuman1 =  SimpleFactory.CreateHuman(HumanEnum.White);
            var blackHuman1 = SimpleFactory.CreateHuman(HumanEnum.Black);
            whiteHuman1.Talk();
            blackHuman1.Talk();

            //工厂模式
            var iWhiteHumanFactory = new WhiteHumanFactory();
            var whiteHuman2 =  iWhiteHumanFactory.CreateHuman();
            whiteHuman2.Talk();
            var iBlackHumanFactory = new BlackHumanFactory();
            var blackHuman2 = iBlackHumanFactory.CreateHuman();
            blackHuman2.Talk();

            Console.ReadKey();
        }
    }
}
