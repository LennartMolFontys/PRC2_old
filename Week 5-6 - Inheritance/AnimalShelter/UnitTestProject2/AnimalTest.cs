using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject2
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void ConstructorTestDog()
        {
            // arrange
            Animal animal;

            // set
            animal = new Dog(1,new SimpleDate(1,3,1999), "Test", new SimpleDate(2,8,2001));

            //Assert
            Assert.AreEqual("Test", animal.Name);
            Assert.AreEqual(1, animal.ChipRegistrationNumber);
            Assert.AreEqual(false, animal.IsReserved);
        }
        [TestMethod]
        public void ConstructorTestCat()
        {
            // arrange
            Animal animal;

            // set
            animal = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual("Tommy", animal.Name);
            Assert.AreEqual(2, animal.ChipRegistrationNumber);
            Assert.AreEqual(false, animal.IsReserved);
        }

        [TestMethod]
        public void TostringMethodDog()
        {
            // arrange
            Animal animal;
            string expected = "1, 01-03-1999, Test, not reserved, 02-08-2001";

            // set
            animal = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, animal.ToString());
        }

        [TestMethod]
        public void ToStringMethodCat()
        {
            // arrange
            Animal animal;
            string expected = "2, 01-08-1999, Tommy, not reserved, Scratching";

            // set
            animal = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual(expected, animal.ToString());
        }

        [TestMethod]
        public void TestPriceInterFaceDogLowerThen50000()
        {
            // arrange
            Animal animal;
            decimal expected = 200;

            // set
            animal = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, animal.Price);
        }

        [TestMethod]
        public void TestPriceInterFaceDogHigherThen50000()
        {
            // arrange
            Animal animal;
            decimal expected = 350;

            // set
            animal = new Dog(90000, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(2, 8, 2001));

            //Assert
            Assert.AreEqual(expected, animal.Price);
        }

        [TestMethod]
        public void TestPriceInterFaceCat()
        {
            // arrange
            Animal animal;
            decimal expected = 50;

            // set
            animal = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching");

            //Assert
            Assert.AreEqual(expected, animal.Price);
        }

        [TestMethod]
        public void TestPriceInterFaceCatLowerThen20()
        {
            // arrange
            Animal animal;
            decimal expected = 20;

            // set
            animal = new Cat(2, new SimpleDate(1, 8, 1999), "Tommy", "Scratching,Scratching,Scratching,Scratching,Scratching");

            //Assert
            Assert.AreEqual(expected, animal.Price);
        }

        
    }

    
}
