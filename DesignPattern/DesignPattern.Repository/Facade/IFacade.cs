using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Facade
{
    public interface IFacade
    {
        /// <summary>
        /// 文件加密
        /// </summary>
        /// <param name="fileName"></param>
         void FileEncryption(string fileName);
    }

    public class Facade2 : IFacade
    {
        public void FileEncryption(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }
}
