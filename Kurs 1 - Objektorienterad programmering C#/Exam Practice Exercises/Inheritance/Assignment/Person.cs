using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PartA
{
    class Person
    {
        public virtual string Name
        {
            get
            {
                return "Person.Name";
            }
        }

        public virtual void MethodA()
        {
            Console.WriteLine("Person.MethodA");
        }

        public virtual void MethodB()
        {
            Console.WriteLine("Person.MethodB");
        }
    }
}
