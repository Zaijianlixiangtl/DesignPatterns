using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxySearch : ISearch
    {
        private ISearch _search;
        public ProxySearch()
        {
            _search = new RealSearch();
        }

        /// <summary>
        /// 为真实实现类增加权限控制 及打印日志功能
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="keyWord"></param>
        public void SearchSomething(string userId, string keyWord)
        {
            if (valid(userId))
            {
                Log($"{userId} 通过授权");
                //调用真实实现类的方法
                _search?.SearchSomething(userId,keyWord);
                Log($"{userId} 查询成功");
            }
            else
            {
                Console.WriteLine("sorry,you dont have Authorization");
            }
        }

        /// <summary>
        /// 权限控制
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private bool valid(string userId)
        {
            if (userId == "Jason")
                return true;
            return false;
        }

        /// <summary>
        /// 模拟打日志
        /// </summary>
        /// <param name="msg"></param>
        private void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now}: {msg}");
        }
    }
}
