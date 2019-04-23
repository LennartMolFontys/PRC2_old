using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class Square : Shape
    {
        public double Size { get; private set; }
        public override double Area { get { return Size * Size; } }

        public Square(Point position, Color color, double size) : base(position,color)
        {
            Size = size;
        }
        public override void DrawTo(Graphics drawingSurface)
        {
            Pen pen = new Pen(Color, 5);
            drawingSurface.DrawRectangle(pen,500, 199, Convert.ToInt32(Area/2), Convert.ToInt32(Area / 2));
            drawingSurface.Dispose();
        }

        public override string ToString()
        {
            return string.Format("The Size of te Square is :{0} & ", Size) + base.ToString();
        }
    }
}
