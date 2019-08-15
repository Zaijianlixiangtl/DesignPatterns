using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Decorator
{
    public class Person
    {
        private readonly string name;

        public Person(string name)
        {
            this.name = name;
        }
        public Person()
        {

        }

        public virtual void Display()
        {
            Console.WriteLine($"装扮的 {name}");
        }
    }
}
