using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Herbivore : Animal
    {

        List<Food> herbFood = new List<Food>() { Food.Veggies, Food.Grass };
        public Herbivore(string name, int legs) : base(name, legs)
        {
            
        }

        public override void Feed(Food food)
        {
            Console.WriteLine($"{AnimalName} ({AnimalType()}) is eating {food}");

            if (!herbFood.Contains(food))
            {
                Console.WriteLine($"{AnimalName} ({AnimalType()}) became sick from the food.");
            }
        }
    }
}
