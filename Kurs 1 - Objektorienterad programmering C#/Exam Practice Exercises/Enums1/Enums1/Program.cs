using System;
using System.Collections.Generic;

namespace Enums1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderSystem orderSystem = new OrderSystem();

            List<Sweater> smallSweaters = orderSystem.ListSweaters(ClothesSize.S);
            Console.WriteLine($"We got {smallSweaters.Count} small sweaters");

            orderSystem.AddSweater("Green sweater", ClothesSize.L);
        }
    }
}
