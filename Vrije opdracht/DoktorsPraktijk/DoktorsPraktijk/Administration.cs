using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    public class Administration
    {
        public List<Patient> Patients { get; private set; }
        public List<Doctor> Doctors { get; private set; }
        public List<Appointment> Appointments { get; private set; }
        public Administration()
        {
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
        }

        public bool AddPatient(Patient patient)
        {
            if(patient != null)
            {
                Patients.Add(patient);
                return true;
            }
            return false;
        }

        public bool RemovePatient(Patient patient)
        {
            if (patient != null)
            {
                foreach(Patient s in Patients)
                {
                    if(s.FirstName == patient.FirstName && patient.LastName == s.LastName && patient.BirthDay == s.BirthDay)
                    {
                        Patients.Remove(s);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddDoctor(Doctor doctor)
        {
            if(doctor !=null)
            {
                Doctors.Add(doctor);
                return true;
            }
            return false;
        }

        public bool RemoveDoctor(Doctor doctor)
        {
            if(doctor != null)
            {
                foreach(Doctor s in Doctors)
                {
                    if(s.FirstName == doctor.FirstName && s.LastName == doctor.LastName && s.BirthDay == doctor.BirthDay)
                    {
                        Doctors.Remove(s);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddAppointMent(Patient patient, Doctor doctor, AvailableHour date)
        {
            if(patient !=null && doctor != null && date != null)
            {
                bool Available = CheckIfAvailable(doctor, date);
                if(Available)
                {
                    Appointment appointment = new Appointment(doctor, patient, date);
                    Appointments.Add(appointment);
                    return true;
                }

            }
            return false;
        }

        private bool CheckIfAvailable(Doctor doctor, AvailableHour date)
        {
            if(doctor != null && date != null)
            {
                foreach(AvailableHour s in doctor.AvailableHours)
                {
                    if(date.ToString() == s.ToString() && s.Taken == false)
                    {
                        s.SetTaken();
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
