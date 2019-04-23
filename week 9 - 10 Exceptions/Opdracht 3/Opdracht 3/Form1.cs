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
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertToIntBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(string.Format("Het getal is :  {0} is succesvol ge convert", i.ToString()));
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Vul een getal in");
            }
            catch (OverflowException exception)
            {
                MessageBox.Show(string.Format("Het getal moet tussen de {0} en {1} vallen", int.MinValue.ToString(), int.MaxValue.ToString()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox2.Text;
                string i = x.Substring(0, 3);
                MessageBox.Show(string.Format("Het geknipte stukje is : {0}", i));
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("De tekst moet langer dan 3 karakters zijn");
            }
        }

        // convert to int Exception
        // format exception number not between 0-9
        // overflow exception number lower then minvalue or highter then maxvalue;

        // convert substring Exception

        // argument out of range exception
    }
}
