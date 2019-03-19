using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    public class Truck : Car
    {
        /// <summary>
        /// The cargo space of the truck (liters).
        /// </summary>
        public int CargoSpace { get; private set; }

        /// <summary>
        /// The weight of the load that truck can handle (kg).
        /// </summary>
        public int MaxWeigth { get; private set; }

        /// <summary>
        /// Creates a truck
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the truck</param>
        /// <param name="model">The model of the truck</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="cargoSpace">The cargo space (liters)</param>
        /// <param name="maxWeigth">The weight the truck can carry (kg)</param>
        public Truck(string Manufacturer, string Model, string LicencePlate, int BuildYear, int cargoSpace, int maxWeigth) : base(Manufacturer, Model, LicencePlate, BuildYear)
        {
            CargoSpace = cargoSpace;
            MaxWeigth = maxWeigth;
        }

        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        protected override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 400m;
            const decimal kmRate = 0.39m;

            return (dayRate * daysRented) + (kilometersDriven * kmRate);
        }

        /// <summary>
        /// Retrieve information about this truck
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing information about this truck.</returns>
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

            return "Truck: "
                + LicencePlate
                + ", " + BuildYear
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + CargoSpace
                + ", " + MaxWeigth;
        }
    }
}
