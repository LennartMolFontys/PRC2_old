using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    [Serializable]
    public class Patient :IComparable<Patient>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public SimpleDate BirthDay { get; private set; }
        public Appointment Appointment { get; private set; }

        public List<Treatment> Treatments { get; private set; }

        public Patient(string firstName, string lastName, SimpleDate birthDay)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentException("Firstname can't be null or empty", nameof(firstName));
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentException("Lastname can't be null or empty", nameof(lastName));
            if(birthDay == null) throw new ArgumentException("BirthDay can't be NULL");

            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Treatments = new List<Treatment>();
        }

       public bool Add(Treatment treatment)
       {
           if(treatment != null)
           {
               Treatments.Add(treatment);
               return true;
           }
           return false;
       }

       public bool Remove(string TreatmentName)
       {
            if (TreatmentName != null || !string.IsNullOrEmpty(TreatmentName))
            {
              for(int i = 0; i < Treatments.Count; i++)
              {
                  if(Treatments[i].TreatmentName == TreatmentName)
                  {
                        Treatments.Remove(Treatments[i]);
                        return true;
                  }
              }
            }
            return false;
       }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

        public void Addappointment(Appointment appointment)
        {
            if(appointment !=null)
            {
                Appointment = appointment;
            }
        }

        public void RemoveAppointment()
        {
            Appointment = null;
        }


        public int CompareTo(Patient patient)
        {
            if(patient == null)
            {
                return -1;
            }
            else
            {
                return LastName.CompareTo(patient.LastName);
            }
        }

    }
}
