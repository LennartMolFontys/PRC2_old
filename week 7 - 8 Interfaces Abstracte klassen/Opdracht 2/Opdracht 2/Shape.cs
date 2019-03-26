using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Opdracht_2
{
   public abstract class Shape
    {
        public Point Position { get; private set; }
        public Color Color { get; private set; }
        public abstract double Area { get; }

        public Shape(Point position, Color color)
        {
            Position = position;
            Color = color;
        }

        public abstract string ToString();
        
            
        

    }
}
