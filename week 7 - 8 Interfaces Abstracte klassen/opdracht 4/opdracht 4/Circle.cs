using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class Circle : Shape
    {
        public double Radius { get; private set; }
        public override double Area { get { return (Radius * Radius) * 3.14; } }

        public Circle(Point position, Color color, double radius) : base(position, color)
        {
            Radius = radius;
        }

        public override void DrawTo(Graphics drawingSurface)
        {
            Pen pen = new Pen(Color, 5);
            drawingSurface.DrawEllipse(pen, 343,842, Convert.ToInt32(Area / 3.14), Convert.ToInt32(Area / 3.14));
            drawingSurface.Dispose();
        }

        public override string ToString()
        {
            return string.Format("The Radius of te Circle is :{0} & ", Radius) + base.ToString();
        }


    }
}
