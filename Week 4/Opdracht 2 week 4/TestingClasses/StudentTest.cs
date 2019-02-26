using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht_2_week_4;

namespace TestingClasses
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestConstructorWithCorrectValue()
        {
            // arrange  
            string expectedname = "Lennart";
            string expectedAdress = "Den Bosch";

            // act  
            Student test = new Student("Lennart", "Den Bosch");

            // assert  
            Assert.AreEqual(expectedname, test.Name);
            Assert.AreEqual(expectedAdress, test.Adress);
        }

        [TestMethod]
        public void TestConstructorWithIncorrectValue()
        {
            // arrange  
            string expectedname = "Onbekend";
            string expectedAdress = "Onbekend";

            // act  
            Student test = new Student("","");

            // assert  
            Assert.AreEqual(expectedname, test.Name);
            Assert.AreEqual(expectedAdress, test.Adress);
        }
    }
}
