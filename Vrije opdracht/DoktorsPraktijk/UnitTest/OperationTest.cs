using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class OperationTest
    {
        private Operation operation;

        [TestInitialize]
        public void Initialize()
        {
            operation = new Operation(1, new SimpleDate(10, 04, 2019), "Gescheurde Miniscus", 14);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(1, operation.Days);
            Assert.AreEqual("10-04-2019", operation.StartDate.ToString());
            Assert.AreEqual("Gescheurde Miniscus", operation.TreatmentName);
            Assert.AreEqual(14, operation.RecoveryTime);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorEmptyString()
        {
            Operation test = new Operation(1, new SimpleDate(2, 8, 1999), "", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorNUllinput()
        {
            Operation test = new Operation(1, null, null, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorLessThenZero()
        {
            Operation test = new Operation(-1, new SimpleDate(2, 8, 1999), "Gescheurde Knieband", -1);
        }

        [TestMethod]
        public void TostringTest()
        {
            string expexted = "Gescheurde Miniscus, Number of days: 1, 10-04-2019, Recovery Time: 14 Price: 430";

            Assert.AreEqual(expexted, operation.ToString());
        }

        [TestMethod]
        public void InterfacePriceCheck()
        {
            Assert.AreEqual(430, operation.Price);
        }
    }
}
