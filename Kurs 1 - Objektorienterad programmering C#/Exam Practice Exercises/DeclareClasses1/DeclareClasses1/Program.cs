using System;

namespace DeclareClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Programmer();
            Console.WriteLine(x.ProduceCode());
            x.DrinkCoffe();
            Console.WriteLine(x.ProduceCode());


            var x2 = new Programmer();
            Console.WriteLine(x2.Age);
            Console.WriteLine(x2.ProduceCode());
            x2.CelebrateBirthday();
            Console.WriteLine(x2.ProduceCode());
            Console.WriteLine(x2.Age);
        }
    }
}
