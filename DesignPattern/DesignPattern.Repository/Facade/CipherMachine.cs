using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DesignPattern.Repository.Facade
{
    public class CipherMachine
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Encryption(string str)
        {
            var result = string.Empty;
            using (var md5 = MD5.Create())
            {
                 var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
                var strResult = BitConverter.ToString(bytes);
                result = strResult.Replace("-", "");
                Console.WriteLine(result);
            }
            return result;
        }
    }
}
