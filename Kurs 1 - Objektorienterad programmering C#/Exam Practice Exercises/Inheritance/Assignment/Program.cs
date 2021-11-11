using Assignment.PartA;
using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignmentRunner partARunner = new AssignmentRunner();
            Student person = new Student();

            Console.WriteLine("Part A");
            partARunner.RunPartA(person);
            Console.WriteLine("-----");

            Console.WriteLine("Part B");
            partARunner.RunPartB(person);
            Console.WriteLine("-----");
        }
    }
}
