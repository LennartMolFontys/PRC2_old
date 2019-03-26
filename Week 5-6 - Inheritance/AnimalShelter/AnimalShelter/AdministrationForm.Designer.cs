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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(106, 16);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 297);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(85, 28);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(257, 297);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(100, 28);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // ChipregistrationNBTextBox
            // 
            this.ChipregistrationNBTextBox.Location = new System.Drawing.Point(106, 47);
            this.ChipregistrationNBTextBox.Name = "ChipregistrationNBTextBox";
            this.ChipregistrationNBTextBox.Size = new System.Drawing.Size(160, 22);
            this.ChipregistrationNBTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(106, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(160, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBirthDay.Location = new System.Drawing.Point(106, 103);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
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
            this.groupBox2.Location = new System.Drawing.Point(20, 229);
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
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chip Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Day Of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Animal:";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeBirthDay);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ChipregistrationNBTextBox);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

