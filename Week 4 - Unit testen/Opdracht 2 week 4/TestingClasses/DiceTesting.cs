using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht_2_week_4;

namespace TestingClasses
{
    [TestClass]
    public class DiceTesting
    {
        [TestMethod]
        public void TestingStandardDiceConstructor()
        {
            // arrange 
            int Sides = 6;

            // act  
            Dice test = new Dice();

            // assert  
            Assert.AreEqual(Sides, test.Sides);
        }

        [TestMethod]
        public void TestingCustomDiceConstructor()
        {
            // arrange 
            int Sides = 9;

            // act  
            Dice test = new Dice(Sides);

            // assert  
            Assert.AreEqual(Sides, test.Sides);
        }

        [TestMethod]
        public void TestingThrowResult()
        {
            // arrange 
            double expectedResult = 4.5;
            Dice test = new Dice(8);

            // act  
            int result = test.Thrown();

            // assert  
            Assert.AreEqual(expectedResult, result, 3.5);
        }

        [TestMethod]
        public void TestingSizeOfList()
        {
            // arrange
            int expectedSize = 1;
            Dice test = new Dice();

            // act  
            test.Thrown();

            // assert 
            Assert.AreEqual(expectedSize, test.Ogen.Count);
        }

        [TestMethod]
        public void TestingClearList()
        {
            // arrange
            int expectedSize = 0;
            Dice test = new Dice();
            test.Thrown();

            // act  
            test.ResetStatistics();

            // assert 
            Assert.AreEqual(expectedSize, test.Ogen.Count);
        }
    }
}
