using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DesignPatterns.Model.Factory;

namespace DesignPattern.Repository.Factory
{
    public class BlackHumanFactory : IHumanFactory
    {
        public HuMan CreateHuman()
        {
            var a = Assembly.LoadFrom($"{AppDomain.CurrentDomain.BaseDirectory}DesignPatterns.Model.dll");
            return (HuMan)a.CreateInstance("DesignPatterns.Model.Factory.BlackHuman");
        }
    }
}
