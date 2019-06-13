using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoktorsPraktijk;

namespace UnitTest
{ 
    [TestClass]
    public class AdministrationTest
    {
        private Administration administration;
        private Doctor doctor;
        private Patient patient;
        private AvailableHour available;

        private string TestPatientsFile;
        private string TestDoctersFile;
        private string TestAppointmentsFile;

        [TestInitialize]
        public void init()
        {
            administration = new Administration();
            doctor = new Doctor("Jeffrey", "Pieters", new SimpleDate(2, 8, 1999));
            patient = new Patient("test", "Patient", new SimpleDate(8, 5, 1980));
            available = new AvailableHour(8, 9, 2019, 8, 30);
            TestPatientsFile = @"..\..\..\TestPatients.txt";
            TestDoctersFile = @"..\..\..\TestDoctors.txt";
            TestAppointmentsFile = @"..\..\..\TestAppointments.txt";
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(0,administration.Appointments.Count);
            Assert.AreEqual(0, administration.Doctors.Count);
            Assert.AreEqual(0, administration.Patients.Count);
        }

        [TestMethod]
        public void AddPatientsucces()
        {
           bool check = administration.AddPatient(patient);

            CollectionAssert.Contains(administration.Patients, patient);
            Assert.AreEqual(1, administration.Patients.Count);
            Assert.AreEqual("test", administration.Patients[0].FirstName);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void AddPatientFail()
        {
            bool check = administration.AddPatient(null);

            CollectionAssert.DoesNotContain(administration.Patients, patient);
            Assert.AreEqual(0, administration.Patients.Count);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void RemovePatientSucces()
        {
            administration.AddPatient(patient);

            bool check = administration.RemovePatient(patient);

            CollectionAssert.DoesNotContain(administration.Patients, patient);
            Assert.AreEqual(0, administration.Patients.Count);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void DoctorAddSuccer()
        {
            bool check = administration.AddDoctor(doctor);

            CollectionAssert.Contains(administration.Doctors, doctor);
            Assert.AreEqual(1, administration.Doctors.Count);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void DoctorAddFail()
        {
          bool check = administration.AddDoctor(null);

            CollectionAssert.DoesNotContain(administration.Doctors, doctor);
            Assert.AreEqual(0, administration.Doctors.Count);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void AddAppointSucces()
        {
            administration.AddDoctor(doctor);
            administration.AddPatient(patient);
            administration.Doctors[0].Add(available);

            bool check = administration.AddAppointMent(administration.Patients[0], administration.Doctors[0], doctor.AvailableHours[0]);

            Assert.AreEqual(true, check);
            Assert.AreEqual(1, administration.Appointments.Count);
            Assert.AreEqual("test", administration.Appointments[0].Patient.FirstName);
            Assert.AreEqual("Jeffrey", administration.Appointments[0].Docter.FirstName);
        }

        [TestMethod]
        public void AddAppointNotSucces()
        {
            administration.AddDoctor(doctor);
            administration.Doctors[0].Add(available);
            administration.AddAppointMent(patient, doctor, available);
           
            bool check = administration.AddAppointMent(patient, doctor, doctor.AvailableHours[0]);

           
            Assert.AreEqual(false, check);
            Assert.AreEqual(1, administration.Appointments.Count);
        }

        [TestMethod]
        public void AddAppointNotSuccesNULLInput()
        {
            bool check = administration.AddAppointMent(null,null,null);

            Assert.AreEqual(0, administration.Appointments.Count);
            Assert.AreEqual(false, check); 
        }

        [TestMethod]
        public void RemoveAppointmentSucces()
        {
            administration.AddAppointMent(patient,doctor,available);

            bool check = administration.RemoveAppointment(new Appointment(doctor, patient, available));

            CollectionAssert.DoesNotContain(administration.Appointments, new Appointment(doctor, patient, available));
            Assert.AreEqual(0, administration.Appointments.Count);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void RemoveAppointMentFail()
        {
            bool check = administration.RemoveAppointment(null);

            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void findAppointMentsucces()
        {
            administration.AddDoctor(doctor);
            administration.AddPatient(patient);
            administration.Doctors[0].Add(available);
            administration.AddAppointMent(administration.Patients[0], administration.Doctors[0], doctor.AvailableHours[0]);
            string expected = "08-09-2019  08:30:00,  Dr Pieters, Patient : Patient, test";

            Appointment find = administration.FindAppointment(patient);

            Assert.AreEqual(expected, find.ToString());
        }

        [TestMethod]
        public void exportPatientSucces()
        {
            bool check = administration.ExportPatient(TestPatientsFile);

            Assert.AreEqual(true, check);
        }
        [TestMethod]
        public void ExportPatientFail()
        {
            bool check = administration.ExportPatient("");
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportPatientFailNULL()
        {;
            bool check = administration.ExportPatient(null);

            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportDocters()
        {
            bool check = administration.ExportDoctors(TestDoctersFile);

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void ExportDoctersFail()
        {
            bool check = administration.ExportDoctors("");
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportDoctersFailNULL()
        {
            bool check = administration.ExportDoctors(null);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void ExportAppointMentsSucces()
        {

            bool check = administration.ExportAppointments(TestAppointmentsFile);

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void ExportAppointmentsFail()
        {
            bool check = administration.ExportAppointments("");

            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void exportappointmentsFailNull()
        {
            bool check = administration.ExportAppointments(null);

            Assert.AreEqual(false, check);
        }
        
    }
}
