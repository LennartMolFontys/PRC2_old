using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    public class Truck : Car
    {
        /// <summary>
        /// The starting date of the rental period. Contains null if not rented (IsAvailable == true).
        /// </summary>
        public SimpleDate RentalDate { get; private set; }

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
            RentalDate = null;
        }

        /// <summary>
        /// Returns a rented truck and calculate the costs of the rental. 
        /// Only rented trucks can be returned.
        /// </summary>
        /// <param name="returnDate">The date on which the truck is returned.</param>
        /// <param name="kilometers">The total number of kilometers on the counter.</param>
        /// <returns>The cost of the rental, 
        ///          or a number less than zero when: 
        ///          - the truck was not rented (so it could not be returned)
        ///          - the return date is before the rental date  (so wrong return date was entered)
        ///          - the number of kilometers when returned is less then at the start of the rental.         
        /// Please note that returning as number less than zero for error situations is NOT(!!!)
        /// clean coding in this case. Later on you will learn to do this in a better fashion (Exceptions!)
        /// </returns>
        public override decimal Return(SimpleDate returnDate, int kilometers)
        {
            if (!IsAvailable)
            {
                int daysRented = RentalDate.DaysDifference(returnDate);
                int kilometersDriven = kilometers -  Kilometers;

                if (daysRented >= 0 && kilometersDriven >= 0)
                {
                    RentalDate = null;    // makes the truck available for renting again
                    Kilometers = kilometers; // update kms for the next rental
                    return CalculateRentalCosts(daysRented, kilometersDriven);
                }
            }
            return -1;
        }

        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        private decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
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
