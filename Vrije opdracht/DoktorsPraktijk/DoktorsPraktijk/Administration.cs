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
        private FileHandler file;

        public Administration()
        {
            file = new FileHandler();
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
        }

        public bool AddPatient(Patient patient)
        {
            if(patient != null)
            {
                Patients.Add(patient);
                Patients.Sort();
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
                        Patients.Sort();
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
                Doctors.Sort();
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
                        Doctors.Sort();
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
                    patient.Addappointment(appointment);
                    Appointments.Add(appointment);
                    Appointments.Sort();
                    return true;
                }

            }
            return false;
        }

        public bool RemoveAppointment(Appointment appointment)
        {
            if(appointment != null)
            {
                for(int i = 0; i < Appointments.Count; i++)
                {
                    if(Appointments[i].ToString() == appointment.ToString())
                    {
                        Appointments.Remove(Appointments[i]);
                        appointment.Patient.RemoveAppointment();
                    }
                }
                return true;
            }
            return false;
        }

        public bool AddAvailableHours(Doctor doctor, AvailableHour availableHour)
        {
            if(doctor != null && availableHour != null)
            {
                doctor.Add(availableHour);
                doctor.AvailableHours.Sort();
                return true;
            }
            return false;
        }

        public bool RemoveAvailableHours(Doctor doctor ,AvailableHour available)
        {
            if(available !=null)
            {
                foreach(AvailableHour s in doctor.AvailableHours)
                {
                    if(s.ToString() == available.ToString())
                    {
                        doctor.AvailableHours.Remove(s);
                        return true;
                    }
                }
            }
            return true;
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

        public Appointment FindAppointment(Patient patient)
        {
            if(patient != null)
            {
                return patient.Appointment;
            }
            return null;
        }

        public bool ExportPatient(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                return file.ExportPatients(fileName, Patients);
            }
            return false;
        }

        public void LoadPatient(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                Patients = file.LoadPatients(fileName);
            }
        }

        public bool ExportDoctors(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                return file.ExportDokter(fileName, Doctors);
            }
            return false;
        }


        public void LoadDoctors(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                Doctors = file.LoadDocter(fileName);
            }
        }

        public bool ExportAppointments(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                return file.ExportAppointment(fileName, Appointments);
            }
            return false;
        }
        
        public void LoadAppointMents(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName))
            {
                Appointments = file.LoadAppointment(fileName);
            }
        }
    }
}
