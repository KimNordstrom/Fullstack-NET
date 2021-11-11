using System;

namespace Exam
{
    class Conditions
    {
        private int i1 = 15;
        private int i2 = 150;
        private int i3 = 356;
        private bool b1 = false;
        private bool b2 = false;
        private string s1 = "";
        private string s2 = null;

        public void Condition()
        {
            bool a = (i1 >= 30); // Replace 'false' with your solution
            bool b = (i1 < 0 && i2 > 100); // Replace 'false' with your solution
            bool c = (b1 || b2); // Replace 'false' with your solution
            bool d = (s1 == null); // Replace 'false' with your solution
            bool e = ((i1 < 20 && i1 > 10) || i3 == 100); // Replace 'false' with your solution
            bool f = (s1 == null || (s2 == null && i3 >= 200)); // Replace 'false' with your solution
            Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
        }
    }
}
