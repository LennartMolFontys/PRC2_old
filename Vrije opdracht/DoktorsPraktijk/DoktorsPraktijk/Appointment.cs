using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    public class Appointment
    {
        public AvailableHour AppointmentDate { get; private set; }
        public Doctor Docter { get; private set; }
        public Patient Patient { get; private set; }

        public Appointment(Doctor docter, Patient patient, AvailableHour date)
        {
            if (docter == null) throw new ArgumentException("Docter can't be Null", nameof(docter));
            if (patient == null) throw new ArgumentException("Patient can't be Null", nameof(patient));
            if (date == null) throw new ArgumentException("Date can't be Null", nameof(date));

            Docter = docter;
            Patient = patient;
            AppointmentDate = date;
            AppointmentDate.SetTaken();
        }

        public override string ToString()
        {
            return $" {AppointmentDate.ToString()},  {Docter.ToString()}, Patient : {Patient.ToString()}";
        }

        public bool CancelAppointMent(Appointment appointment)
        {
            if (appointment != null)
            {
                AppointmentDate.SetNotTake();
                return true;
            }
            return false;
        }

        public void Sort(List<Appointment> appointments)
        {
            if(appointments != null)
            {
                appointments.Sort();
            }
        }
        
    }
}
