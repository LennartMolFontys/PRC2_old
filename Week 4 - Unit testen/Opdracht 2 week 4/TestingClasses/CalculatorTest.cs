using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht_2_week_4;

namespace TestingClasses
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ConstructorInitTest()
        {
            // arrange 
            double result = 0;

            // act  
            Calculator test = new Calculator();

            // assert  
            Assert.AreEqual(result, test.result);
        }

        [TestMethod]
        public void TestAdd()
        {
            // arrange 
            double Add = 2;
            Calculator test = new Calculator();

            // act  
            test.Add(Add);

            // assert  
            Assert.AreEqual(Add, test.result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            // arrange 
            double Add = 2;
            double subtract = 1;
            Calculator test = new Calculator(); // Oprotten met die camera!
            test.Add(Add);

            // act  
            test.Subtract(subtract);

            // assert  
            Assert.AreEqual(2-1, test.result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            // arrange
            double add = 2;
            double multiplyer = 2;
            Calculator test = new Calculator();
            test.Add(add);

            // act
            test.Multiply(multiplyer);

            // assert
            Assert.AreEqual(2 * 2, test.result);
        }

        [TestMethod]
        public void TestDevide()
        {
            // arrange
            double add = 2;
            double Devide = 2;
            Calculator test = new Calculator();
            test.Add(add);

            // act
            test.Divide(Devide);

            // assert
            Assert.AreEqual(2 / 2, test.result);
        }


        [TestMethod]
        public void TestRest()
        {
            // arrange
            double add = 2;
            Calculator test = new Calculator();
            test.Add(add);

            // act
            test.clear();

            // assert
            Assert.AreEqual(0, test.result);
        }

        
    }
}
