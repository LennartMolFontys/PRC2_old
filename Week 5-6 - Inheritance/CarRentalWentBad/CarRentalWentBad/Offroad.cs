using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad 
{
    public class Offroad : Car
    {


        /// <summary>
        /// Does the limousine have a minibar for storing cold drinks.
        /// </summary>
        public bool HasFourWheelDrive { get; private set; }

        /// <summary>
        /// Creates a limousine
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the limousine</param>
        /// <param name="model">The model of the limousine</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="hasMinibar">Does the limousine have a minibar for cold drinks?</param>
        public Offroad(string Manufacturer, string Model, string LicencePlate, int BuildYear, bool hasFourWheelDrive) : base(Manufacturer, Model, LicencePlate, BuildYear)
        {
            HasFourWheelDrive = hasFourWheelDrive;
        }


        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        protected override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 170m;
            const decimal kmRate = 0.35m;

            return (dayRate * daysRented) + (kilometersDriven * kmRate);
        }

        /// <summary>
        /// Retrieve information about this limousine
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing information about this limosine.</returns>
        public override string ToString()
        {
            string availableInfo;
            if (IsAvailable)
            {
                availableInfo = "available";
            }
            else
            {
                availableInfo = "not available";
            }

            string fourWheelDriveInfo;
            if (HasFourWheelDrive)
            {
                fourWheelDriveInfo = "with fourwheeldrive";
            }
            else
            {
                fourWheelDriveInfo = "without fourwheeldrive";
            }


            return "Offroad: "
                + LicencePlate
                + ", " + BuildYear
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + fourWheelDriveInfo;
        }
    }
}

