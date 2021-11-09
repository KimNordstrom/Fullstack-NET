using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactory
{
    abstract class Material : Storable
    {
        private string _material;
        protected string MaterialType { get; set; }
        public Material()
        {
            _material = MaterialType;
        }
    }
}
