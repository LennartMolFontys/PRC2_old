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
        private  SimpleDate RentalDate;
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
            set { kilometers = value; }
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
        }

        public bool Rent(SimpleDate rentalDate)
        {
            if (IsAvailable)
            {
                RentalDate = rentalDate;
                return true;
            }
            return false;
        }

        public abstract decimal Return(SimpleDate returnDate, int kilometers);

    }
}
