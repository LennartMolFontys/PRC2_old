using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    public abstract class Car
    {
        
        private string manufacturer;
        private string model;
        private string licencePlate;
        private int buildYear;
        private int kilometers;
        private  SimpleDate rentalDate;
        public SimpleDate RentalDate
        {
            get { return rentalDate; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
        }
        public string Model
        {
            get { return model; }
        }
        public string LicencePlate
        {
            get { return licencePlate; }
        }
        public int BuildYear
        {
            get { return buildYear; }
        }
        public int Kilometers
        {
            get { return kilometers; }
            //set { kilometers = value; }
        }
        public bool IsAvailable
        {
            get { return RentalDate == null; }
        }

        // Constructor
        public Car(string Manufacturer, string Model, string LicencePlate, int BuildYear)
        {
            manufacturer = Manufacturer;
            model = Model;
            licencePlate = LicencePlate;
            buildYear = BuildYear;
            kilometers = 0;
            rentalDate = null;
        }

        public bool Rent(SimpleDate rentalDate)
        {
            if (IsAvailable)
            {
                this.rentalDate = rentalDate;
                return true;
            }
            return false;
        }

        protected abstract decimal CalculateRentalCosts(int daysRented, int kilometersDriven);

        public abstract override string ToString();

        public decimal Return(SimpleDate returnDate, int kilometers)
        {
            if (!IsAvailable)
            {
                int daysRented = RentalDate.DaysDifference(returnDate);
                int kilometersDriven = kilometers - Kilometers;

                if (daysRented >= 0 && kilometersDriven >= 0)
                {
                    rentalDate = null;    // makes the limousine available for renting again
                    this.kilometers = kilometers; // update kms for the next rental
                    return CalculateRentalCosts(daysRented, kilometersDriven);
                }
            }
            return -1;
        }
    }
}
