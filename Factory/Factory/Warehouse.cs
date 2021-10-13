using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicalFactory.Materials;

namespace MagicalFactory
{
    class Warehouse
    {
        public List<Storable> inventory = new List<Storable>() { new Glass(), new Glass(), new Steel() , new Wood() , new Wood() , new Rubber() , new Wool() };

        public Warehouse()
        {

        }
        public void ListStorage()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].GetType().Name}");
            }
        }
        public void AddToStorage(List<Material> list)
        {
            inventory.AddRange(list);
        }
    }
}
