using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fåglar
{
    class Ostrich : Bird
    {
        public Ostrich()
        {
            Species = "Ostrich";
        }

        public override void Fly()
        {
            Console.WriteLine($"The {Species} can not fly!");
        }
    }
}
