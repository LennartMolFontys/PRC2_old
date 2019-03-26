using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_1
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDogBtn_Click(object sender, EventArgs e)
        {
            Animal animal = new Dog(textBox1.Text);
            animals.Add(animal);
            AddToComboBox();
        }

        private void CreateCatBtn_Click(object sender, EventArgs e)
        {
            Animal animal = new Cat(textBox1.Text);
            animals.Add(animal);
            AddToComboBox();
        }

        private void AddToComboBox()
        {
            comboBox1.Items.Clear();
            foreach(Animal s in animals)
            {
                comboBox1.Items.Add(s.name);
            }
        }

        private void MakeNoiseBTN_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string Sound = animals[index].MakeNoise();
            MessageBox.Show(Sound);
        }
    }
}
