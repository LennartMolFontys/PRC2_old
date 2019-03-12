using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week_4__opdracht_4;

namespace Testing
{
    [TestClass]
    public class TestVak
    {
        [TestMethod]
        public void ConstructorTest()
        {
           // arrange
           int vakcode = 1;
           string vaknaam = "Test";
            int bsu = 1;

            // act
            Vak test = new Vak(vakcode, vaknaam, bsu);

            // assert
            Assert.AreEqual(vaknaam, test.Vaknaam);
        }
        [TestMethod]
        public void TestResultaat()
        {
            // arrange
            int vakcode = 1;
            string vaknaam = "Test";
            int bsu = 1;
            int result = 9;
            Vak test = new Vak(vakcode, vaknaam, bsu);

            // act
            test.Resultaat(test, result);

            // assert
            Assert.AreEqual(result, Convert.ToInt32(test.resultaten));
        }
    }
}
