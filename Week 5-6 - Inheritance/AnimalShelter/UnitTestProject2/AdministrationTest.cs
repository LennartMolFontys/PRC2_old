using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject2
{
    [TestClass]
    public class AdministrationTest
    {
        [TestMethod]
        public void AdministrationConstructor()
        {
            // arrange
            Administration admin;

            // set

            admin = new Administration();

            //Assert
            Assert.AreEqual(0, admin.animals.Count);
        }

        [TestMethod]
        public void AddMethode()
        {
            //arrange
            Administration admin = new Administration();

            //set 
            bool test = admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            // assert
            Assert.AreEqual(true, test);
        }

       [TestMethod]
       public void TestListRaised()
       {
          //arrange
          Administration admin = new Administration();

          //set 
          admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

          // assert
          Assert.AreEqual(1, admin.animals.Count);
       }

        [TestMethod]
        public void AddMethodeFalse()
        {
            //arrange
            Administration admin = new Administration();
            bool test = admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
            test = admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            // assert
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestListNotRaised()
        {
            //arrange
            Administration admin = new Administration();
            bool test = admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
             admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            // assert
            Assert.AreEqual(1, admin.animals.Count);
        }

        [TestMethod]
        public void RemoveAnimal()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
            bool test = admin.RemoveAnimal(1);

            // assert
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void CheckIfRemoved()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
            admin.RemoveAnimal(1);

            // assert
            Assert.AreEqual(1, admin.animals.Count);
        }

        [TestMethod]
        public void RemoveAnimalFalse()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
            bool test = admin.RemoveAnimal(3);

            // assert
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void CheckAnimalNotRemoved()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //set 
            bool test = admin.RemoveAnimal(3);

            // assert
            Assert.AreEqual(2, admin.animals.Count);
        }


        [TestMethod]
        public void FindAnimal()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //set 
            Animal animal = admin.FindAnimal(2);

            // assert
            Assert.AreEqual(admin.animals[1], animal);
        }

        [TestMethod]
        public void NotFound()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //set 
            Animal animal = admin.FindAnimal(3);

            // assert
            Assert.AreEqual(null, animal);
        }

        [TestMethod]
        public void TestifListSorted()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(new Dog(9, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(5, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(7, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(3, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //set 
            admin.SortList();

            // assert
            Assert.AreEqual(1, admin.animals[0].ChipRegistrationNumber);
        }
    }
}
