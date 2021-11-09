using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    abstract class Animal
    {
        //private string _animal;
        private string _animalname;
        private int _legs;
        public int NumberOfLegs { get { return _legs; } }
        //public string AnimalType { get { return _animal; } }
        public string AnimalName { get { return _animalname; } }

        protected Animal(string name,int legs)
        {
            _animalname = name;
            _legs = legs;
        }

        public virtual void Feed(Food food)
        {
            Console.WriteLine($"The {_animalname}({AnimalType()}) is eating {food}");
        } 

        public virtual void Pet()
        {
            Console.WriteLine($"{_animalname} ({AnimalType()}) was petted.");

        }
        public string AnimalType()
        {
            return GetType().Name;
        }
        public string CarnOrHerb()
        {
            return GetType().BaseType.Name;
        }
    }
}
