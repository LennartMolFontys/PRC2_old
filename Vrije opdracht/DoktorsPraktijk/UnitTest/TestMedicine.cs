using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class TestMedicine
    {
        private Medicine medicine;

        [TestInitialize]
        public void Initialize()
        {
            medicine = new Medicine(10, new SimpleDate(20, 8, 2019), "Paracetamol", 500);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(10, medicine.Days);
            Assert.AreEqual("20-08-2019", medicine.StartDate.ToString());
            Assert.AreEqual("Paracetamol", medicine.TreatmentName);
            Assert.AreEqual(500, medicine.Dosage);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentyDaysLowerThenZeroAndDosage0()
        {
            Medicine test = new Medicine(-1, new SimpleDate(2, 8, 1999), "NeusSpray", 0);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StartDateNULLTreamentEmpty()
        {
            Medicine test = new Medicine(1, null, "", 200);
        }

        [TestMethod]
        public void TestString()
        {
            string expexted = "Paracetamol, Number of days: 10, 20-08-2019, Dosage: 500 Price: 12,50";
            Assert.AreEqual(expexted, medicine.ToString());
        }

        [TestMethod]
        public void InterfacePriceCheck()
        {
            Assert.AreEqual(12.50m, medicine.Price);
        }
    }
}
