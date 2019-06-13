using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class SimpleDateTest
    {
        private SimpleDate test;

        [TestInitialize]
        public void init()
        {
            test = new SimpleDate(2, 8, 1999);
        }

        [TestMethod]
        public void ConstructorTestSucces()
        {
            Assert.AreEqual(2, test.Day);
            Assert.AreEqual(8, test.Month);
            Assert.AreEqual(1999, test.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void constructorFail()
        {
            SimpleDate fail = new SimpleDate(-1, 8, 1999);
            SimpleDate fail2 = new SimpleDate(1, 0, 1999);
            SimpleDate fail3 = new SimpleDate(0, 1, 1999);
            SimpleDate fail4 = new SimpleDate(0, 0, 0);
        }

        [TestMethod]
        public void TestStrinSucces()
        {
            Assert.AreEqual("02-08-1999", test.ToString());
        }

        [TestMethod]
        public void TestCompareSucces()
        {
            SimpleDate compare = new SimpleDate(12, 8, 2000);

            int i = test.CompareTo(compare);

            Assert.AreEqual(-1, i);
        }

        [TestMethod]
        public void TestcompareFail()
        {
            int i = test.CompareTo(null);
            Assert.AreEqual(-1, i);
          
        }


    }
}
