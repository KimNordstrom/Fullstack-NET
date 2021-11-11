using Assignment.PartA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AssignmentRunner
    {
        public void RunPartA(Person person)
        {
            Console.WriteLine($"Name is: {person.Name}");
            person.MethodA();
            person.MethodB();
        }

        public void RunPartB(Person person)
        {
            Student x = (Student)person;
            Console.WriteLine($"Name is: {person.Name}");
            person.MethodA();
            x.MethodB();

        }
    }
}
