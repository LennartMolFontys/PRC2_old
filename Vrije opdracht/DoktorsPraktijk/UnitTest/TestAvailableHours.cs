using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class TestAvailableHours
    {
        private AvailableHour test;
        [TestInitialize]
        public void init()
        {
            test = new AvailableHour(1, 2, 2019, 5, 30);
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(1, test.Day);
            Assert.AreEqual(2, test.Month);
            Assert.AreEqual(2019, test.Year);
            Assert.AreEqual(5, test.Hours);
            Assert.AreEqual(30, test.Minutes);
            Assert.AreEqual(false, test.Taken);
        }

        [TestMethod]
        public void TestTostring()
        {
            string expected = "01-02-2019  05:30:00";
            Assert.AreEqual(expected, test.ToString());
        }

        [TestMethod]
        public void TestSetTaken()
        {
            test.SetTaken();
            Assert.AreEqual(true, test.Taken);
        }
    }
}
