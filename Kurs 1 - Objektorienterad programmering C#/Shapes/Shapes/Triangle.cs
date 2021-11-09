using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : IShape
    {
        private int Height;
        private int Width;

        public Triangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public double GetArea()
        {
            var area = ((Height * Width) / 2.0);
            return area;
        }
    }
}
