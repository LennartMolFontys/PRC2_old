using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_3
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            AddStudent();
        }



        private void AddStudent()
        {
           students.Add(new Student("Test", "koempel", 8));
           students.Add(new Student("Aest", "koempel", 5));
           students.Add(new Student("Qest", "koempel", 1));
           students.Add(new Student("Zest", "koempel", 7));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void SortByNameBtn_Click(object sender, EventArgs e)
        {
            students.Sort();
            listBox1.Items.Clear();
            foreach (Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

    }
}
