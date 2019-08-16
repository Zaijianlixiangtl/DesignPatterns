using DesignPatterns.Model.bridge;
using System;

namespace DesignPatterns.Bridge.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 桥接模式  
             * 分离抽象接口及其实现部分->桥接模式使用“对象间的关联关系”解耦了抽象和实现之间固有的绑定关系，使得抽象和实现可以沿着各自的维度变化
             * 取代多层继承方案->极大地减少了子类的个数
             * 提高了系统可扩展性->在两个变化维度中任意扩展一个维度，都不需要修改原有系统，符合开闭原则*/

            //大小和颜色是两个不同的维度,是两种不同的抽象
            Pen bigPen = new BigPen(new RedColor());
            bigPen.Wirte("大公鸡");

            Pen smallPen = new SmallPen(new BlackColor());
            smallPen.Wirte("小鸡鸡");

            Console.ReadKey();
        }
    }
}
