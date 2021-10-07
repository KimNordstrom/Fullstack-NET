using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : IShape
    {
        private int Side { get; }

        public Square(int side)
        {
            Side = side;
        }
        public double GetArea()
        {
            var area = Side * Side;
            return area;
        }
    }
}
