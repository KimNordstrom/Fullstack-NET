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
            foreach (Product product in products)
            {
                product.CompareToProducts(incomingMaterials);
                if(product.amountCorrectMaterials > correctNumber)
                {
                    correctNumber = product.amountCorrectMaterials;
                    if (product.amountCorrectMaterials == product.blueprint.Count)
                    {
                        rightmatch = product;
                        Console.Clear();
                        Console.WriteLine($"Found match: {rightmatch.GetType().Name}. Creating it.");
                        if (product.leftovers.Count > 0)
                        {
                            Console.Write("Leftovers from production: ");
                            foreach (Material material in rightmatch.leftovers)
                            {
                                Console.Write(material.GetType().Name);
                            }
                        } else
                        {
                            Console.WriteLine("No leftovers");
                        }
                    } else
                    {
                        rightmatch = product;
                        Console.Clear();
                        Console.WriteLine($"Closest match: {rightmatch.GetType().Name}. Used magic to create it.");
                        Console.WriteLine(product.missing.Count);
                        Console.Write("Missing materials: ");
                        foreach (var item in rightmatch.missing)
                        {
                            Console.Write(item.GetType().Name);
                        }
                    }
                    
                }
            }
            
            Console.WriteLine("\nPress to continue.");
            Console.ReadLine();
            Console.Clear();
            return rightmatch;
        }
    }
}
