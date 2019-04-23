using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        private Administration administration = new Administration();
        private SaveFileDialog saveFile = new SaveFileDialog();
        private OpenFileDialog loadFile = new OpenFileDialog();

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
            if (animalTypeComboBox.SelectedItem.ToString().ToUpper() == "CAT")
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

            foreach (Animal s in administration.Animals)
            {
                ShowInfoComBox.Items.Add(s.Name);
                RemoveAnimalCombo.Items.Add(s.Name);
                ReserveCombo.Items.Add(s.Name);


                if (s.IsReserved != true)
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
            administration.Add(new Cat(4, new SimpleDate(1, 2, 2000), "Jerry", "MoonWalking"));
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
            for (int i = 0; i < administration.Animals.Count; i++)
            {
                if (administration.Animals[i].Name.ToUpper() == animal.ToUpper())
                {
                    administration.Animals[i].IsReserved = false;
                }
            }
            UnreserveCombo.Text = string.Empty;
            DisplayAnimals();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "TextFile|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Save(saveFile.FileName);
                }
                catch(SerializationException Exception)
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

        }
        

        private void Load_File_Click(object sender, EventArgs e)
        {
            loadFile.Filter = "Text File|*.txt";
            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Load(loadFile.FileName);
                }
                catch(SerializationException Exception)
                {
                    MessageBox.Show(Exception.ToString());
                }
                catch(ArgumentOutOfRangeException Exception)
                {
                    MessageBox.Show(Exception.ToString());
                }
                catch(NotSupportedException)
                {
                    MessageBox.Show("Unable to Read File");
                }
                catch(IOException Exception)
                {
                    MessageBox.Show("An error occurred when reading file: " + Exception.ToString());
                }
                catch(ArgumentException Exception)
                {
                    MessageBox.Show(Exception.ToString());
                }                   
                catch(ObjectDisposedException)
                {
                    MessageBox.Show("File is not open");
                }
            }
            DisplayAnimals();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text File|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    administration.Excport(saveFile.FileName);
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
        }
    }
}
