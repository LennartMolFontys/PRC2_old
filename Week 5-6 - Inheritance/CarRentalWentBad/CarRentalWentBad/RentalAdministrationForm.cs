using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalWentBad
{
    public partial class RentalAdministrationForm : Form
    {
        private RentalAdministration administration;

        /// <summary>
        /// Contains a UI to test the RentalAdministration.
        /// </summary>
        public RentalAdministrationForm()
        {
            InitializeComponent();
            miniBarComboBox.SelectedIndex = 0;
            towBarComboBox.SelectedIndex = 0;
            offroadComboBox.SelectedIndex = 0;
            rentalDateTimePicker.Value = DateTime.Today;
            returnDateTimePicker.Value = DateTime.Today;
            administration = new RentalAdministration();
            AddSomeCars();
        }

        /// <summary>
        /// Add some test cars
        /// </summary>
        private void AddSomeCars()
        {
            administration.Add(new Sedan("Opel", "Insignia 2.2L", "123456", 1995, false));
            administration.Add(new Sedan("Skoda", "Oktavia 1.8T", "234567", 2005, true));
            administration.Add(new Truck("DAF", "LF45 FR118", "345678", 2000, 50000, 8000));
            administration.Add(new Limousine("Lincoln", "Learjet", "456789", 1998, true));
            administration.Add(new Offroad("Manufacturer", "Model", "Licenseplate", 2000, true));
            UpdateAvailableCarListAndRentedCarLists();
        }


        /// <summary>
        /// Adds a truck to the adminitration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTruckButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int buildYear;
            int cargoSpace;
            int maxWeight;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && !string.IsNullOrWhiteSpace(licencePlateTextBox.Text)
                && Int32.TryParse(nudBuildYear.Text, out buildYear)
                && Int32.TryParse(cargoSpaceTextBox.Text, out cargoSpace)
                && Int32.TryParse(maxWeightTextBox.Text, out maxWeight))
            {
                Truck truck = new Truck(manufacturerTextBox.Text, modelTextBox.Text,
                                        licencePlate, buildYear, cargoSpace, maxWeight);
                administration.Add(truck);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the truck is entered or the data entered has the wrong format.");
            }
        }


        /// <summary>
        /// Adds a limousine to the administration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addLimousineButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int buildYear = (int)nudBuildYear.Value;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && (miniBarComboBox.Text == "Yes" || miniBarComboBox.Text == "No"))
            {
                bool hasMiniBar = miniBarComboBox.Text == "Yes";
                Limousine limousine = new Limousine(manufacturerTextBox.Text, modelTextBox.Text,
                                                    licencePlate, buildYear, hasMiniBar);
                administration.Add(limousine);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the limousine is entered or the data entered has the wrong format.");
            }
        }

        /// <summary>
        /// Adds a sedan to the administration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSedanButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int buildYear;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && !string.IsNullOrWhiteSpace(licencePlate)
                && Int32.TryParse(nudBuildYear.Text, out buildYear)
                && (towBarComboBox.Text == "Yes" || towBarComboBox.Text == "No"))
            {
                bool hasTowBar = towBarComboBox.Text == "Yes";
                Sedan sedan = new Sedan(manufacturerTextBox.Text, modelTextBox.Text,
                                        licencePlate, buildYear, hasTowBar);
                administration.Add(sedan);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the sedan is entered or the data entered has the wrong format.");
            }
        }

        private void addOffroadButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int buildYear;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && !string.IsNullOrWhiteSpace(licencePlate)
                && Int32.TryParse(nudBuildYear.Text, out buildYear)
                && (offroadComboBox.Text == "Yes" || offroadComboBox.Text == "No"))
            {
                bool hasFourWheelDrive = offroadComboBox.Text == "Yes";
                Offroad offroad = new Offroad(manufacturerTextBox.Text, modelTextBox.Text,
                                        licencePlate, buildYear, hasFourWheelDrive);
                administration.Add(offroad);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the offroad is entered or the data entered has the wrong format.");
            }
        }

        /// <summary>
        /// Updates the GUI list of available and rented cars.
        /// </summary>
        private void UpdateAvailableCarListAndRentedCarLists()
        {
            availableCarsListBox.Items.Clear();
            rentedCarsListBox.Items.Clear();

            List<Sedan> sedans = administration.Sedans;
            foreach (Sedan sedan in sedans)
            {
                if (sedan.IsAvailable)
                {
                    availableCarsListBox.Items.Add(sedan);
                }
                else
                {
                    rentedCarsListBox.Items.Add(sedan);
                }
            }

            List<Limousine> limousines = administration.Limousines;
            foreach (Limousine limousine in limousines)
            {
                if (limousine.IsAvailable)
                {
                    availableCarsListBox.Items.Add(limousine);
                }
                else
                {
                    rentedCarsListBox.Items.Add(limousine);
                }
            }

            List<Truck> trucks = administration.Trucks;
            foreach (Truck truck in trucks)
            {
                if (truck.IsAvailable)
                {
                    availableCarsListBox.Items.Add(truck);
                }
                else
                {
                    rentedCarsListBox.Items.Add(truck);
                }
            }

            List<Offroad> offroads = administration.Offroads;
            foreach (Offroad offroad in offroads)
            {
                if (offroad.IsAvailable)
                {
                    availableCarsListBox.Items.Add(offroad);
                }
                else
                {
                    rentedCarsListBox.Items.Add(offroad);
                }
            }
        }

        /// <summary>
        /// Rent the car using the licence plate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rentCarButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            if (!string.IsNullOrWhiteSpace(licencePlate))
            {
                SimpleDate date = new SimpleDate(rentalDateTimePicker.Value.Day,
                                                 rentalDateTimePicker.Value.Month,
                                                 rentalDateTimePicker.Value.Year);
                bool isRented = administration.RentCar(licencePlate, date);
                if (isRented)
                {
                    UpdateAvailableCarListAndRentedCarLists();
                }
                else
                {
                    MessageBox.Show("There's no car with licence plate: '"
                                    + licencePlate + "' or the car is already rented.");
                }
            }
            else
            {
                MessageBox.Show("The licence plate has the wrong format.");
            }
        }

        /// <summary>
        /// Return a car using the licence plate number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnCarButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int kilometers;
            if (!string.IsNullOrWhiteSpace(licencePlate)
                && Int32.TryParse(returnKilometersTextBox.Text, out kilometers))
            {
                SimpleDate date = new SimpleDate(returnDateTimePicker.Value.Day,
                    returnDateTimePicker.Value.Month,
                    returnDateTimePicker.Value.Year);
                decimal price = administration.ReturnCar(licencePlate, date, kilometers);
                if (price >= 0)
                {
                    MessageBox.Show("Please Pay: '" + price + " credits'.");
                    UpdateAvailableCarListAndRentedCarLists();
                }
                else
                {
                    MessageBox.Show("No Car with licence plate: '" + licencePlate
                        + "'\nor the kilometers are less then when rented\nor the return date is invalid (before rental date)\nor the car was not rented and cannot be returned.");
                }
            }
            else
            {
                MessageBox.Show("The licence plate and/or kilometers are entered wrong format.");
            }
        }
    }
}
