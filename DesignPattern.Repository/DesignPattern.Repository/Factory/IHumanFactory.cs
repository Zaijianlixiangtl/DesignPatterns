using DesignPatterns.Model.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Factory
{
    public interface IHumanFactory
    {
        HuMan CreateHuman();
    }
}
