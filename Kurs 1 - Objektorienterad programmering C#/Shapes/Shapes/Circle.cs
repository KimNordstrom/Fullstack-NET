using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        private double Pi { get { return Math.PI; } }
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            var area = (Pi * Math.Pow(Radius, 2));
            return area;
        }
    }
}
