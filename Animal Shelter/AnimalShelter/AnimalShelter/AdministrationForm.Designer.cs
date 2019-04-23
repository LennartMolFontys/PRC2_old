namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.ChipregistrationNBTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.BadHabitsTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePickerLastWalk = new System.Windows.Forms.DateTimePicker();
            this.LastWalkDayCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShowInfoComBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RemoveAnimelBtn = new System.Windows.Forms.Button();
            this.RemoveAnimalCombo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ReserveCombo = new System.Windows.Forms.ComboBox();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NotReservedListB = new System.Windows.Forms.ListBox();
            this.ReservedListB = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Unreserve = new System.Windows.Forms.Button();
            this.UnreserveCombo = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Load_File = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(107, 22);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(119, 318);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(139, 28);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create Animal";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(14, 53);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(121, 28);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // ChipregistrationNBTextBox
            // 
            this.ChipregistrationNBTextBox.Location = new System.Drawing.Point(107, 53);
            this.ChipregistrationNBTextBox.Name = "ChipregistrationNBTextBox";
            this.ChipregistrationNBTextBox.Size = new System.Drawing.Size(160, 22);
            this.ChipregistrationNBTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(107, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(160, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBirthDay.Location = new System.Drawing.Point(107, 109);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(118, 22);
            this.dateTimeBirthDay.TabIndex = 5;
            this.dateTimeBirthDay.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // BadHabitsTextBox
            // 
            this.BadHabitsTextBox.Location = new System.Drawing.Point(109, 21);
            this.BadHabitsTextBox.Name = "BadHabitsTextBox";
            this.BadHabitsTextBox.Size = new System.Drawing.Size(118, 22);
            this.BadHabitsTextBox.TabIndex = 6;
            // 
            // DateTimePickerLastWalk
            // 
            this.DateTimePickerLastWalk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerLastWalk.Location = new System.Drawing.Point(113, 35);
            this.DateTimePickerLastWalk.Name = "DateTimePickerLastWalk";
            this.DateTimePickerLastWalk.Size = new System.Drawing.Size(118, 22);
            this.DateTimePickerLastWalk.TabIndex = 8;
            this.DateTimePickerLastWalk.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // LastWalkDayCheckBox
            // 
            this.LastWalkDayCheckBox.AutoSize = true;
            this.LastWalkDayCheckBox.Checked = true;
            this.LastWalkDayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastWalkDayCheckBox.Location = new System.Drawing.Point(253, 35);
            this.LastWalkDayCheckBox.Name = "LastWalkDayCheckBox";
            this.LastWalkDayCheckBox.Size = new System.Drawing.Size(88, 21);
            this.LastWalkDayCheckBox.TabIndex = 7;
            this.LastWalkDayCheckBox.Text = "Unknown";
            this.LastWalkDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LastWalkDayCheckBox);
            this.groupBox1.Controls.Add(this.DateTimePickerLastWalk);
            this.groupBox1.Location = new System.Drawing.Point(17, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last walk Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BadHabitsTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bad habits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chip Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Day Of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Animal:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dateTimeBirthDay);
            this.groupBox3.Controls.Add(this.NameTextBox);
            this.groupBox3.Controls.Add(this.ChipregistrationNBTextBox);
            this.groupBox3.Controls.Add(this.createAnimalButton);
            this.groupBox3.Controls.Add(this.animalTypeComboBox);
            this.groupBox3.Location = new System.Drawing.Point(27, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 380);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Animal";
            // 
            // ShowInfoComBox
            // 
            this.ShowInfoComBox.FormattingEnabled = true;
            this.ShowInfoComBox.Location = new System.Drawing.Point(14, 21);
            this.ShowInfoComBox.Name = "ShowInfoComBox";
            this.ShowInfoComBox.Size = new System.Drawing.Size(121, 24);
            this.ShowInfoComBox.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShowInfoComBox);
            this.groupBox4.Controls.Add(this.showInfoButton);
            this.groupBox4.Location = new System.Drawing.Point(431, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 93);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Info";
            // 
            // RemoveAnimelBtn
            // 
            this.RemoveAnimelBtn.Location = new System.Drawing.Point(14, 49);
            this.RemoveAnimelBtn.Name = "RemoveAnimelBtn";
            this.RemoveAnimelBtn.Size = new System.Drawing.Size(121, 33);
            this.RemoveAnimelBtn.TabIndex = 18;
            this.RemoveAnimelBtn.Text = "Remove ";
            this.RemoveAnimelBtn.UseVisualStyleBackColor = true;
            this.RemoveAnimelBtn.Click += new System.EventHandler(this.RemoveAnimelBtn_Click);
            // 
            // RemoveAnimalCombo
            // 
            this.RemoveAnimalCombo.FormattingEnabled = true;
            this.RemoveAnimalCombo.Location = new System.Drawing.Point(14, 21);
            this.RemoveAnimalCombo.Name = "RemoveAnimalCombo";
            this.RemoveAnimalCombo.Size = new System.Drawing.Size(121, 24);
            this.RemoveAnimalCombo.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RemoveAnimalCombo);
            this.groupBox5.Controls.Add(this.RemoveAnimelBtn);
            this.groupBox5.Location = new System.Drawing.Point(431, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 90);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remove Animal";
            // 
            // ReserveCombo
            // 
            this.ReserveCombo.FormattingEnabled = true;
            this.ReserveCombo.Location = new System.Drawing.Point(14, 21);
            this.ReserveCombo.Name = "ReserveCombo";
            this.ReserveCombo.Size = new System.Drawing.Size(121, 24);
            this.ReserveCombo.TabIndex = 21;
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.Location = new System.Drawing.Point(14, 51);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(121, 28);
            this.ReserveBtn.TabIndex = 22;
            this.ReserveBtn.Text = "Reserve";
            this.ReserveBtn.UseVisualStyleBackColor = true;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ReserveBtn);
            this.groupBox6.Controls.Add(this.ReserveCombo);
            this.groupBox6.Location = new System.Drawing.Point(431, 238);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(162, 83);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reserve Animal";
            // 
            // NotReservedListB
            // 
            this.NotReservedListB.FormattingEnabled = true;
            this.NotReservedListB.ItemHeight = 16;
            this.NotReservedListB.Location = new System.Drawing.Point(634, 63);
            this.NotReservedListB.Name = "NotReservedListB";
            this.NotReservedListB.Size = new System.Drawing.Size(298, 164);
            this.NotReservedListB.TabIndex = 24;
            // 
            // ReservedListB
            // 
            this.ReservedListB.FormattingEnabled = true;
            this.ReservedListB.ItemHeight = 16;
            this.ReservedListB.Location = new System.Drawing.Point(634, 259);
            this.ReservedListB.Name = "ReservedListB";
            this.ReservedListB.Size = new System.Drawing.Size(298, 164);
            this.ReservedListB.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Not Reserved Animals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Reserved Animals";
            // 
            // Unreserve
            // 
            this.Unreserve.Location = new System.Drawing.Point(14, 51);
            this.Unreserve.Name = "Unreserve";
            this.Unreserve.Size = new System.Drawing.Size(121, 32);
            this.Unreserve.TabIndex = 24;
            this.Unreserve.Text = "Unreserve";
            this.Unreserve.UseVisualStyleBackColor = true;
            this.Unreserve.Click += new System.EventHandler(this.Unreserve_Click);
            // 
            // UnreserveCombo
            // 
            this.UnreserveCombo.FormattingEnabled = true;
            this.UnreserveCombo.Location = new System.Drawing.Point(14, 21);
            this.UnreserveCombo.Name = "UnreserveCombo";
            this.UnreserveCombo.Size = new System.Drawing.Size(121, 24);
            this.UnreserveCombo.TabIndex = 28;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.UnreserveCombo);
            this.groupBox7.Controls.Add(this.Unreserve);
            this.groupBox7.Location = new System.Drawing.Point(431, 327);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(161, 96);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unreserve";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(154, 438);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 32);
            this.SaveBtn.TabIndex = 30;
            this.SaveBtn.Text = "Save File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Load_File
            // 
            this.Load_File.Location = new System.Drawing.Point(27, 5);
            this.Load_File.Name = "Load_File";
            this.Load_File.Size = new System.Drawing.Size(121, 32);
            this.Load_File.TabIndex = 31;
            this.Load_File.Text = "Load File";
            this.Load_File.UseVisualStyleBackColor = true;
            this.Load_File.Click += new System.EventHandler(this.Load_File_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(715, 438);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(121, 32);
            this.ExportBtn.TabIndex = 32;
            this.ExportBtn.Text = "Export File";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 493);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.Load_File);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReservedListB);
            this.Controls.Add(this.NotReservedListB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox ChipregistrationNBTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.TextBox BadHabitsTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePickerLastWalk;
        private System.Windows.Forms.CheckBox LastWalkDayCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ShowInfoComBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button RemoveAnimelBtn;
        private System.Windows.Forms.ComboBox RemoveAnimalCombo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox ReserveCombo;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox NotReservedListB;
        private System.Windows.Forms.ListBox ReservedListB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Unreserve;
        private System.Windows.Forms.ComboBox UnreserveCombo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Load_File;
        private System.Windows.Forms.Button ExportBtn;
    }
}

