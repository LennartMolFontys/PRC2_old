using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Opdracht_2
{
    class Square : Shape
    {
        public double Size { get; private set; }
        public override double Area { get { return Size * Size; } }

        public Square (Point position, Color color, double size) : base (position,color)
        {
            Size = size;
        }

        public override string ToString()
        {
            return string.Format("The Area of the Square is: {0}", Area.ToString());
        }
    }
}
