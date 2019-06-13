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
            this.LoadFileDoc_btn.Location = new System.Drawing.Point(6, 28);
            this.LoadFileDoc_btn.Name = "LoadFileDoc_btn";
            this.LoadFileDoc_btn.Size = new System.Drawing.Size(91, 28);
            this.LoadFileDoc_btn.TabIndex = 0;
            this.LoadFileDoc_btn.Text = "Load Doctors";
            this.LoadFileDoc_btn.UseVisualStyleBackColor = true;
            this.LoadFileDoc_btn.Click += new System.EventHandler(this.LoadFileDoc_btn_Click);
            // 
            // Add_Patient_btn
            // 
            this.Add_Patient_btn.Location = new System.Drawing.Point(101, 175);
            this.Add_Patient_btn.Name = "Add_Patient_btn";
            this.Add_Patient_btn.Size = new System.Drawing.Size(100, 23);
            this.Add_Patient_btn.TabIndex = 1;
            this.Add_Patient_btn.Text = "Add  Patient";
            this.Add_Patient_btn.UseVisualStyleBackColor = true;
            this.Add_Patient_btn.Click += new System.EventHandler(this.Add_Patient_btn_Click);
            // 
            // LoadPatients_btn
            // 
            this.LoadPatients_btn.Location = new System.Drawing.Point(15, 29);
            this.LoadPatients_btn.Name = "LoadPatients_btn";
            this.LoadPatients_btn.Size = new System.Drawing.Size(91, 28);
            this.LoadPatients_btn.TabIndex = 2;
            this.LoadPatients_btn.Text = "Load Patients";
            this.LoadPatients_btn.UseVisualStyleBackColor = true;
            this.LoadPatients_btn.Click += new System.EventHandler(this.LoadPatients_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // SavePatients_btn
            // 
            this.SavePatients_btn.Location = new System.Drawing.Point(149, 29);
            this.SavePatients_btn.Name = "SavePatients_btn";
            this.SavePatients_btn.Size = new System.Drawing.Size(91, 28);
            this.SavePatients_btn.TabIndex = 11;
            this.SavePatients_btn.Text = "Save Patients";
            this.SavePatients_btn.UseVisualStyleBackColor = true;
            this.SavePatients_btn.Click += new System.EventHandler(this.SavePatients_btn_Click);
            // 
            // DeletePatient_cmb
            // 
            this.DeletePatient_cmb.FormattingEnabled = true;
            this.DeletePatient_cmb.Location = new System.Drawing.Point(15, 214);
            this.DeletePatient_cmb.Name = "DeletePatient_cmb";
            this.DeletePatient_cmb.Size = new System.Drawing.Size(121, 21);
            this.DeletePatient_cmb.TabIndex = 19;
            // 
            // Delete_Patient_btn
            // 
            this.Delete_Patient_btn.Location = new System.Drawing.Point(141, 211);
            this.Delete_Patient_btn.Name = "Delete_Patient_btn";
            this.Delete_Patient_btn.Size = new System.Drawing.Size(99, 25);
            this.Delete_Patient_btn.TabIndex = 18;
            this.Delete_Patient_btn.Text = "Delete Patient";
            this.Delete_Patient_btn.UseVisualStyleBackColor = true;
            this.Delete_Patient_btn.Click += new System.EventHandler(this.Delete_Patient_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brith Day:";
            // 
            // Birthday_Patient
            // 
            this.Birthday_Patient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday_Patient.Location = new System.Drawing.Point(101, 139);
            this.Birthday_Patient.Margin = new System.Windows.Forms.Padding(2);
            this.Birthday_Patient.Name = "Birthday_Patient";
            this.Birthday_Patient.Size = new System.Drawing.Size(100, 20);
            this.Birthday_Patient.TabIndex = 9;
            this.Birthday_Patient.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // Patients
            // 
            this.Patients.FormattingEnabled = true;
            this.Patients.Location = new System.Drawing.Point(277, 12);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(223, 251);
            this.Patients.TabIndex = 14;
            // 
            // tbx_LastNamePatient
            // 
            this.tbx_LastNamePatient.Location = new System.Drawing.Point(101, 99);
            this.tbx_LastNamePatient.Name = "tbx_LastNamePatient";
            this.tbx_LastNamePatient.Size = new System.Drawing.Size(100, 20);
            this.tbx_LastNamePatient.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Name:";
            // 
            // txb_FirstnamePatient
            // 
            this.txb_FirstnamePatient.Location = new System.Drawing.Point(101, 63);
            this.txb_FirstnamePatient.Name = "txb_FirstnamePatient";
            this.txb_FirstnamePatient.Size = new System.Drawing.Size(100, 20);
            this.txb_FirstnamePatient.TabIndex = 4;
            // 
            // DoktorSecondName_tbx
            // 
            this.DoktorSecondName_tbx.Location = new System.Drawing.Point(99, 93);
            this.DoktorSecondName_tbx.Name = "DoktorSecondName_tbx";
            this.DoktorSecondName_tbx.Size = new System.Drawing.Size(100, 20);
            this.DoktorSecondName_tbx.TabIndex = 11;
            // 
            // DokterFirstName_tbx
            // 
            this.DokterFirstName_tbx.Location = new System.Drawing.Point(99, 67);
            this.DokterFirstName_tbx.Name = "DokterFirstName_tbx";
            this.DokterFirstName_tbx.Size = new System.Drawing.Size(100, 20);
            this.DokterFirstName_tbx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Second Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Brith Day:";
            // 
            // Birthday_Doctor
            // 
            this.Birthday_Doctor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday_Doctor.Location = new System.Drawing.Point(99, 118);
            this.Birthday_Doctor.Margin = new System.Windows.Forms.Padding(2);
            this.Birthday_Doctor.Name = "Birthday_Doctor";
            this.Birthday_Doctor.Size = new System.Drawing.Size(100, 20);
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
            this.Doctor.Location = new System.Drawing.Point(12, 307);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(504, 437);
            this.Doctor.TabIndex = 13;
            this.Doctor.TabStop = false;
            this.Doctor.Text = "Doctor";
            // 
            // DeleteDoc_cmb
            // 
            this.DeleteDoc_cmb.FormattingEnabled = true;
            this.DeleteDoc_cmb.Location = new System.Drawing.Point(5, 201);
            this.DeleteDoc_cmb.Name = "DeleteDoc_cmb";
            this.DeleteDoc_cmb.Size = new System.Drawing.Size(121, 21);
            this.DeleteDoc_cmb.TabIndex = 22;
            // 
            // Delete_Doc
            // 
            this.Delete_Doc.Location = new System.Drawing.Point(131, 198);
            this.Delete_Doc.Name = "Delete_Doc";
            this.Delete_Doc.Size = new System.Drawing.Size(99, 25);
            this.Delete_Doc.TabIndex = 21;
            this.Delete_Doc.Text = "Delete Doctor";
            this.Delete_Doc.UseVisualStyleBackColor = true;
            this.Delete_Doc.Click += new System.EventHandler(this.Delete_Doc_Click);
            // 
            // Save_docBtn
            // 
            this.Save_docBtn.Location = new System.Drawing.Point(139, 28);
            this.Save_docBtn.Name = "Save_docBtn";
            this.Save_docBtn.Size = new System.Drawing.Size(91, 28);
            this.Save_docBtn.TabIndex = 20;
            this.Save_docBtn.Text = "Save Doctors";
            this.Save_docBtn.UseVisualStyleBackColor = true;
            this.Save_docBtn.Click += new System.EventHandler(this.Save_docBtn_Click);
            // 
            // Doctors
            // 
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(275, 12);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(223, 251);
            this.Doctors.TabIndex = 15;
            // 
            // Add_Dokter_btn
            // 
            this.Add_Dokter_btn.Location = new System.Drawing.Point(99, 154);
            this.Add_Dokter_btn.Name = "Add_Dokter_btn";
            this.Add_Dokter_btn.Size = new System.Drawing.Size(100, 23);
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
            this.AppointMents.Location = new System.Drawing.Point(545, 32);
            this.AppointMents.Name = "AppointMents";
            this.AppointMents.Size = new System.Drawing.Size(331, 712);
            this.AppointMents.TabIndex = 18;
            this.AppointMents.TabStop = false;
            this.AppointMents.Text = "Appointment";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Search_Appointment);
            this.groupBox5.Controls.Add(this.Search_AppointMent_cmb);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(19, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 66);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Appointment";
            // 
            // Search_Appointment
            // 
            this.Search_Appointment.Location = new System.Drawing.Point(200, 21);
            this.Search_Appointment.Name = "Search_Appointment";
            this.Search_Appointment.Size = new System.Drawing.Size(100, 23);
            this.Search_Appointment.TabIndex = 36;
            this.Search_Appointment.Text = "Search";
            this.Search_Appointment.UseVisualStyleBackColor = true;
            this.Search_Appointment.Click += new System.EventHandler(this.Search_Appointment_Click);
            // 
            // Search_AppointMent_cmb
            // 
            this.Search_AppointMent_cmb.FormattingEnabled = true;
            this.Search_AppointMent_cmb.Location = new System.Drawing.Point(73, 23);
            this.Search_AppointMent_cmb.Name = "Search_AppointMent_cmb";
            this.Search_AppointMent_cmb.Size = new System.Drawing.Size(121, 21);
            this.Search_AppointMent_cmb.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Patient:";
            // 
            // AvailableHours_cmb
            // 
            this.AvailableHours_cmb.FormatString = "f";
            this.AvailableHours_cmb.FormattingEnabled = true;
            this.AvailableHours_cmb.Location = new System.Drawing.Point(104, 126);
            this.AvailableHours_cmb.Name = "AvailableHours_cmb";
            this.AvailableHours_cmb.Size = new System.Drawing.Size(121, 21);
            this.AvailableHours_cmb.TabIndex = 35;
            // 
            // Appointment_Patient
            // 
            this.Appointment_Patient.FormattingEnabled = true;
            this.Appointment_Patient.Location = new System.Drawing.Point(104, 69);
            this.Appointment_Patient.Name = "Appointment_Patient";
            this.Appointment_Patient.Size = new System.Drawing.Size(121, 21);
            this.Appointment_Patient.TabIndex = 34;
            // 
            // appointMent_doc
            // 
            this.appointMent_doc.FormattingEnabled = true;
            this.appointMent_doc.Location = new System.Drawing.Point(104, 99);
            this.appointMent_doc.Name = "appointMent_doc";
            this.appointMent_doc.Size = new System.Drawing.Size(121, 21);
            this.appointMent_doc.TabIndex = 20;
            this.appointMent_doc.SelectedIndexChanged += new System.EventHandler(this.appointMent_doc_SelectedIndexChanged);
            // 
            // AppointMentsList
            // 
            this.AppointMentsList.FormattingEnabled = true;
            this.AppointMentsList.Location = new System.Drawing.Point(21, 370);
            this.AppointMentsList.Name = "AppointMentsList";
            this.AppointMentsList.Size = new System.Drawing.Size(304, 329);
            this.AppointMentsList.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date:";
            // 
            // Save_Appointments_btn
            // 
            this.Save_Appointments_btn.Location = new System.Drawing.Point(184, 29);
            this.Save_Appointments_btn.Name = "Save_Appointments_btn";
            this.Save_Appointments_btn.Size = new System.Drawing.Size(113, 28);
            this.Save_Appointments_btn.TabIndex = 28;
            this.Save_Appointments_btn.Text = "Save Appointments";
            this.Save_Appointments_btn.UseVisualStyleBackColor = true;
            this.Save_Appointments_btn.Click += new System.EventHandler(this.Save_Appointments_btn_Click);
            // 
            // LoadAppointMents_Btn
            // 
            this.LoadAppointMents_Btn.Location = new System.Drawing.Point(6, 29);
            this.LoadAppointMents_Btn.Name = "LoadAppointMents_Btn";
            this.LoadAppointMents_Btn.Size = new System.Drawing.Size(121, 28);
            this.LoadAppointMents_Btn.TabIndex = 21;
            this.LoadAppointMents_Btn.Text = "Load Appointments";
            this.LoadAppointMents_Btn.UseVisualStyleBackColor = true;
            this.LoadAppointMents_Btn.Click += new System.EventHandler(this.LoadAppointMents_Btn_Click);
            // 
            // DeleAppointment
            // 
            this.DeleAppointment.FormattingEnabled = true;
            this.DeleAppointment.Location = new System.Drawing.Point(60, 206);
            this.DeleAppointment.Name = "DeleAppointment";
            this.DeleAppointment.Size = new System.Drawing.Size(210, 21);
            this.DeleAppointment.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add  Appointment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Location = new System.Drawing.Point(47, 72);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(43, 13);
            this.Patient.TabIndex = 22;
            this.Patient.Text = "Patient:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(280, 576);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 155);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Available Hours";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Delete Work Date";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Date:";
            // 
            // DeleteWorkHours
            // 
            this.DeleteWorkHours.FormatString = "f";
            this.DeleteWorkHours.FormattingEnabled = true;
            this.DeleteWorkHours.Location = new System.Drawing.Point(69, 56);
            this.DeleteWorkHours.Name = "DeleteWorkHours";
            this.DeleteWorkHours.Size = new System.Drawing.Size(121, 21);
            this.DeleteWorkHours.TabIndex = 36;
            // 
            // DeleteWorkHoursDoc
            // 
            this.DeleteWorkHoursDoc.FormattingEnabled = true;
            this.DeleteWorkHoursDoc.Location = new System.Drawing.Point(69, 23);
            this.DeleteWorkHoursDoc.Name = "DeleteWorkHoursDoc";
            this.DeleteWorkHoursDoc.Size = new System.Drawing.Size(121, 21);
            this.DeleteWorkHoursDoc.TabIndex = 32;
            this.DeleteWorkHoursDoc.SelectedIndexChanged += new System.EventHandler(this.DeleteWorkHoursDoc_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
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
            this.groupBox3.Location = new System.Drawing.Point(18, 576);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 155);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Available Hours";
            // 
            // Add_New_WorkDate
            // 
            this.Add_New_WorkDate.Location = new System.Drawing.Point(81, 115);
            this.Add_New_WorkDate.Name = "Add_New_WorkDate";
            this.Add_New_WorkDate.Size = new System.Drawing.Size(101, 23);
            this.Add_New_WorkDate.TabIndex = 31;
            this.Add_New_WorkDate.Text = "Add Workdate";
            this.Add_New_WorkDate.UseVisualStyleBackColor = true;
            this.Add_New_WorkDate.Click += new System.EventHandler(this.Add_New_WorkDate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(25, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Date:";
            // 
            // NewWorkdate
            // 
            this.NewWorkdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewWorkdate.Location = new System.Drawing.Point(81, 53);
            this.NewWorkdate.Name = "NewWorkdate";
            this.NewWorkdate.Size = new System.Drawing.Size(121, 20);
            this.NewWorkdate.TabIndex = 27;
            // 
            // Docters_add_hours
            // 
            this.Docters_add_hours.FormattingEnabled = true;
            this.Docters_add_hours.Location = new System.Drawing.Point(81, 26);
            this.Docters_add_hours.Name = "Docters_add_hours";
            this.Docters_add_hours.Size = new System.Drawing.Size(121, 21);
            this.Docters_add_hours.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
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
            this.groupBox4.Location = new System.Drawing.Point(18, 750);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(858, 153);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Treatment";
            // 
            // NameOfTreatment_txb
            // 
            this.NameOfTreatment_txb.Location = new System.Drawing.Point(102, 116);
            this.NameOfTreatment_txb.Name = "NameOfTreatment_txb";
            this.NameOfTreatment_txb.Size = new System.Drawing.Size(100, 20);
            this.NameOfTreatment_txb.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Treament Name:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(662, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 51);
            this.button6.TabIndex = 45;
            this.button6.Text = "Add Treatment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.RecoveryNum);
            this.groupBox7.Location = new System.Drawing.Point(448, 89);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(165, 53);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operation";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Recovery:";
            // 
            // RecoveryNum
            // 
            this.RecoveryNum.Location = new System.Drawing.Point(68, 21);
            this.RecoveryNum.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.RecoveryNum.Name = "RecoveryNum";
            this.RecoveryNum.Size = new System.Drawing.Size(80, 20);
            this.RecoveryNum.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.DosageNum);
            this.groupBox6.Location = new System.Drawing.Point(452, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 58);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Medicine";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Dosage:";
            // 
            // DosageNum
            // 
            this.DosageNum.Location = new System.Drawing.Point(51, 21);
            this.DosageNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DosageNum.Name = "DosageNum";
            this.DosageNum.Size = new System.Drawing.Size(80, 20);
            this.DosageNum.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(213, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Start Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(278, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(213, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Number of Days:";
            // 
            // NumberOfDaysNum
            // 
            this.NumberOfDaysNum.Location = new System.Drawing.Point(305, 34);
            this.NumberOfDaysNum.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumberOfDaysNum.Name = "NumberOfDaysNum";
            this.NumberOfDaysNum.Size = new System.Drawing.Size(70, 20);
            this.NumberOfDaysNum.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Treatment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
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
            this.Treatments.Location = new System.Drawing.Point(72, 33);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(121, 21);
            this.Treatments.TabIndex = 21;
            // 
            // Add_treament_patient
            // 
            this.Add_treament_patient.FormattingEnabled = true;
            this.Add_treament_patient.Location = new System.Drawing.Point(72, 74);
            this.Add_treament_patient.Name = "Add_treament_patient";
            this.Add_treament_patient.Size = new System.Drawing.Size(121, 21);
            this.Add_treament_patient.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 913);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AppointMents);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.groupBox1);
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

