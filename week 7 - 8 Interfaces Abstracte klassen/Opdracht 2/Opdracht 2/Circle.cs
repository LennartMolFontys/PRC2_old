using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Opdracht_2
{
    class Circle : Shape
    {
        public double Radius { get; private set; }
        public override double Area { get { return (Radius * Radius) * 3.14; } }

        public Circle(Point position, Color color, double radius) : base(position, color)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return string.Format("The Area of the Circle is: {0}", Area.ToString());
        }
    }

}
