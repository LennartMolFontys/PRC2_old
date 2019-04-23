using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject2
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // arrange
            Cat cat;

            // set
             cat= new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual("Tommy", cat.Name);
            Assert.AreEqual(2, cat.ChipRegistrationNumber);
            Assert.AreEqual(false, cat.IsReserved);
        }

        [TestMethod]
        public void ConstructorTestNoBadHabit()
        {
            // arrange
            Cat cat;

            // set
            cat = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "");

            //Assert
            Assert.AreEqual("Tommy", cat.Name);
            Assert.AreEqual(2, cat.ChipRegistrationNumber);
            Assert.AreEqual(false, cat.IsReserved);
            Assert.AreEqual("", cat.BadHabits);
        }

        [TestMethod]
      
        public void TestPriceInterFaceCat()
        {
            // arrange
            Cat cat;
            decimal expected = 50;

            // set
            cat = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual(expected, cat.Price);
        }

        [TestMethod]
        public void TestPriceInterFaceLowerThen20()
        {
            // arrange
            Cat animal;
            decimal expected = 20;

            // set
            animal = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching,Scratching,Scratching,Scratching,Scratching");

            //Assert
            Assert.AreEqual(expected, animal.Price);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            // arrange
            Cat cat;
            string expected = "2, 01-08-1999, Tommy, not reserved, Scratching";

            // set
            cat = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual(expected, cat.ToString());
        }

        [TestMethod]
        public void TestTostringMethodNoBadhabits()
        {
            // arrange
            Cat cat;
            string expected = "2, 01-08-1999, Tommy, not reserved, none";

            // set
            cat = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "");

            //Assert
            Assert.AreEqual(expected, cat.ToString());
        }


    }
}
