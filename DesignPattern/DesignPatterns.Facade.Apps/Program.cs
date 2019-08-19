using DesignPattern.Repository.Facade;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatterns.Facade.Apps
{

    class Program
    {
        static void Main(string[] args)
        {
            //外观模式
            /*
             　（1）对客户端屏蔽了子系统组件，减少了客户端需要处理的对象数量并且使得子系统使用起来更加容易。

　　          （2）实现了子系统与客户端之间松耦合。

　　          （3）提供了一个访问子系统的统一入口，并不影响客户端直接使用子系统。
             */
            var services = new ServiceCollection();
            services.AddTransient(typeof(FileHelper));
            services.AddTransient(typeof(CipherMachine));
            services.AddTransient<Facade2>();
            services.AddTransient< DesignPattern.Repository.Facade.Facade> ();

            //同一接口 不同实现类的注入方法
            services.AddTransient(factory => {
                Func<string, IFacade> func = key =>
                {
                    if (key == "a")
                        return factory.GetService<Facade2>();
                    else
                        return factory.GetService<DesignPattern.Repository.Facade.Facade>();
                };
                return func;
            });
           var provider = services.BuildServiceProvider();

            var servicelist = provider.GetService<Func<string, IFacade>>();

            var facade2 = servicelist("a");
            facade2.FileEncryption(AppDomain.CurrentDomain.BaseDirectory + "a.Txt");

            var facade = servicelist("b");
            facade.FileEncryption(AppDomain.CurrentDomain.BaseDirectory + "a.Txt");

            Console.Read();
        }
    }
}
