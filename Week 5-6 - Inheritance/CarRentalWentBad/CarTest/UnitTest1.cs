using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalWentBad;

namespace CarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestManufacturer()
        {
            // arrange
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;
            
            // add
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            // assert
            Assert.AreEqual(manufacturer, sedan.Manufacturer);
        }

        [TestMethod]
        public void TestModel()
        {
            // arrange
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;

            // add
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            // assert
            Assert.AreEqual(model, sedan.Model);
        }

        [TestMethod]
        public void TestCarRentTrue()
        {
            // arrange
            
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            // add
            bool rent = sedan.Rent(new SimpleDate(02, 08, 1999));

            // assert
            Assert.AreEqual(true, rent);
        }

        [TestMethod]
        public void TestCarRentFalse()
        {
            // arrange

            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);
            bool rent = sedan.Rent(new SimpleDate(02, 08, 1999));

            // add
            rent = sedan.Rent(new SimpleDate(02, 08, 1999));

            // assert
            Assert.AreEqual(false, rent);
        }


    }
}
