using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class FileHandlerTest
    {
        private FileHandler file;
        private List<Patient> patients;
        private List<Doctor> doctors;
        private List<Appointment> appointments;

        private string TestPatientsFile;
        private string TestDoctersFile;
        private string TestAppointmentsFile;

        [TestInitialize]
        public void init()
        {
            file = new FileHandler();
            patients = new List<Patient>();
            doctors = new List<Doctor>();
            appointments = new List<Appointment>();
            TestPatientsFile = @"..\..\..\TestPatients.txt";
            TestDoctersFile = @"..\..\..\TestDoctors.txt";
            TestAppointmentsFile = @"..\..\..\TestAppointments.txt";
        }

        [TestMethod]
        public void ExportPatientsTest()
        {
            bool check = file.ExportPatients(TestPatientsFile, patients);

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void ExportPatientsFail()
        {
            bool check = file.ExportPatients(null, null);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportDocterSucces()
        {
            bool check = file.ExportDokter(TestDoctersFile,doctors);

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void ExportdoctersFail()
        {
            bool check = file.ExportDokter(null, null);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportAppointmentsSucces()
        {
            bool check = file.ExportAppointment(TestAppointmentsFile, appointments);

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void ExportAppointMentsFail()
        {
            bool check = file.ExportAppointment(null, null);

            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void LoadPatientsSucces()
        {

            List<Patient> check = file.LoadPatients(TestPatientsFile);

            Assert.AreEqual(0, check.Count);
        }

        [TestMethod]
        public void LoadPatientsFail()
        {
            List<Patient> check = file.LoadPatients(null);

            Assert.AreEqual(null, check);
        }

        [TestMethod]
        public void LoadDoctersSucces()
        {
            List<Doctor> check = file.LoadDocter(TestDoctersFile);

            Assert.AreEqual(0, check.Count);
        }

        [TestMethod]
        public void LoadDoctersFail()
        {
            List<Doctor> check = file.LoadDocter(null);

            Assert.AreEqual(null, check);
        }

        [TestMethod]
        public void LoadAppointsMents()
        {
            List<Appointment> check = file.LoadAppointment(TestAppointmentsFile);

            Assert.AreEqual(0, check.Count);
        }

        [TestMethod]
        public void LoadAppointsMentsFail()
        {
            List<Appointment>check = file.LoadAppointment(null);

            Assert.AreEqual(null, check);
        }


    }
}
