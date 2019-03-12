using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week_4__opdracht_4;

namespace Testing
{
    [TestClass]
    public class TestResultaat
    {
        [TestMethod]
        public void TestConstructor()
        {
            // arrange
            int cijfer = 8;
            Vak test = new Vak(1, "Test", 2);

            // act
            Resultaat testing = new Resultaat(test, cijfer);

            // assert
            Assert.AreEqual(cijfer, testing.Cijfer);
        }

        public void TestOverRide()
        {
            // arrange
            int cijfer = 8;
            Vak test = new Vak(1, "Test", 2);

            // act
            Resultaat testing = new Resultaat(test, cijfer);

            // assert
            Assert.AreEqual("Test", testing.ToString());

        }
    }
}
