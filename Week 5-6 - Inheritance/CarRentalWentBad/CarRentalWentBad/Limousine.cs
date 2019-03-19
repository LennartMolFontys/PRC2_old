using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    public class Limousine : Car
    {
        /// <summary>
        /// The starting date of the rental period. Contains null if not rented (IsAvailable == true).
        /// </summary>

        /// <summary>
        /// Does the limousine have a minibar for storing cold drinks.
        /// </summary>
        public bool HasMinibar { get; private set; }

        /// <summary>
        /// Creates a limousine
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the limousine</param>
        /// <param name="model">The model of the limousine</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="hasMinibar">Does the limousine have a minibar for cold drinks?</param>
        public Limousine(string Manufacturer, string Model, string LicencePlate, int BuildYear, bool hasMiniBar) : base(Manufacturer, Model, LicencePlate, BuildYear)
        {
            HasMinibar = hasMiniBar;
        }

       

        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        protected override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 200m;
            const decimal kmRate = 0.25m;
            decimal minibarDayRate;
            if (HasMinibar)
            {
                minibarDayRate = 20m;
            }
            else
            {
                minibarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (minibarDayRate * daysRented);
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

            string minibarInfo;
            if (HasMinibar)
            {
                minibarInfo = "with mini bar";
            }
            else
            {
                minibarInfo = "without mini bar";
            }


            return "Limousine: "
                + LicencePlate
                + ", " + BuildYear
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + minibarInfo;
        }
    }
}
