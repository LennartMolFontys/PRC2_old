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
            this.LastWalkDayCheckBox = new System.Windows.Forms.CheckBox();
            this.DateTimePickerLastWalk = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(17, 16);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(185, 12);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(85, 28);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(279, 12);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(100, 28);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // ChipregistrationNBTextBox
            // 
            this.ChipregistrationNBTextBox.Location = new System.Drawing.Point(107, 135);
            this.ChipregistrationNBTextBox.Name = "ChipregistrationNBTextBox";
            this.ChipregistrationNBTextBox.Size = new System.Drawing.Size(118, 22);
            this.ChipregistrationNBTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(107, 163);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(118, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBirthDay.Location = new System.Drawing.Point(107, 191);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(118, 22);
            this.dateTimeBirthDay.TabIndex = 5;
            this.dateTimeBirthDay.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // BadHabitsTextBox
            // 
            this.BadHabitsTextBox.Location = new System.Drawing.Point(265, 275);
            this.BadHabitsTextBox.Name = "BadHabitsTextBox";
            this.BadHabitsTextBox.Size = new System.Drawing.Size(118, 22);
            this.BadHabitsTextBox.TabIndex = 6;
            // 
            // LastWalkDayCheckBox
            // 
            this.LastWalkDayCheckBox.AutoSize = true;
            this.LastWalkDayCheckBox.Location = new System.Drawing.Point(107, 249);
            this.LastWalkDayCheckBox.Name = "LastWalkDayCheckBox";
            this.LastWalkDayCheckBox.Size = new System.Drawing.Size(88, 21);
            this.LastWalkDayCheckBox.TabIndex = 7;
            this.LastWalkDayCheckBox.Text = "Unknown";
            this.LastWalkDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerLastWalk
            // 
            this.DateTimePickerLastWalk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerLastWalk.Location = new System.Drawing.Point(107, 276);
            this.DateTimePickerLastWalk.Name = "DateTimePickerLastWalk";
            this.DateTimePickerLastWalk.Size = new System.Drawing.Size(118, 22);
            this.DateTimePickerLastWalk.TabIndex = 8;
            this.DateTimePickerLastWalk.Value = new System.DateTime(2019, 3, 19, 12, 48, 28, 0);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 402);
            this.Controls.Add(this.DateTimePickerLastWalk);
            this.Controls.Add(this.LastWalkDayCheckBox);
            this.Controls.Add(this.BadHabitsTextBox);
            this.Controls.Add(this.dateTimeBirthDay);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ChipregistrationNBTextBox);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox LastWalkDayCheckBox;
        private System.Windows.Forms.DateTimePicker DateTimePickerLastWalk;
    }
}

