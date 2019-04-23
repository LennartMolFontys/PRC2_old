using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_4
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private bool ShowPainting = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            ShowPainting = true;
            if(ShowPainting == true)
            {
                Refresh();
            }


      
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grap = e.Graphics;
            shapes[0].DrawTo(grap);
        }

        private void AddSquareBtn_Click(object sender, EventArgs e)
        {
            double size;
            bool BoolCheckForDouble = double.TryParse(SquareTextBox.Text, out size);
            Shape shape = new Square(Point.Empty, Color.Red, size);
            ShapeListBox.Items.Add(shape.ToString());
            comboBox1.Items.Add(shape.ToString());
        }

        private void AddCircleBtn_Click(object sender, EventArgs e)
        {
            double radius;
            bool BoolCheckForDouble = double.TryParse(CircleTextBox.Text, out radius);
            Shape shape = new Circle(Point.Empty, Color.Blue, radius);
            ShapeListBox.Items.Add(shape.ToString());
            comboBox1.Items.Add(shape.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shape shape = new Square(Point.Empty, Color.Red, 10);
            shapes.Add(shape);
            foreach (Shape s in shapes)
            {
                ShapeListBox.Items.Add(s);
            }
        }
    }
}
