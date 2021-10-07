using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zoo
    {
        private List<Animal> animals;
        string header = String.Format("{0,-15}{1,-15}{2,-15}", "Name", "Animal", "Eater" 
            + "\n----------------------------------------");
        public Zoo(List<Animal> newanimals)
        {
            animals = newanimals;
        }

        public void FeedAllAnimals(Food food)
        {
            foreach (Animal x in animals)
            {
                x.Feed(food);
            }
        }

        public void PetAnimal(string animal)
        {
            bool petted = false;
            foreach (var item in animals)
            {
                if(item.AnimalName == animal)
                {
                    item.Pet();
                    petted = true;
                }
            }
            if(petted == false)
            {
                Console.WriteLine($"No animal by the name {animal}");
            }
        }

        public void ListAnimals()
        {
            Console.WriteLine(header);
            foreach (Animal x in animals)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}", x.AnimalName, x.AnimalType(), x.CarnOrHerb());
            }
        }

        public void ListHerbivores()
        {
            Console.WriteLine(header);
            foreach (Animal x in animals)
            {
                if(x is Herbivore y)
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-15}", x.AnimalName, x.AnimalType(), x.CarnOrHerb());
                }
            }
        }

        public void ListCarnivores()
        {
            Console.WriteLine(header);
            foreach (Animal x in animals)
            {
                if (x is Carnivore y)
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-15}", x.AnimalName, x.AnimalType(), x.CarnOrHerb());
                }
            }
        }
    }
}
