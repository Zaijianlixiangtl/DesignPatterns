using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository.Decorator
{
    public class Finery : Person
    {
        private Person person;

        public void Decorator(Person person)
        {
            this.person = person;
        }
        public override void Display()
        {
            if (person != null)
            {
                person.Display();
            }
        }
    }
}
