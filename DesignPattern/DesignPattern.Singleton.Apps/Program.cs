using DesignPattern.Repository.Singleton;
using System;

namespace DesignPattern.Singleton.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            //三次打印相同的hashcode 使用的同一个实例
            for (int i = 0; i < 3; i++)
            {
                //饿汉
                SingletonA singletonA = SingletonA.GetInstance();
                singletonA.PrintMsg();
            }

            //三次打印相同的hashcode 使用的同一个实例
            for (int i = 0; i < 3; i++)
            {
                //懒汉
                SingletonB singletonB = SingletonB.GetInstance();
                singletonB.PrintMsg();
            }

            Console.ReadKey();
        }
    }
}
