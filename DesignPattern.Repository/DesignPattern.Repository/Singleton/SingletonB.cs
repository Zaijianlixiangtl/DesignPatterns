using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Singleton
{
    /// <summary>
    /// 懒汉单例模式   使用时再初始化对象
    /// </summary>
    public class SingletonB
    {
        private static SingletonB _singleton = null;

        private static object locker = new object();
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private SingletonB() { }

        /// <summary>
        /// Get Singleton Instance
        /// </summary>
        /// <returns></returns>
        public static SingletonB GetInstance()
        {
            //双重检查加锁机制
            if (_singleton == null)
            {
                lock (locker)
                {
                    if (_singleton == null)
                    {
                        _singleton = new SingletonB();
                    }
                }
            }
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
