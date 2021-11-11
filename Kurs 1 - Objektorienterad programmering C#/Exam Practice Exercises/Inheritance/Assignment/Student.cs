using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PartA
{
    class Student : Person
    {
        public override string Name
        {
            get
            {
                return "Student.Name";
            }
        }

        public override void MethodA()
        {
            Console.WriteLine("Student.MethodA");
        }

        public void MethodB()
        {
            Console.WriteLine("Student.MethodB");
        }
    }
}
