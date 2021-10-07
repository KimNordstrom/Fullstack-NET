using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fåglar
{
    abstract class Bird
    {
        public string Species { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine($"The {Species} flies!");
        }
    }
}
