using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace OOUppgift
{
    class Person
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Backpack Backpack { get; }
        public Person(string name, Backpack backpack = null)
        {
            Name = name;
            Speed = 5;
            Backpack = backpack ?? new Backpack();
        }
        public void Run()
        {
            Console.WriteLine($"{Name} runs at {Speed}km/h!");
        }

        public void LookInBag()
        {
            var snacks = string.Join(", ", Backpack.Snacks);
            Console.WriteLine($"{Name} looks in the {Backpack.Brand} and sees {snacks}");
        }
        public void Eat()
        {
            var randSnack = Backpack.Snacks[new Random().Next(0, 3)];
            Console.WriteLine($"{Name} takes a bite of {randSnack}");
        }
    }
}
