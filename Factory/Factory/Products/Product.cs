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

        public List<Material> blueprint;
        public Product()
        {
            _product = ProductType;
        }
        public List<Material> CompareToProducts(List<Material> inMat)
        {
            
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
                        }
                    }
                }
                if(found == false)
                {
                    leftovers.Add(item);
                }
            }
            
            if (blueCheck.All(x => x))
            {
                amountCorrectMaterials = blueCheck.Count;
                return leftovers;
            } else { return null; }
        }
    }
}
