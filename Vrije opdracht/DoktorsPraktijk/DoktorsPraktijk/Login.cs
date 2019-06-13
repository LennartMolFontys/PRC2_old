using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoktorsPraktijk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(UserName.Text.ToUpper() == "ADMIN" && PassWord.Text.ToUpper() == "ADMIN")
            {
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or PassWord");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientForm patients = new PatientForm();
            patients.Show();
        }
    }
}
