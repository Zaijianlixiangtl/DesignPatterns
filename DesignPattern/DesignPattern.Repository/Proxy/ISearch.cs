using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Proxy
{
    /// <summary>
    /// 查询接口
    /// </summary>
    public interface ISearch
    {
        /// <summary>
        /// 查询某些事情
        /// </summary>
        /// <param name="keyWord"></param>
        void SearchSomething(string userId, string keyWord);
    }
}
