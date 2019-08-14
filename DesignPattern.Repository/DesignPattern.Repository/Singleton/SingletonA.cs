using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Singleton
{
    /// <summary>
    /// 饿汉单例模式  提前初始化对象
    /// </summary>
    public  class SingletonA
    {
        /// <summary>
        /// 提前初始化实例
        /// </summary>
        private static SingletonA _singleton = new SingletonA();
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private SingletonA() { }

        /// <summary>
        /// Get Singleton Instance
        /// </summary>
        /// <returns></returns>
        public static SingletonA GetInstance()
        {
            return _singleton;
        }

        /// <summary>
        /// do something
        /// </summary>
        public void PrintMsg()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
