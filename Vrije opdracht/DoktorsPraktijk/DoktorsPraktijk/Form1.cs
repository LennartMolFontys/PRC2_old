using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace DoktorsPraktijk
{
    public partial class Form1 : Form
    {
        private Administration AdminiStration;
        private bool check;
        private SaveFileDialog saveFile;
        private OpenFileDialog LoadFile;

        private string FilePatients = @"..\..\..\Patients.txt";
        private string FileDoctors = @"..\..\..\Doctors.txt";
        private string FileAppointments = @"..\..\..\Appointments.txt";

        public Form1()
        {
            InitializeComponent();
            AdminiStration = new Administration();
            saveFile = new SaveFileDialog();
            LoadFile = new OpenFileDialog();
            SetCustomDatePicker();
            AddBeginDoctorAndPatient();
            FillBoxes();
        }

        private void Add_Patient_btn_Click(object sender, EventArgs e)
        {
            string firstname = txb_FirstnamePatient.Text;
            string lastname = tbx_LastNamePatient.Text;
            try
            {
                CheckForInt(firstname);
                CheckForInt(lastname);
                check = AdminiStration.AddPatient(new Patient(firstname, lastname, new SimpleDate(Birthday_Patient.Value.Day, Birthday_Patient.Value.Month, Birthday_Patient.Value.Year)));
                if (check)
                {
                    FillBoxes();
                    MessageBox.Show("Patient added");
                }
            }
            catch (ArgumentException exception) {
                MessageBox.Show(exception.Message);
            }
            catch (IntExecption)
            {
                MessageBox.Show("Firstname and Secondname cannot contain integer");
            }
        }

        private void Add_Dokter_btn_Click(object sender, EventArgs e)
        {
            string firstName = DokterFirstName_tbx.Text;
            string secondName = DoktorSecondName_tbx.Text;

            try
            {
                CheckForInt(firstName);
                CheckForInt(secondName);
                check = AdminiStration.AddDoctor(new Doctor(firstName, secondName, new SimpleDate(Birthday_Doctor.Value.Day, Birthday_Doctor.Value.Month, Birthday_Doctor.Value.Year)));
                if (check)
                {
                    FillBoxes();
                    MessageBox.Show("Doctor added");
                }
            }
            catch (ArgumentException exception) {
                MessageBox.Show(exception.Message);
            }
            catch (IntExecption)
            {
                MessageBox.Show("Firstname and Secondname cannot contain integer");
            }
        }


        private void FillBoxes()
        {
            FillDoctorItems();
            FillPatientItems();
            FillAppointMentItems();
        }

        private void FillDoctorItems()
        {
            DeleteDoc_cmb.Items.Clear();
            Doctors.Items.Clear();
            appointMent_doc.Items.Clear();
            Docters_add_hours.Items.Clear();
            DeleteWorkHoursDoc.Items.Clear();

            foreach (Doctor s in AdminiStration.Doctors)
            {
                Doctors.Items.Add(s.ToString());
                DeleteDoc_cmb.Items.Add(s.ToString());
                appointMent_doc.Items.Add(s.ToString());
                Docters_add_hours.Items.Add(s.ToString());
                DeleteWorkHoursDoc.Items.Add(s.ToString());
            }
        }

        private void FillPatientItems()
        {
            Patients.Items.Clear();
            DeletePatient_cmb.Items.Clear();
            Appointment_Patient.Items.Clear();
            Search_AppointMent_cmb.Items.Clear();
            Add_treament_patient.Items.Clear();

            foreach (Patient x in AdminiStration.Patients)
            {
                Patients.Items.Add(x.ToString());
                DeletePatient_cmb.Items.Add(x.ToString());
                Appointment_Patient.Items.Add(x.ToString());
                Search_AppointMent_cmb.Items.Add(x.ToString());
                Add_treament_patient.Items.Add(x.ToString());
            }
        }

        public void FillAppointMentItems()
        {
            AppointMentsList.Items.Clear();
            DeleAppointment.Items.Clear();

            foreach (Appointment s in AdminiStration.Appointments)
            {
                AppointMentsList.Items.Add(s);
                DeleAppointment.Items.Add(s);
            }
        }


        private void LoadPatients_btn_Click(object sender, EventArgs e)
        {

            try
            {
                AdminiStration.LoadPatient(FilePatients);
                FillBoxes();
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to ReadFile");
            }
            catch (ArgumentOutOfRangeException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Unable to Read File");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("An error occurred when reading file: " + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("File is open");
            }

        }

        private void LoadFileDoc_btn_Click(object sender, EventArgs e)
        {

            try
            {
                AdminiStration.LoadDoctors(FileDoctors);
                FillBoxes();
            } catch (SerializationException)
            {
                MessageBox.Show("Unable to ReadFile");
            }
            catch (ArgumentOutOfRangeException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Unable to Read File");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("An error occurred when reading file: " + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("File is open");
            }

        }


        private void SavePatients_btn_Click(object sender, EventArgs e)
        {

            try
            {
                AdminiStration.ExportPatient(FilePatients);
            }
            catch (SerializationException Exception)
            {
                MessageBox.Show("Unable to Serialize:" + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show("Invalid Characters in File Path \n" + Exception.ToString());
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("File Path is to long");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The specified path is invalid");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("Unable to create file \n error: " + Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Invalid Path format");
            }

        }

        private void Delete_Patient_btn_Click(object sender, EventArgs e)
        {
            int index = DeletePatient_cmb.SelectedIndex;
            check = AdminiStration.RemovePatient(AdminiStration.Patients[index]);
            if (check)
            {
                FillBoxes();
                MessageBox.Show("Patient Succesful removed");
            }
            else
            {
                MessageBox.Show("Patient not found");
            }
        }

        private void CheckForInt(string value)
        {
            int i = 0;
            if (Int32.TryParse(value, out i))
            {
                throw new IntExecption();
            }
        }

        private void Delete_Doc_Click(object sender, EventArgs e)
        {
            int index = DeleteDoc_cmb.SelectedIndex;
            check = AdminiStration.RemoveDoctor(AdminiStration.Doctors[index]);
            if (check)
            {
                FillBoxes();
                MessageBox.Show("Doctor Succesfull removed");
            }
            else
            {
                MessageBox.Show("Doctor not found");
            }
        }

        private void Save_docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminiStration.ExportDoctors(FileDoctors);
            }
            catch (SerializationException Exception)
            {
                MessageBox.Show("Unable to Serialize:" + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show("Invalid Characters in File Path \n" + Exception.ToString());
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("File Path is to long");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The specified path is invalid");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("Unable to create file \n error: " + Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Invalid Path format");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indexPatient = Appointment_Patient.SelectedIndex;
            int indexDoctor = appointMent_doc.SelectedIndex;
            int indexTimer = AvailableHours_cmb.SelectedIndex;

            try
            {
                
                check = AdminiStration.AddAppointMent(AdminiStration.Patients[indexPatient], AdminiStration.Doctors[indexDoctor], AdminiStration.Doctors[indexDoctor].AvailableHours[indexTimer]);
                AdminiStration.ExportPatient(FilePatients);
                if (check)
                {
                    MessageBox.Show("Appointment has been planned");
                }
                else
                {
                    MessageBox.Show("Selected time has already been taken");
                }
                FillBoxes();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Day_Click(object sender, EventArgs e)
        {

        }

        private void SetCustomDatePicker()
        {
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "hh:mm";
        }

        private void Add_New_WorkDate_Click(object sender, EventArgs e)
        {
            int indexDocter = Docters_add_hours.SelectedIndex;
            check = AdminiStration.AddAvailableHours(AdminiStration.Doctors[indexDocter], new AvailableHour(NewWorkdate.Value.Day, NewWorkdate.Value.Month, NewWorkdate.Value.Year, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute));
            if (check)
            {
                MessageBox.Show("Available work hour added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = DeleAppointment.SelectedIndex;
            check = AdminiStration.RemoveAppointment(AdminiStration.Appointments[index]);
            if (check)
            {
                MessageBox.Show("Succesfully deleted Appointment");
                FillBoxes();
            }
        }

        private void appointMent_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            AvailableHours_cmb.Items.Clear();
            int index = appointMent_doc.SelectedIndex;
            foreach (AvailableHour s in AdminiStration.Doctors[index].AvailableHours)
            {
                AvailableHours_cmb.Items.Add(s.ToString());
            }
        }

        private void DeleteWorkHoursDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteWorkHours.Items.Clear();
            int index = DeleteWorkHoursDoc.SelectedIndex;

            foreach (AvailableHour s in AdminiStration.Doctors[index].AvailableHours)
            {
                DeleteWorkHours.Items.Add(s.ToString());
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int index = DeleteWorkHours.SelectedIndex;
            int indexDoctor = DeleteWorkHoursDoc.SelectedIndex;
            check = AdminiStration.RemoveAvailableHours(AdminiStration.Doctors[indexDoctor], AdminiStration.Doctors[indexDoctor].AvailableHours[index]);
            if (check)
            {
                FillBoxes();
                MessageBox.Show("Succesfully delete available hours");
            }
        }

        private void Search_Appointment_Click(object sender, EventArgs e)
        {
            Appointment search = null;
            int index = Search_AppointMent_cmb.SelectedIndex;

            search = AdminiStration.FindAppointment(AdminiStration.Patients[index]);
            MessageBox.Show(search.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string treatment = Treatments.SelectedItem.ToString();
            int index = Add_treament_patient.SelectedIndex;
            string treamentname = NameOfTreatment_txb.Text;
            try
            {
                CheckForInt(treamentname);
                if (treatment.ToUpper() == "FYSIO")
                {
                    AdminiStration.Patients[index].Add(new Fysio(Convert.ToInt32(NumberOfDaysNum.Value), new SimpleDate(dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year), treamentname));
                    MessageBox.Show($"Treatment: Fysio has been added to : {AdminiStration.Patients[index].FirstName}");
                }
                else if (treatment.ToUpper() == "MEDICINE")
                {
                    AdminiStration.Patients[index].Add(new Medicine(Convert.ToInt32(NumberOfDaysNum.Value), new SimpleDate(dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year), treamentname, Convert.ToInt32(DosageNum.Value)));
                    MessageBox.Show($"Treatment: Medcine has been added to : {AdminiStration.Patients[index].FirstName}");
                }

                else if (treatment.ToUpper() == "OPERATION")
                {
                    AdminiStration.Patients[index].Add(new Operation(Convert.ToInt32(NumberOfDaysNum.Value), new SimpleDate(dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year), treamentname, Convert.ToInt32(RecoveryNum.Value)));
                    MessageBox.Show($"Treatment: Operation has been added to : {AdminiStration.Patients[index].FirstName}");
                }

            }
            catch (IntExecption)
            {
                MessageBox.Show("TreamentName can't have an integer value");
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Selected index is out of range");
            }

        }

        private void AddBeginDoctorAndPatient()
        {
            AdminiStration.AddDoctor(new Doctor("Jeffrey", "Pieters", new SimpleDate(2, 8, 1999)));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(11, 6, 2019, 8, 30));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(11, 6, 2019, 9, 00));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(11, 6, 2019, 9, 30));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(12, 6, 2019, 8, 30));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(11, 6, 2019, 9, 00));
            AdminiStration.Doctors[0].AvailableHours.Add(new AvailableHour(11, 6, 2019, 9, 30));

            AdminiStration.AddPatient(new Patient("Berend", "Peijnenburg", new SimpleDate(11, 6, 1998)));
            AdminiStration.Patients[0].Add(new Fysio(10, new SimpleDate(12, 6, 2019), "Gescheurde enkelband"));
            AdminiStration.AddPatient(new Patient("Pim", "Van der Vliet", new SimpleDate(1, 3, 1996)));
            AdminiStration.Patients[1].Add(new Medicine(7, new SimpleDate(12, 6, 2019), "Paracetamol", 500));
        }

        private void Save_Appointments_btn_Click(object sender, EventArgs e)
        {

            try
            {
                AdminiStration.ExportAppointments(FileAppointments);
            }
            catch (SerializationException Exception)
            {
                MessageBox.Show("Unable to Serialize:" + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show("Invalid Characters in File Path \n" + Exception.ToString());
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("File Path is to long");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The specified path is invalid");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("Unable to create file \n error: " + Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Invalid Path format");
            }

        }

        private void LoadAppointMents_Btn_Click(object sender, EventArgs e)
        {

            try
            {
                AdminiStration.LoadAppointMents(FileAppointments);
                AdminiStration.LoadPatient(FilePatients);
                FillBoxes();
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to ReadFile");
            }
            catch (ArgumentOutOfRangeException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Unable to Read File");
            }
            catch (IOException Exception)
            {
                MessageBox.Show("An error occurred when reading file: " + Exception.ToString());
            }
            catch (ArgumentException Exception)
            {
                MessageBox.Show(Exception.ToString());
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("File is open");
            }
        }
    }
    
}
