using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{
    [TestClass]
    public class TestDoctor
    {
        private Doctor dokter;
        private AvailableHour test;

        [TestInitialize]
        public void init()
        {
            dokter = new Doctor("Jeffrey", "Pieters", new SimpleDate(02, 08, 1999));
            test = new AvailableHour(2, 8, 2019, 13, 30);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual("Jeffrey", dokter.FirstName);
            Assert.AreEqual("Pieters", dokter.LastName);
            Assert.AreEqual("02-08-1999", dokter.BirthDay.ToString());
            Assert.AreEqual(0, dokter.AvailableHours.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorNUllInput()
        {
            Doctor test = new Doctor("Jeffrey", "Pieters", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorEmptyString()
        {
            Doctor test = new Doctor("", "", new SimpleDate(2, 8, 1999));
        }

        [TestMethod]
        public void AddSucces()
        {
   
            bool check = dokter.Add(test);

            CollectionAssert.Contains(dokter.AvailableHours, test);
            Assert.AreEqual(1, dokter.AvailableHours.Count);
            Assert.AreEqual("02-08-2019  13:30:00", dokter.AvailableHours[0].ToString());
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void AddNotSucces()
        {
            bool check = dokter.Add(null);

            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void SetTakenSucces()
        {
            AvailableHour setTaken = new AvailableHour(2, 8, 2019, 13, 30);
            dokter.Add(test);

            bool check = dokter.SetHourTaken(setTaken);

            Assert.AreEqual(true, dokter.AvailableHours[0].Taken);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void SetTakenFail()
        {
            AvailableHour test = new AvailableHour(2, 8, 2019, 13, 30);
            AvailableHour setTaken = new AvailableHour(3, 8, 2019, 13, 30);
            dokter.Add(test);

            bool check = dokter.SetHourTaken(setTaken);

            Assert.AreEqual(false, dokter.AvailableHours[0].Taken);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void SetTakenNullInput()
        {
            dokter.Add(test);

            bool check = dokter.SetHourTaken(null);

            Assert.AreEqual(false, dokter.AvailableHours[0].Taken);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void SortListTest()
        {
            AvailableHour test1 = new AvailableHour(12, 12, 2018, 15, 00);
            AvailableHour test2 = new AvailableHour(10, 12, 2019, 15, 00);
            AvailableHour test3 = new AvailableHour(2, 8, 2019, 12, 00);
            dokter.Add(test2);
            dokter.Add(test1);
            dokter.Add(test3);
            dokter.Add(test);

            dokter.SortList();

            Assert.AreEqual(test1.ToString(), dokter.AvailableHours[0].ToString());
            Assert.AreEqual(test3.ToString(), dokter.AvailableHours[1].ToString());
            Assert.AreEqual(test.ToString(), dokter.AvailableHours[2].ToString());
            Assert.AreEqual(test2.ToString(), dokter.AvailableHours[3].ToString());

        }
    }
}
