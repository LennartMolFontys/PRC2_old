using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_2
{
    public partial class Form1 : Form
    {
        private List<Shape> Shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCircleBtn_Click(object sender, EventArgs e)
        {
            double radius;
            bool BoolCheckForDouble = double.TryParse(CircleTextBox.Text, out radius);
            Shape shape = new Circle(Point.Empty, Color.Blue, radius);
            ShapeListBox.Items.Add(shape.ToString());
        }

        private void AddSquareBtn_Click(object sender, EventArgs e)
        {
            double size;
            bool BoolCheckForDouble = double.TryParse(SquareTextBox.Text, out size);
            Shape shape = new Square(Point.Empty, Color.Red, size);
            ShapeListBox.Items.Add(shape.ToString());
        }
    }
}
