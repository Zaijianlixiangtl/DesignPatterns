using DesignPattern.Repository.Proxy;
using System;

namespace DesignPatterns.Proxy.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearch isearch = new ProxySearch();
            isearch.SearchSomething("Jason","baidu");

            isearch.SearchSomething("LiLei", "baidu");

            Console.ReadKey();
        }
    }
}
