using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject2
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // act
            Dog dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual("Test", dog.Name);
            Assert.AreEqual(1, dog.ChipRegistrationNumber);
            Assert.AreEqual(false, dog.IsReserved);
            Assert.AreEqual("02-08-2001", dog.LastWalkDate.ToString());
        }

        [TestMethod]
        public void ConstructorTestUnknowLastWalkDate()
        {
            // Act
            Dog dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", null);

            //Assert
            Assert.AreEqual("Test", dog.Name);
            Assert.AreEqual(1, dog.ChipRegistrationNumber);
            Assert.AreEqual(false, dog.IsReserved);
            Assert.AreEqual(null, dog.LastWalkDate);
        }

        [TestMethod]
        public void TestPriceInterFaceHigherThen50000()
        {
            // arrange
            Dog dog;
            decimal expected = 350;

            // set
            dog = new Dog(90000, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, dog.Price);
        }

        [TestMethod]
        public void TestPriceInterFaceDogLowerThen50000()
        {
            // arrange
            Dog dog;
            decimal expected = 200;

            // set
            dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, dog.Price);
        }

        [TestMethod]
        public void TostringMethodDog()
        {
            // arrange
            Dog dog;
            string expected = "1, 01-03-1999, Test, not reserved, 02-08-2001";

            // set
            dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, dog.ToString());
        }

        [TestMethod]
        public void TostringMethodLastWalkUnknown()
        {
            // arrange
            Dog dog;
            string expected = "1, 01-03-1999, Test, not reserved, Unknown";

            // set
            dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", null);

            //Assert
            Assert.AreEqual(expected, dog.ToString());
        }
    }
}
