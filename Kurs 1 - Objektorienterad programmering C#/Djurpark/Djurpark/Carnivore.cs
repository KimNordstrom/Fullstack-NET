using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Carnivore : Animal
    {
        List<Food> carnFood = new List<Food>() { Food.Meat, Food.Hamburger };
        public Carnivore(string name, int legs) : base(name, legs)
        {
            
        }

        public override void Feed(Food food)
        {
            Console.WriteLine($"{AnimalName} ({AnimalType()}) is eating {food}");

            if (!carnFood.Contains(food))
            {
                Console.WriteLine($"{AnimalName} ({AnimalType()}) became sick from the food.");
            }
        }

        public override void Pet()
        {
            Console.WriteLine($"{AnimalName} ({AnimalType()}) is a carnivore. You are not allowed to pet a carnivore.");
        }
    }
}
