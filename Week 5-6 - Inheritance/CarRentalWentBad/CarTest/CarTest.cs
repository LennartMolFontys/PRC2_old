using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalWentBad;

namespace CarTest
{
    [TestClass]
    public class CarTest
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
        public void TestKilometersInit()
        {
            //arange 
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;

            //add
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            //assert
            Assert.AreEqual(0, sedan.Kilometers);

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

        [TestMethod]
        public void TestStringOverRide()
        {
            // arrange
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;

            // add
            Sedan SedanClass = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);
            Car sedanCarClass = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            // assert
            Assert.AreEqual(SedanClass.ToString(), sedanCarClass.ToString());
        }

        [TestMethod]
        public void TestReturnMethod()
        {
            // arrange
            string manufacturer = "Manufacturer";
            string model = "TestModel";
            string licencePlate = "TestPlate1234";
            int buildYear = 2000;
            bool hasTowBar = false;
            Car sedan = new Sedan(manufacturer, model, licencePlate, buildYear, hasTowBar);

            // add
            decimal returntest = sedan.Return(new SimpleDate(05, 08, 2000), 50);

            // assert
            Assert.AreEqual(-1, returntest);
        }
    }
}
