using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalWentBad
{
    /// <summary>
    /// This class is full of long methods and duplications. Barf! 
    /// Can inheritance help you?
    /// BTW: This class is not the only class with duplications!
    /// </summary>
    public class RentalAdministration
    {
        // Contains the collection of sedans, limousines and trucks
        private List<Car> cars;

        /// <summary>
        /// The cars in the administration
        /// </summary>
        public List<Car> Cars
        {
            get { return new List<Car>(cars); }
        }

        /// <summary>
        /// The limousines in the administration
        /// </summary>
        public RentalAdministration()
        {
            cars = new List<Car>();
        }

        /// <summary>
        /// Add a sedan to the administration
        /// </summary>
        /// <param name="sedan">The sedan to be added to the administration</param>
        public void Add(Car car)
        {
            if (cars != null)
            {
                cars.Add(car);
            }
        }

        /// <summary>
        /// Rent a car
        /// </summary>
        /// <param name="licencePlate">The licence plate of the car to rent</param>
        /// <param name="rentalDate">The start date for the rental</param>
        /// <returns>true if the car was available for renting, false otherwise.</returns>
        public bool RentCar(string licencePlate, SimpleDate rentalDate)
        {
            Car foundCar = null;
            foreach(Car car in cars)
            {
                if(car.LicencePlate == licencePlate)
                {
                    foundCar = car;
                    break;
                }
            }

            return false; // No car was found with the given licence plate.
        }

        /// <summary>
        /// Return a car to the administration of available cars
        /// </summary>
        /// <param name="licencePlate">The licence plate of the car to return.</param>
        /// <param name="returnDate">The date on which the car is returned.</param>
        /// <param name="kilometers">The total of kilometers of the car.</param>
        /// <returns>The cost of the rental, 
        ///          or a number less than zero when: 
        ///          - the car was not rented (so it could not be returned)
        ///          - the return date is before the rental date (so wrong return date was entered)
        ///          - the number of kilometers when returned is less then at the start of the rental.         
        /// Please note that returning as number less than zero for error situations is NOT(!!!)
        /// clean coding in this case. Later on you will learn to do this in a better fashion (Exceptions!)
        /// </returns>
        public decimal ReturnCar(string licencePlate, SimpleDate returnDate, int kilometers)
        {
            Car foundCar = null;
            foreach(Car car in cars)
            {
                if(car.LicencePlate == licencePlate)
                {
                    foundCar = car;
                }
            }

            if(foundCar  != null)
            {
                return foundCar.Return(returnDate, kilometers);
            }
            
            return -1; // No Car was found with the given licence plate. Cannot return.
        }
    }
}
