using MagicalFactory.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactory
{
    class House : Product 
    {
        List<Material> houseMats = new List<Material>() { new Glass(), new Wood(), new Glass() };
        public House()
        {
            ProductType = "House";
            blueprint = houseMats;
        }
    }
}
