using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week_4__opdracht_4;

namespace Testing
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // arrange 
            int expectedStudentnummer = 1;
            string expectedStudentnaam = "Jeffrey";
            string expectedAddres = "Landgraaf";
            string expectedGeboortedatum = "02 - 08 - 1999";

            // act
            Student test = new Student(1, "Jeffrey", "Landgraaf", "02 - 08 - 1999");

            // assert
            Assert.AreEqual(expectedStudentnummer, test.Studentenummer);
            Assert.AreEqual(expectedStudentnaam, test.Studentennaam);
            Assert.AreEqual(expectedAddres, test.Address);
            Assert.AreEqual(expectedGeboortedatum, test.Geboortedatum);
        }

        [TestMethod]
        public void NaamChangeTest()
        {
            // arrange 
            string expectedNaam = "Lennart";
            Student test = new Student(1, "Jeffrey", "Landgraaf", "02 - 08 - 1999");

            // act
            test.NameChange("Lennart");

            // assert
            Assert.AreEqual(expectedNaam, test.Studentennaam);
        }

        [TestMethod]
        public void AdresChangeTest()
        {
            // arrange 
            string expectedAdres = "Den Bosch";
            Student test = new Student(1, "Jeffrey", "Landgraaf", "02 - 08 - 1999");

            // act
            test.adressChange("Den Bosch");

            // assert
            Assert.AreEqual(expectedAdres, test.Address);
        }

        [TestMethod]
        public void HoogsteCijferOpgvragen()
        {
            // arrange 
            int expectedCijfer = 10;            
            Student test = new Student(1, "Jeffrey", "Landgraaf", "02 - 08 - 1999");
            test.Addcijfer(new Vak(1, "vakTest", 10), 10);
            test.Addcijfer(new Vak(1, "vakTest", 10), 1);

            // act
            int cijfer = test.Hoogstecijfer();

            // assert
            Assert.AreEqual(expectedCijfer, cijfer);
        }

    }
}
