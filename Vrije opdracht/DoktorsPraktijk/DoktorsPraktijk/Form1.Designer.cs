namespace DoktorsPraktijk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFileDoc_btn = new System.Windows.Forms.Button();
            this.Add_Patient_btn = new System.Windows.Forms.Button();
            this.LoadPatients_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SavePatients_btn = new System.Windows.Forms.Button();
            this.DeletePatient_cmb = new System.Windows.Forms.ComboBox();
            this.Delete_Patient_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Birthday_Patient = new System.Windows.Forms.DateTimePicker();
            this.Patients = new System.Windows.Forms.ListBox();
            this.tbx_LastNamePatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_FirstnamePatient = new System.Windows.Forms.TextBox();
            this.DoktorSecondName_tbx = new System.Windows.Forms.TextBox();
            this.DokterFirstName_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Birthday_Doctor = new System.Windows.Forms.DateTimePicker();
            this.Doctor = new System.Windows.Forms.GroupBox();
            this.DeleteDoc_cmb = new System.Windows.Forms.ComboBox();
            this.Delete_Doc = new System.Windows.Forms.Button();
            this.Save_docBtn = new System.Windows.Forms.Button();
            this.Doctors = new System.Windows.Forms.ListBox();
            this.Add_Dokter_btn = new System.Windows.Forms.Button();
            this.AppointMents = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Search_Appointment = new System.Windows.Forms.Button();
            this.Search_AppointMent_cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AvailableHours_cmb = new System.Windows.Forms.ComboBox();
            this.Appointment_Patient = new System.Windows.Forms.ComboBox();
            this.appointMent_doc = new System.Windows.Forms.ComboBox();
            this.AppointMentsList = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Save_Appointments_btn = new System.Windows.Forms.Button();
            this.LoadAppointMents_Btn = new System.Windows.Forms.Button();
            this.DeleAppointment = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Patient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DeleteWorkHours = new System.Windows.Forms.ComboBox();
            this.DeleteWorkHoursDoc = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Add_New_WorkDate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.NewWorkdate = new System.Windows.Forms.DateTimePicker();
            this.Docters_add_hours = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NameOfTreatment_txb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.RecoveryNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.DosageNum = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.NumberOfDaysNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Treatments = new System.Windows.Forms.ComboBox();
            this.Add_treament_patient = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Doctor.SuspendLayout();
            this.AppointMents.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecoveryNum)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DosageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDaysNum)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFileDoc_btn
            // 
            this.LoadFileDoc_btn.Location = new System.Drawing.Point(8, 34);
            this.LoadFileDoc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadFileDoc_btn.Name = "LoadFileDoc_btn";
            this.LoadFileDoc_btn.Size = new System.Drawing.Size(121, 34);
            this.LoadFileDoc_btn.TabIndex = 0;
            this.LoadFileDoc_btn.Text = "Load Doctors";
            this.LoadFileDoc_btn.UseVisualStyleBackColor = true;
            this.LoadFileDoc_btn.Click += new System.EventHandler(this.LoadFileDoc_btn_Click);
            // 
            // Add_Patient_btn
            // 
            this.Add_Patient_btn.Location = new System.Drawing.Point(135, 215);
            this.Add_Patient_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Patient_btn.Name = "Add_Patient_btn";
            this.Add_Patient_btn.Size = new System.Drawing.Size(133, 28);
            this.Add_Patient_btn.TabIndex = 1;
            this.Add_Patient_btn.Text = "Add  Patient";
            this.Add_Patient_btn.UseVisualStyleBackColor = true;
            this.Add_Patient_btn.Click += new System.EventHandler(this.Add_Patient_btn_Click);
            // 
            // LoadPatients_btn
            // 
            this.LoadPatients_btn.Location = new System.Drawing.Point(20, 36);
            this.LoadPatients_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadPatients_btn.Name = "LoadPatients_btn";
            this.LoadPatients_btn.Size = new System.Drawing.Size(121, 34);
            this.LoadPatients_btn.TabIndex = 2;
            this.LoadPatients_btn.Text = "Load Patients";
            this.LoadPatients_btn.UseVisualStyleBackColor = true;
            this.LoadPatients_btn.Click += new System.EventHandler(this.LoadPatients_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SavePatients_btn);
            this.groupBox1.Controls.Add(this.DeletePatient_cmb);
            this.groupBox1.Controls.Add(this.Delete_Patient_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Birthday_Patient);
            this.groupBox1.Controls.Add(this.Patients);
            this.groupBox1.Controls.Add(this.tbx_LastNamePatient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LoadPatients_btn);
            this.groupBox1.Controls.Add(this.txb_FirstnamePatient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Add_Patient_btn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(675, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // SavePatients_btn
            // 
            this.SavePatients_btn.Location = new System.Drawing.Point(199, 36);
            this.SavePatients_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavePatients_btn.Name = "SavePatients_btn";
            this.SavePatients_btn.Size = new System.Drawing.Size(121, 34);
            this.SavePatients_btn.TabIndex = 11;
            this.SavePatients_btn.Text = "Save Patients";
            this.SavePatients_btn.UseVisualStyleBackColor = true;
            this.SavePatients_btn.Click += new System.EventHandler(this.SavePatients_btn_Click);
            // 
            // DeletePatient_cmb
            // 
            this.DeletePatient_cmb.FormattingEnabled = true;
            this.DeletePatient_cmb.Location = new System.Drawing.Point(20, 263);
            this.DeletePatient_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePatient_cmb.Name = "DeletePatient_cmb";
            this.DeletePatient_cmb.Size = new System.Drawing.Size(160, 24);
            this.DeletePatient_cmb.TabIndex = 19;
            // 
            // Delete_Patient_btn
            // 
            this.Delete_Patient_btn.Location = new System.Drawing.Point(188, 260);
            this.Delete_Patient_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_Patient_btn.Name = "Delete_Patient_btn";
            this.Delete_Patient_btn.Size = new System.Drawing.Size(132, 31);
            this.Delete_Patient_btn.TabIndex = 18;
            this.Delete_Patient_btn.Text = "Delete Patient";
            this.Delete_Patient_btn.UseVisualStyleBackColor = true;
            this.Delete_Patient_btn.Click += new System.EventHandler(this.Delete_Patient_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brith Day:";
            // 
            // Birthday_Patient
            // 
            this.Birthday_Patient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday_Patient.Location = new System.Drawing.Point(135, 171);
            this.Birthday_Patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Birthday_Patient.Name = "Birthday_Patient";
            this.Birthday_Patient.Size = new System.Drawing.Size(132, 22);
            this.Birthday_Patient.TabIndex = 9;
            this.Birthday_Patient.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // Patients
            // 
            this.Patients.FormattingEnabled = true;
            this.Patients.ItemHeight = 16;
            this.Patients.Location = new System.Drawing.Point(369, 15);
            this.Patients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(296, 308);
            this.Patients.TabIndex = 14;
            // 
            // tbx_LastNamePatient
            // 
            this.tbx_LastNamePatient.Location = new System.Drawing.Point(135, 122);
            this.tbx_LastNamePatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_LastNamePatient.Name = "tbx_LastNamePatient";
            this.tbx_LastNamePatient.Size = new System.Drawing.Size(132, 22);
            this.tbx_LastNamePatient.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Name:";
            // 
            // txb_FirstnamePatient
            // 
            this.txb_FirstnamePatient.Location = new System.Drawing.Point(135, 78);
            this.txb_FirstnamePatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_FirstnamePatient.Name = "txb_FirstnamePatient";
            this.txb_FirstnamePatient.Size = new System.Drawing.Size(132, 22);
            this.txb_FirstnamePatient.TabIndex = 4;
            // 
            // DoktorSecondName_tbx
            // 
            this.DoktorSecondName_tbx.Location = new System.Drawing.Point(132, 114);
            this.DoktorSecondName_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoktorSecondName_tbx.Name = "DoktorSecondName_tbx";
            this.DoktorSecondName_tbx.Size = new System.Drawing.Size(132, 22);
            this.DoktorSecondName_tbx.TabIndex = 11;
            // 
            // DokterFirstName_tbx
            // 
            this.DokterFirstName_tbx.Location = new System.Drawing.Point(132, 82);
            this.DokterFirstName_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DokterFirstName_tbx.Name = "DokterFirstName_tbx";
            this.DokterFirstName_tbx.Size = new System.Drawing.Size(132, 22);
            this.DokterFirstName_tbx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Second Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Brith Day:";
            // 
            // Birthday_Doctor
            // 
            this.Birthday_Doctor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday_Doctor.Location = new System.Drawing.Point(132, 145);
            this.Birthday_Doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Birthday_Doctor.Name = "Birthday_Doctor";
            this.Birthday_Doctor.Size = new System.Drawing.Size(132, 22);
            this.Birthday_Doctor.TabIndex = 11;
            this.Birthday_Doctor.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // Doctor
            // 
            this.Doctor.Controls.Add(this.DeleteDoc_cmb);
            this.Doctor.Controls.Add(this.Delete_Doc);
            this.Doctor.Controls.Add(this.Save_docBtn);
            this.Doctor.Controls.Add(this.Doctors);
            this.Doctor.Controls.Add(this.Add_Dokter_btn);
            this.Doctor.Controls.Add(this.label6);
            this.Doctor.Controls.Add(this.label5);
            this.Doctor.Controls.Add(this.Birthday_Doctor);
            this.Doctor.Controls.Add(this.label4);
            this.Doctor.Controls.Add(this.DokterFirstName_tbx);
            this.Doctor.Controls.Add(this.DoktorSecondName_tbx);
            this.Doctor.Controls.Add(this.LoadFileDoc_btn);
            this.Doctor.Location = new System.Drawing.Point(16, 352);
            this.Doctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Doctor.Name = "Doctor";
            this.Doctor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Doctor.Size = new System.Drawing.Size(672, 538);
            this.Doctor.TabIndex = 13;
            this.Doctor.TabStop = false;
            this.Doctor.Text = "Doctor";
            // 
            // DeleteDoc_cmb
            // 
            this.DeleteDoc_cmb.FormattingEnabled = true;
            this.DeleteDoc_cmb.Location = new System.Drawing.Point(7, 247);
            this.DeleteDoc_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteDoc_cmb.Name = "DeleteDoc_cmb";
            this.DeleteDoc_cmb.Size = new System.Drawing.Size(160, 24);
            this.DeleteDoc_cmb.TabIndex = 22;
            // 
            // Delete_Doc
            // 
            this.Delete_Doc.Location = new System.Drawing.Point(175, 244);
            this.Delete_Doc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_Doc.Name = "Delete_Doc";
            this.Delete_Doc.Size = new System.Drawing.Size(132, 31);
            this.Delete_Doc.TabIndex = 21;
            this.Delete_Doc.Text = "Delete Doctor";
            this.Delete_Doc.UseVisualStyleBackColor = true;
            this.Delete_Doc.Click += new System.EventHandler(this.Delete_Doc_Click);
            // 
            // Save_docBtn
            // 
            this.Save_docBtn.Location = new System.Drawing.Point(185, 34);
            this.Save_docBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_docBtn.Name = "Save_docBtn";
            this.Save_docBtn.Size = new System.Drawing.Size(121, 34);
            this.Save_docBtn.TabIndex = 20;
            this.Save_docBtn.Text = "Save Doctors";
            this.Save_docBtn.UseVisualStyleBackColor = true;
            this.Save_docBtn.Click += new System.EventHandler(this.Save_docBtn_Click);
            // 
            // Doctors
            // 
            this.Doctors.FormattingEnabled = true;
            this.Doctors.ItemHeight = 16;
            this.Doctors.Location = new System.Drawing.Point(367, 15);
            this.Doctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(296, 308);
            this.Doctors.TabIndex = 15;
            // 
            // Add_Dokter_btn
            // 
            this.Add_Dokter_btn.Location = new System.Drawing.Point(132, 190);
            this.Add_Dokter_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Dokter_btn.Name = "Add_Dokter_btn";
            this.Add_Dokter_btn.Size = new System.Drawing.Size(133, 28);
            this.Add_Dokter_btn.TabIndex = 13;
            this.Add_Dokter_btn.Text = "Add  Doctor";
            this.Add_Dokter_btn.UseVisualStyleBackColor = true;
            this.Add_Dokter_btn.Click += new System.EventHandler(this.Add_Dokter_btn_Click);
            // 
            // AppointMents
            // 
            this.AppointMents.Controls.Add(this.groupBox5);
            this.AppointMents.Controls.Add(this.AvailableHours_cmb);
            this.AppointMents.Controls.Add(this.Appointment_Patient);
            this.AppointMents.Controls.Add(this.appointMent_doc);
            this.AppointMents.Controls.Add(this.AppointMentsList);
            this.AppointMents.Controls.Add(this.label11);
            this.AppointMents.Controls.Add(this.Save_Appointments_btn);
            this.AppointMents.Controls.Add(this.LoadAppointMents_Btn);
            this.AppointMents.Controls.Add(this.DeleAppointment);
            this.AppointMents.Controls.Add(this.button4);
            this.AppointMents.Controls.Add(this.button2);
            this.AppointMents.Controls.Add(this.Patient);
            this.AppointMents.Controls.Add(this.label10);
            this.AppointMents.Location = new System.Drawing.Point(727, 13);
            this.AppointMents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointMents.Name = "AppointMents";
            this.AppointMents.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointMents.Size = new System.Drawing.Size(441, 876);
            this.AppointMents.TabIndex = 18;
            this.AppointMents.TabStop = false;
            this.AppointMents.Text = "Appointment";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Search_Appointment);
            this.groupBox5.Controls.Add(this.Search_AppointMent_cmb);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(25, 353);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(408, 81);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Appointment";
            // 
            // Search_Appointment
            // 
            this.Search_Appointment.Location = new System.Drawing.Point(267, 26);
            this.Search_Appointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_Appointment.Name = "Search_Appointment";
            this.Search_Appointment.Size = new System.Drawing.Size(133, 28);
            this.Search_Appointment.TabIndex = 36;
            this.Search_Appointment.Text = "Search";
            this.Search_Appointment.UseVisualStyleBackColor = true;
            this.Search_Appointment.Click += new System.EventHandler(this.Search_Appointment_Click);
            // 
            // Search_AppointMent_cmb
            // 
            this.Search_AppointMent_cmb.FormattingEnabled = true;
            this.Search_AppointMent_cmb.Location = new System.Drawing.Point(97, 28);
            this.Search_AppointMent_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_AppointMent_cmb.Name = "Search_AppointMent_cmb";
            this.Search_AppointMent_cmb.Size = new System.Drawing.Size(160, 24);
            this.Search_AppointMent_cmb.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Patient:";
            // 
            // AvailableHours_cmb
            // 
            this.AvailableHours_cmb.FormatString = "f";
            this.AvailableHours_cmb.FormattingEnabled = true;
            this.AvailableHours_cmb.Location = new System.Drawing.Point(139, 155);
            this.AvailableHours_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailableHours_cmb.Name = "AvailableHours_cmb";
            this.AvailableHours_cmb.Size = new System.Drawing.Size(160, 24);
            this.AvailableHours_cmb.TabIndex = 35;
            // 
            // Appointment_Patient
            // 
            this.Appointment_Patient.FormattingEnabled = true;
            this.Appointment_Patient.Location = new System.Drawing.Point(139, 85);
            this.Appointment_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Appointment_Patient.Name = "Appointment_Patient";
            this.Appointment_Patient.Size = new System.Drawing.Size(160, 24);
            this.Appointment_Patient.TabIndex = 34;
            // 
            // appointMent_doc
            // 
            this.appointMent_doc.FormattingEnabled = true;
            this.appointMent_doc.Location = new System.Drawing.Point(139, 122);
            this.appointMent_doc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointMent_doc.Name = "appointMent_doc";
            this.appointMent_doc.Size = new System.Drawing.Size(160, 24);
            this.appointMent_doc.TabIndex = 20;
            this.appointMent_doc.SelectedIndexChanged += new System.EventHandler(this.appointMent_doc_SelectedIndexChanged);
            // 
            // AppointMentsList
            // 
            this.AppointMentsList.FormattingEnabled = true;
            this.AppointMentsList.ItemHeight = 16;
            this.AppointMentsList.Location = new System.Drawing.Point(28, 455);
            this.AppointMentsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointMentsList.Name = "AppointMentsList";
            this.AppointMentsList.Size = new System.Drawing.Size(404, 404);
            this.AppointMentsList.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date:";
            // 
            // Save_Appointments_btn
            // 
            this.Save_Appointments_btn.Location = new System.Drawing.Point(245, 36);
            this.Save_Appointments_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_Appointments_btn.Name = "Save_Appointments_btn";
            this.Save_Appointments_btn.Size = new System.Drawing.Size(151, 34);
            this.Save_Appointments_btn.TabIndex = 28;
            this.Save_Appointments_btn.Text = "Save Appointments";
            this.Save_Appointments_btn.UseVisualStyleBackColor = true;
            this.Save_Appointments_btn.Click += new System.EventHandler(this.Save_Appointments_btn_Click);
            // 
            // LoadAppointMents_Btn
            // 
            this.LoadAppointMents_Btn.Location = new System.Drawing.Point(8, 36);
            this.LoadAppointMents_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadAppointMents_Btn.Name = "LoadAppointMents_Btn";
            this.LoadAppointMents_Btn.Size = new System.Drawing.Size(161, 34);
            this.LoadAppointMents_Btn.TabIndex = 21;
            this.LoadAppointMents_Btn.Text = "Load Appointments";
            this.LoadAppointMents_Btn.UseVisualStyleBackColor = true;
            this.LoadAppointMents_Btn.Click += new System.EventHandler(this.LoadAppointMents_Btn_Click);
            // 
            // DeleAppointment
            // 
            this.DeleAppointment.FormattingEnabled = true;
            this.DeleAppointment.Location = new System.Drawing.Point(80, 254);
            this.DeleAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleAppointment.Name = "DeleAppointment";
            this.DeleAppointment.Size = new System.Drawing.Size(279, 24);
            this.DeleAppointment.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 28);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add  Appointment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 31);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Location = new System.Drawing.Point(63, 89);
            this.Patient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(56, 17);
            this.Patient.TabIndex = 22;
            this.Patient.Text = "Patient:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Doctor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.DeleteWorkHours);
            this.groupBox2.Controls.Add(this.DeleteWorkHoursDoc);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(373, 683);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(297, 191);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Available Hours";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 128);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 28);
            this.button5.TabIndex = 32;
            this.button5.Text = "Delete Work Date";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Date:";
            // 
            // DeleteWorkHours
            // 
            this.DeleteWorkHours.FormatString = "f";
            this.DeleteWorkHours.FormattingEnabled = true;
            this.DeleteWorkHours.Location = new System.Drawing.Point(92, 69);
            this.DeleteWorkHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteWorkHours.Name = "DeleteWorkHours";
            this.DeleteWorkHours.Size = new System.Drawing.Size(160, 24);
            this.DeleteWorkHours.TabIndex = 36;
            // 
            // DeleteWorkHoursDoc
            // 
            this.DeleteWorkHoursDoc.FormattingEnabled = true;
            this.DeleteWorkHoursDoc.Location = new System.Drawing.Point(92, 28);
            this.DeleteWorkHoursDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteWorkHoursDoc.Name = "DeleteWorkHoursDoc";
            this.DeleteWorkHoursDoc.Size = new System.Drawing.Size(160, 24);
            this.DeleteWorkHoursDoc.TabIndex = 32;
            this.DeleteWorkHoursDoc.SelectedIndexChanged += new System.EventHandler(this.DeleteWorkHoursDoc_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Doctor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Add_New_WorkDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.NewWorkdate);
            this.groupBox3.Controls.Add(this.Docters_add_hours);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(24, 683);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(327, 191);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Available Hours";
            // 
            // Add_New_WorkDate
            // 
            this.Add_New_WorkDate.Location = new System.Drawing.Point(108, 142);
            this.Add_New_WorkDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_New_WorkDate.Name = "Add_New_WorkDate";
            this.Add_New_WorkDate.Size = new System.Drawing.Size(135, 28);
            this.Add_New_WorkDate.TabIndex = 31;
            this.Add_New_WorkDate.Text = "Add Workdate";
            this.Add_New_WorkDate.UseVisualStyleBackColor = true;
            this.Add_New_WorkDate.Click += new System.EventHandler(this.Add_New_WorkDate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(33, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 97);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Date:";
            // 
            // NewWorkdate
            // 
            this.NewWorkdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewWorkdate.Location = new System.Drawing.Point(108, 65);
            this.NewWorkdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewWorkdate.Name = "NewWorkdate";
            this.NewWorkdate.Size = new System.Drawing.Size(160, 22);
            this.NewWorkdate.TabIndex = 27;
            // 
            // Docters_add_hours
            // 
            this.Docters_add_hours.FormattingEnabled = true;
            this.Docters_add_hours.Location = new System.Drawing.Point(108, 32);
            this.Docters_add_hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Docters_add_hours.Name = "Docters_add_hours";
            this.Docters_add_hours.Size = new System.Drawing.Size(160, 24);
            this.Docters_add_hours.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Doctor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NameOfTreatment_txb);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.NumberOfDaysNum);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Treatments);
            this.groupBox4.Controls.Add(this.Add_treament_patient);
            this.groupBox4.Location = new System.Drawing.Point(13, 897);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1144, 188);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Treatment";
            // 
            // NameOfTreatment_txb
            // 
            this.NameOfTreatment_txb.Location = new System.Drawing.Point(136, 143);
            this.NameOfTreatment_txb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameOfTreatment_txb.Name = "NameOfTreatment_txb";
            this.NameOfTreatment_txb.Size = new System.Drawing.Size(132, 22);
            this.NameOfTreatment_txb.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 146);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Treament Name:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(883, 74);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 63);
            this.button6.TabIndex = 45;
            this.button6.Text = "Add Treatment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.RecoveryNum);
            this.groupBox7.Location = new System.Drawing.Point(597, 110);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(220, 65);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operation";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "Recovery:";
            // 
            // RecoveryNum
            // 
            this.RecoveryNum.Location = new System.Drawing.Point(91, 26);
            this.RecoveryNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecoveryNum.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.RecoveryNum.Name = "RecoveryNum";
            this.RecoveryNum.Size = new System.Drawing.Size(107, 22);
            this.RecoveryNum.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.DosageNum);
            this.groupBox6.Location = new System.Drawing.Point(603, 31);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(175, 71);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Medicine";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 17);
            this.label19.TabIndex = 42;
            this.label19.Text = "Dosage:";
            // 
            // DosageNum
            // 
            this.DosageNum.Location = new System.Drawing.Point(68, 26);
            this.DosageNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DosageNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DosageNum.Name = "DosageNum";
            this.DosageNum.Size = new System.Drawing.Size(107, 22);
            this.DosageNum.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(284, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "Start Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 92);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Number of Days:";
            // 
            // NumberOfDaysNum
            // 
            this.NumberOfDaysNum.Location = new System.Drawing.Point(407, 42);
            this.NumberOfDaysNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberOfDaysNum.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumberOfDaysNum.Name = "NumberOfDaysNum";
            this.NumberOfDaysNum.Size = new System.Drawing.Size(93, 22);
            this.NumberOfDaysNum.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Treatment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Patient:";
            // 
            // Treatments
            // 
            this.Treatments.FormattingEnabled = true;
            this.Treatments.Items.AddRange(new object[] {
            "Fysio",
            "Medicine",
            "Operation"});
            this.Treatments.Location = new System.Drawing.Point(96, 41);
            this.Treatments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(160, 24);
            this.Treatments.TabIndex = 21;
            // 
            // Add_treament_patient
            // 
            this.Add_treament_patient.FormattingEnabled = true;
            this.Add_treament_patient.Location = new System.Drawing.Point(96, 91);
            this.Add_treament_patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_treament_patient.Name = "Add_treament_patient";
            this.Add_treament_patient.Size = new System.Drawing.Size(160, 24);
            this.Add_treament_patient.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AppointMents);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Doctor.ResumeLayout(false);
            this.Doctor.PerformLayout();
            this.AppointMents.ResumeLayout(false);
            this.AppointMents.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecoveryNum)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DosageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDaysNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadFileDoc_btn;
        private System.Windows.Forms.Button Add_Patient_btn;
        private System.Windows.Forms.Button LoadPatients_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Birthday_Patient;
        private System.Windows.Forms.TextBox tbx_LastNamePatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_FirstnamePatient;
        private System.Windows.Forms.TextBox DoktorSecondName_tbx;
        private System.Windows.Forms.TextBox DokterFirstName_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Birthday_Doctor;
        private System.Windows.Forms.GroupBox Doctor;
        private System.Windows.Forms.Button Add_Dokter_btn;
        private System.Windows.Forms.ListBox Patients;
        private System.Windows.Forms.ListBox Doctors;
        private System.Windows.Forms.Button SavePatients_btn;
        private System.Windows.Forms.ComboBox DeletePatient_cmb;
        private System.Windows.Forms.Button Delete_Patient_btn;
        private System.Windows.Forms.Button Save_docBtn;
        private System.Windows.Forms.ComboBox DeleteDoc_cmb;
        private System.Windows.Forms.Button Delete_Doc;
        private System.Windows.Forms.GroupBox AppointMents;
        private System.Windows.Forms.Button Save_Appointments_btn;
        private System.Windows.Forms.Button LoadAppointMents_Btn;
        private System.Windows.Forms.ComboBox DeleAppointment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AvailableHours_cmb;
        private System.Windows.Forms.ComboBox Appointment_Patient;
        private System.Windows.Forms.ComboBox appointMent_doc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox AppointMentsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker NewWorkdate;
        private System.Windows.Forms.ComboBox Docters_add_hours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Add_New_WorkDate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox DeleteWorkHours;
        private System.Windows.Forms.ComboBox DeleteWorkHoursDoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Search_Appointment;
        private System.Windows.Forms.ComboBox Search_AppointMent_cmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Treatments;
        private System.Windows.Forms.ComboBox Add_treament_patient;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown RecoveryNum;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown DosageNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NumberOfDaysNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox NameOfTreatment_txb;
        private System.Windows.Forms.Label label21;
    }
}

