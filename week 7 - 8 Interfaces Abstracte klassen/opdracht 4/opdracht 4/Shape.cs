using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    public abstract class Shape : Idrawable
    {
        public Point Position { get; private set; }
        public Color Color { get; private set; }
        public  abstract double Area { get; }

        public Shape(Point position, Color color)
        {
            Position = position;
            Color = color;
        }
        public abstract void DrawTo(Graphics drawingSurface);

        public override string ToString()
        {
            return string.Format("the Area is: {0}", Area.ToString());
        }


    }
}
