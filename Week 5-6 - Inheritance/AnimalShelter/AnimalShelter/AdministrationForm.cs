using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            int RegistrationNumber;
            string name = NameTextBox.Text;
            SimpleDate Lastwalk;
            bool Checkint = Int32.TryParse(ChipregistrationNBTextBox.Text, out RegistrationNumber);
            SimpleDate birthday = new SimpleDate(dateTimeBirthDay.Value.Day, dateTimeBirthDay.Value.Month, dateTimeBirthDay.Value.Year);


            if (animalTypeComboBox.SelectedItem.ToString().ToUpper() == "DOG")
            {
                if (LastWalkDayCheckBox.Checked == true)
                {
                    Lastwalk = null;
                }
                else
                {
                   Lastwalk = new SimpleDate(DateTimePickerLastWalk.Value.Day, DateTimePickerLastWalk.Value.Month, DateTimePickerLastWalk.Value.Year);
                }
                animal = new Dog(RegistrationNumber, birthday, name, Lastwalk);
            }
            if(animalTypeComboBox.SelectedItem.ToString().ToUpper() == "CAT")
            {
                string badHabits = BadHabitsTextBox.Text;
                animal = new Cat(RegistrationNumber, birthday, name, badHabits);
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(animal.ToString());
        }

    }
}
