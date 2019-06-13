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
    public partial class PatientForm : Form
    {
        private FileHandler file;
        private List<Patient> Patients;

        private string FilePatients = @"..\..\..\Patients.txt";

        public PatientForm()
        {
            InitializeComponent();
            initForm();
            LoadPatients();

        }

        private void initForm()
        {
            Patients = new List<Patient>();
            file = new FileHandler();
        }

        private void LoadPatients()
        {
            Patients = file.LoadPatients(FilePatients);
            foreach(Patient s in Patients)
            {
                comboBox1.Items.Add(s.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            LoadTreatments(index);
            if(Patients[index].Appointment != null)
            {
                textBox1.Text = Patients[index].Appointment.ToString();
            }
            else
            {
                textBox1.Text = "No Appointments planned";
            }

        }

        private void LoadTreatments(int index)
        {
            listBox1.Items.Clear();
            if(index >= 0)
            {
                foreach (Treatment s in Patients[index].Treatments)
                {
                    listBox1.Items.Add(s.ToString());
                }
            }
        }
    }
}
