using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactory
{
    class Factory
    {
        private List<Product> products = new List<Product>() { new House(), new Car()};

        public Factory()
        {

        }

        public void ListAllProducts()
        {
            foreach (Product x in products)
            {
                Console.WriteLine(x.GetType().Name);
            }
        }

        public Product CreateProductFrom(List<Material> incomingMaterials)
        {
            int correctNumber = 0;
            Product rightmatch = null;
            foreach (Product x in products)
            {
                x.CompareToProducts(incomingMaterials);
                if(x.amountCorrectMaterials > correctNumber)
                {
                    correctNumber = x.amountCorrectMaterials;
                    rightmatch = x;
                }
            }
            Console.Clear();
            Console.WriteLine($"Found match: {rightmatch.GetType().Name}. Creating it.");
            Console.Write("Leftovers from production: ");
            foreach (Material x in rightmatch.leftovers)
            {
                Console.Write(x.GetType().Name);
            }
            Console.WriteLine("\nPress to continue.");
            Console.ReadLine();
            return rightmatch;
        }
    }
}
