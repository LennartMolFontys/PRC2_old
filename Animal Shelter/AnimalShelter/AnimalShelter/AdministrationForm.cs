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
       private Administration administration = new Administration();
        


        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
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
                administration.Add(new Dog(RegistrationNumber, birthday, name, Lastwalk));
            }
            if(animalTypeComboBox.SelectedItem.ToString().ToUpper() == "CAT")
            {
                string badHabits = BadHabitsTextBox.Text;
                administration.Add(new Cat(RegistrationNumber, birthday, name, badHabits));
            }
            administration.SortList();
            DisplayAnimals();
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
           int index = ShowInfoComBox.SelectedIndex;
           MessageBox.Show(administration.Animals[index].ToString());
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            AddAnimals();
            administration.SortList();
            DisplayAnimals();
            
        }

        private void DisplayAnimals()
        {
            ShowInfoComBox.Items.Clear();
            RemoveAnimalCombo.Items.Clear();
            ReserveCombo.Items.Clear();
            UnreserveCombo.Items.Clear();
            NotReservedListB.Items.Clear();
            ReservedListB.Items.Clear();

            foreach(Animal s in administration.Animals)
            {
                ShowInfoComBox.Items.Add(s.Name);
                RemoveAnimalCombo.Items.Add(s.Name);
                ReserveCombo.Items.Add(s.Name);
                

                if(s.IsReserved != true)
                {
                   NotReservedListB.Items.Add(s.Name);
                }
                else
                {
                    ReservedListB.Items.Add(s.Name);
                    UnreserveCombo.Items.Add(s.Name);
                }
            }
        }

        private void AddAnimals()
        {
            administration.Add(new Cat(4,new SimpleDate(1,2,2000), "Jerry", "MoonWalking"));
            administration.Add(new Dog(8, new SimpleDate(1, 2, 2001), "Tommy", new SimpleDate(5, 8, 2012)));
            administration.Add(new Cat(6, new SimpleDate(1, 2, 2002), "Bert", "Sleeping"));
            administration.Add(new Dog(9, new SimpleDate(1, 2, 2003), "Luna", new SimpleDate(5, 8, 2013)));
        }

        private void RemoveAnimelBtn_Click(object sender, EventArgs e)
        {
            int index = RemoveAnimalCombo.SelectedIndex;
            administration.RemoveAnimal(administration.Animals[index].ChipRegistrationNumber);
            DisplayAnimals();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            int index = ReserveCombo.SelectedIndex;
            administration.Animals[index].IsReserved = true;
            DisplayAnimals();
        }

        private void Unreserve_Click(object sender, EventArgs e)
        {
            string animal = UnreserveCombo.SelectedItem.ToString();
            for(int i = 0; i < administration.Animals.Count; i ++)
            {
                if(administration.Animals[i].Name.ToUpper() == animal.ToUpper())
                {
                    administration.Animals[i].IsReserved = false;
                }
            }
            UnreserveCombo.Text = string.Empty;
            DisplayAnimals();
        }
    }
}
