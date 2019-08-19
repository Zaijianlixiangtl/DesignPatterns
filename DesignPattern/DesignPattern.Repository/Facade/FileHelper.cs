using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPattern.Repository.Facade
{
    public  class FileHelper
    {
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string Read(string fileName)
        {
            Console.WriteLine("读取文件");
            var result = "";
            using (FileStream stream = new FileStream(fileName,FileMode.Open))
            {
                var length = (int)stream.Length;
                byte[] bytes = new byte[length];
                int r = stream.Read(bytes, 0, length);
                result = System.Text.Encoding.UTF8.GetString(bytes);
            }
            return result;
        }

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="body"></param>
        public void Write(string fileName, string body)
        {
            var bytes = Encoding.UTF8.GetBytes(body);
            using (FileStream stream = new FileStream(fileName, FileMode.Truncate))
            {
               
                stream.Write(bytes, 0, bytes.Length);
            }
            Console.WriteLine("写入文件成功：100%");
        }
    }
}
