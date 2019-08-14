using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.TemplateMethod
{
    public abstract class CookAbstract
    {
        /// <summary>
        /// 炒菜
        /// </summary>
        public  void Cook()
        {
            Addoil();
            AddFood();
            AddSalt();
            Fry();
        }
        /// <summary>
        /// 加油
        /// </summary>
        protected virtual void Addoil()
        {
            Console.WriteLine("加豆油");
        }
        /// <summary>
        /// 加盐
        /// </summary>
        private void AddSalt()
        {
            Console.WriteLine("加盐");
        }
        /// <summary>
        /// 加原材料
        /// </summary>
        public abstract void AddFood();
        /// <summary>
        /// 翻炒
        /// </summary>
        private void Fry()
        {
            Console.WriteLine("翻炒");
        }
    }
}
