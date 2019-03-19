using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    public class Sedan : Car
    {

        /// <summary>
        /// Does the sedan have a towbar?
        /// </summary>
        public bool HasTowbar { get; private set; }

        /// <summary>
        /// Creates a sedan
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the sedan</param>
        /// <param name="model">The model of the sedan</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="hasTowbar">Does the sedan have a towbar for towing.</param>
        public Sedan(string Manufacturer, string Model, string LicencePlate, int BuildYear, bool hasTowBar) : base (Manufacturer, Model, LicencePlate, BuildYear)
        {
            HasTowbar = hasTowBar;
        }

        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        protected override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 80m;
            const decimal kmRate = 0.19m;
            decimal towbarDayRate;
            if (HasTowbar)
            {
                towbarDayRate = 5m;
            }
            else
            {
                towbarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (towbarDayRate * daysRented);
        }

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

            string towbarInfo;
            if (HasTowbar)
            {
                towbarInfo = "with towbar";
            }
            else
            {
                towbarInfo = "without towbar";
            }


            return "Sedan: "
                + LicencePlate
                + ", " + BuildYear
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + towbarInfo;
        }
    }
}
