using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class TestPatient
    {
        private Patient patient;
        private Treatment fysio;
        private Treatment Operation;
        private Treatment medicine;

        [TestInitialize]
        public void Initialize()
        {
            patient = new Patient("Test", "Patient", new SimpleDate(2, 8, 1999));
            fysio = new Fysio(10, new SimpleDate(10, 3, 2019), "Verrekte Hamstring");
            Operation = new Operation(10, new SimpleDate(10, 4, 2019), "Gescheurde Miniscus", 14);
            medicine = new Medicine(15, new SimpleDate(11,8, 2019), "Paracetamol", 500);
        }

        [TestMethod]
        public void ConstructorTestInput()
        {          
            Assert.AreEqual("Test", patient.FirstName);
            Assert.AreEqual("Patient", patient.LastName);
            Assert.AreEqual("02-08-1999", patient.BirthDay.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorEmptyFirstName()
        {
            Patient test = new Patient("", "Hallo", new SimpleDate(02, 08, 1999));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorEmptyLastName()
        {
            Patient test = new Patient("Jeffrey","", new SimpleDate(02, 08, 1999));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorEmptyDate()
        {
            Patient test = new Patient("Jeffrey", "Pieters", null);
        }

        [TestMethod]
        public void TostringTest()
        {
            Assert.AreEqual("Patient, Test", patient.ToString());
        }

        [TestMethod]
        public void AddTreatmentTestCorrect()
        {
           bool check1 = patient.Add(fysio);
           bool check2 = patient.Add(Operation);
           bool check3 = patient.Add(medicine);

            CollectionAssert.Contains(patient.Treatments, fysio);
            CollectionAssert.Contains(patient.Treatments, Operation);
            CollectionAssert.Contains(patient.Treatments, medicine);
            CollectionAssert.AllItemsAreNotNull(patient.Treatments);

            Assert.AreEqual(3, patient.Treatments.Count);
            Assert.AreEqual("Verrekte Hamstring", patient.Treatments[0].TreatmentName);
            Assert.AreEqual("Gescheurde Miniscus", patient.Treatments[1].TreatmentName);
            Assert.AreEqual("Paracetamol", patient.Treatments[2].TreatmentName);

            Assert.AreEqual(true, check1);
            Assert.AreEqual(true, check2);
            Assert.AreEqual(true, check3);
        }

        [TestMethod]
        public void AddTreatmentTestIncorrect()
        {
            bool check = patient.Add(null);

            Assert.AreEqual(0, patient.Treatments.Count);
            Assert.AreEqual(false, check);
            CollectionAssert.AllItemsAreNotNull(patient.Treatments);
        }

        [TestMethod]
        public void TestRemoveSucces()
        {
            patient.Add(fysio);
            patient.Add(Operation);
            patient.Add(medicine);

           bool check = patient.Remove("Verrekte Hamstring");

            CollectionAssert.DoesNotContain(patient.Treatments, fysio);
            Assert.AreEqual(2, patient.Treatments.Count);
            Assert.AreEqual("Gescheurde Miniscus", patient.Treatments[0].TreatmentName);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestRemoveIncorrect()
        {
            patient.Add(fysio);
            patient.Add(medicine);
            patient.Add(Operation);

           bool check = patient.Remove("");

            Assert.AreEqual(3, patient.Treatments.Count);
            Assert.AreEqual(false, check);

        }

        [TestMethod]
        public void TestRemoveNotFound()
        {
            patient.Add(fysio);
            patient.Add(Operation);
            patient.Add(medicine);

            bool check = patient.Remove("Oorspray");

            Assert.AreEqual(3, patient.Treatments.Count);
            Assert.AreEqual(false, check);
        }

    }
}
