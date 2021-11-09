using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zebra : Herbivore
    {
        List<Food> zebraFoods = new List<Food>() { Food.Grass, Food.Veggies };
        public Zebra(string name) : base(name, 4)
        {
            
        }
    }
}
