using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactory
{
    abstract class Product : Storable
    {
        private string _product;
        protected string ProductType { get; init; }
        public int amountCorrectMaterials = 0;
        public List<Material> leftovers = new List<Material>();
        public List<Material> missing = new List<Material>();

        public List<Material> blueprint;
        public Product()
        {
            _product = ProductType;
        }
        public List<Material> CompareToProducts(List<Material> inMat)
        {
            amountCorrectMaterials = 0;
            leftovers.Clear();
            missing.Clear();
            List<bool> blueCheck = new List<bool>(blueprint.Count) { };
            
            for (int i = 0; i < blueprint.Count; i++)
            {
                blueCheck.Add(false);
            }

            foreach (var item in inMat)
            {
                bool found = false;
                for (int i = 0; i < blueprint.Count; i++)
                {
                    if (blueprint[i].GetType() == item.GetType()) 
                    {
                        if (blueCheck[i] == false)
                        {
                            blueCheck[i] = true;
                            found = true;
                            amountCorrectMaterials++;
                            break;
                        } 
                    }
                }
                if(found == false)
                {
                    leftovers.Add(item);
                }
            }
            for (int i = 0; i < blueCheck.Count; i++)
            {
                if (blueCheck[i] == false)
                {
                    missing.Add(blueprint[i]);
                    break;
                }
            }
            return leftovers;
        }
    }
}
