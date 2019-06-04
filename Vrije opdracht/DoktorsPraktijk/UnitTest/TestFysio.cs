using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
 
    [TestClass]
    public class TestFysio
    {
        private Fysio fysio;

        [TestInitialize]
        public void Initialize()
        {
            fysio = new Fysio(10, new SimpleDate(10, 03, 2019), "Verrekte Hamstring");
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual("Verrekte Hamstring", fysio.TreatmentName);
            Assert.AreEqual(10, fysio.Days);
            Assert.AreEqual("10-03-2019", fysio.StartDate.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorLessThenZero()
        {
            Fysio test = new Fysio(0, new SimpleDate(2, 8, 1999), "Verrekte Hamstring");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConStructorNullInput()
        {
            Fysio test = new Fysio(12, null, "Verrekte Hamstring");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstrucutorEmptyString()
        {
            Fysio test = new Fysio(12, new SimpleDate(2, 8, 1999), "");
        }

        [TestMethod]
        public void TostringTest()
        {
            string expexted = "Verrekte Hamstring" + ", "+ "Number of days: 10" + ", " + "10-03-2019" + " Price: 300";

            Assert.AreEqual(expexted, fysio.ToString());
        }

        [TestMethod]
        public void InterFacePriceCheck()
        {
            Assert.AreEqual(300, fysio.Price);
        }
    }
}
