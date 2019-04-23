using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestProject2
{
    [TestClass]
    public class AdministrationTest
    {
        Administration admin;
        Dog dog;

        [TestInitialize]
        void Setup()
        {
            admin = new Administration();
            dog = new Dog(1, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000));
        }

        [TestMethod]
        public void AdministrationConstructor()
        {       
            //Assert
            Assert.AreEqual(0, admin.Animals.Count);
        }

        [TestMethod]
        public void Add_will_return_true_when_succesfull()
        {
          
            //set 
            bool test = admin.Add(dog);

            // assert
            Assert.AreEqual(true, test);
            CollectionAssert.AreEquivalent(new[] { dog }, admin.Animals);
            
        }

       [TestMethod]
       public void TestListRaised()
       {
         
          //act 
          admin.Add(dog);

          // assert
          Assert.AreEqual(1, admin.Animals.Count);
       }

        [TestMethod]
        public void AddMethodeFalse()
        {
            //arrange
            Administration admin = new Administration();
            bool test = admin.Add(dog);

            //set 
            test = admin.Add(dog);

            // assert
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestListNotRaised()
        {
            //arrange
            bool test = admin.Add(dog);

            //set 
             admin.Add(dog);

            // assert
            Assert.AreEqual(1, admin.Animals.Count);
        }

        [TestMethod]
        public void RemoveAnimal()
        {
            //arrange
            Administration admin = new Administration();
            admin.Add(dog);
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
            admin.Add(dog);
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //act 
            admin.RemoveAnimal(1);

            // assert
            Assert.AreEqual(1, admin.Animals.Count);
        }

        [TestMethod]
        public void RemoveAnimalFalse()
        {
            //arrange
            admin.Add(dog);
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //act 
            bool test = admin.RemoveAnimal(3);

            // assert
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void CheckAnimalNotRemoved()
        {
            //arrange
            admin.Add(dog);
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));

            //act 
            bool test = admin.RemoveAnimal(3);

            // assert
            Assert.AreEqual(2, admin.Animals.Count);
        }


        [TestMethod]
        public void FindAnimal()
        {
            //arrange
            admin.Add(dog);
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //act 
            Animal animal = admin.FindAnimal(2);

            // assert
            Assert.AreEqual(admin.Animals[1], animal);
        }

        [TestMethod]
        public void NotFound()
        {
            //arrange
            admin.Add(dog);
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //act 
            Animal animal = admin.FindAnimal(3);

            // assert
            Assert.AreEqual(null, animal);
        }

        [TestMethod]
        public void TestifListSorted()
        {
            //arrange
            admin.Add(new Dog(9, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(2, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(5, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(7, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(3, new SimpleDate(1, 3, 1999), "Test", new SimpleDate(1, 4, 2000)));
            admin.Add(new Dog(1, new SimpleDate(1, 3, 1999), "Test2", new SimpleDate(1, 4, 2000)));

            //act 
            admin.SortList();

            // assert
            Assert.AreEqual(1, admin.Animals[0].ChipRegistrationNumber);
        }
    }
}
