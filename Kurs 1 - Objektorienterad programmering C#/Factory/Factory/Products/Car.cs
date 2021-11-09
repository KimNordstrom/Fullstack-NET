using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicalFactory.Materials;

namespace MagicalFactory
{
    class Car : Product
    {
        List<Material> carMats = new List<Material>() { new Steel(), new Glass(), new Rubber() };
        public Car()
        {
            ProductType = "Car";
            blueprint = carMats;
        }
    }
}
