using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Proxy
{
    /// <summary>
    /// 查询接口实现类
    /// </summary>
    public class RealSearch : ISearch
    {
        public void SearchSomething(string userId, string keyWord)
        {
            Console.WriteLine($"this is  {keyWord}`s answer");
        }
    }
}
