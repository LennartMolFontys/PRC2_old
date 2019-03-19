using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalWentBad;

namespace CarTest
{
    [TestClass]
    public class RentalAdministrationTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // arrange
            RentalAdministration Test;

            // add
            Test = new RentalAdministration();

            // assert
            Assert.AreEqual(0, Test.Cars.Count);
        }

        [TestMethod]
        public void AddCarTest()
        {
            // arrrange
            RentalAdministration Test = new RentalAdministration();

            // add
            Test.Add(new Sedan("TestManuFracturer", "TestModel", "123456789", 2019, false));

            // assert
            Assert.AreEqual(1, Test.Cars.Count);
            Assert.AreEqual("TestModel", Test.Cars[0].Model);
        } 
    }
}
