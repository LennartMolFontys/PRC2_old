using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestAppointment
    {
        private Doctor doctor;
        private Patient patient;
        private AvailableHour available;
        private Appointment appointment;

        [TestInitialize]
        public void init()
        {
            doctor = new Doctor("Jeffrey", "Pieters", new SimpleDate(2, 8, 1999));
            patient = new Patient("test", "Patient", new SimpleDate(8, 5, 1980));
            available = new AvailableHour(8, 9, 2019, 8, 30);
            appointment = new Appointment(doctor, patient, available);
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual("Pieters", appointment.Docter.LastName);
            Assert.AreEqual("Patient", appointment.Patient.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFail()
        {
            appointment = new Appointment(null, null, null);
        }

        [TestMethod]
        public void TestString()
        {
            string expected = "08-09-2019  08:30:00,  Dr Pieters, Patient : Patient, test";
            Assert.AreEqual(expected, appointment.ToString());
        }
    }
}
