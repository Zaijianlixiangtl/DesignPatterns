using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Facade
{
    public class Facade : IFacade
    {
        private readonly FileHelper _fileHelper;
        private readonly CipherMachine _cipherMachine;

        public Facade(FileHelper fileHelper,
                            CipherMachine cipherMachine)
        {
            this._fileHelper = fileHelper;
            this._cipherMachine = cipherMachine;
        }

        /// <summary>
        /// 文件加密
        /// </summary>
        /// <param name="fileName"></param>
        public void FileEncryption(string fileName)
        {
            var str = _fileHelper.Read(fileName);
            str = _cipherMachine.Encryption(str);
            _fileHelper.Write(fileName, str);
        }
    }
}
