using DesignPatterns.Model.Enum;
using DesignPatterns.Model.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.SimpleFactory
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public static class SimpleFactory
    {
        public static HuMan CreateHuman(HumanEnum humanEnum)
        {
            HuMan huMan = null;
            switch (humanEnum)
            {
                case HumanEnum.Black:
                    huMan = new BlackHuman();
                    break;
                case HumanEnum.White:
                    huMan = new WhiteHuman();
                    break;
                default:
                    throw new NullReferenceException();
            }
            return huMan;
        }
    }
}
