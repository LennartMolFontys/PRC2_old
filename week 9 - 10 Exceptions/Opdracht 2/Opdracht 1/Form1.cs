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
            AddAnimals();
        }



        private void AddAnimals()
        {
            Animal animal  = new Cat(4, new SimpleDate(1, 2, 2000), "Jerry", "MoonWalking",Gender.Male);
            animals.Add(animal);
            Animal animal1 = new Dog(8, new SimpleDate(1, 2, 2001), "Tommy", new SimpleDate(5, 8, 2012), Gender.female);
            animals.Add(animal1);
            Animal animal2 = new Cat(6, new SimpleDate(1, 2, 2002), "Bert", "Sleeping", Gender.female);
            animals.Add(animal2);
            Animal animal3 = new Dog(9, new SimpleDate(1, 2, 2003), "Luna", new SimpleDate(5, 8, 2013), Gender.Male);
            animals.Add(animal3);
        }

        private void CheckListBtn_Click(object sender, EventArgs e)
        {
            foreach(Animal s in animals)
            {
                if (s is Dog)
                {
                    Dog dog = s as Dog;
                    listBox1.Items.Add(dog.LastWalkDate);
                }
                else if (s is Cat)
                {
                    Cat cat = s as Cat;
                    listBox1.Items.Add(cat.BadHabits);
                }
            }
        }

    }
}
