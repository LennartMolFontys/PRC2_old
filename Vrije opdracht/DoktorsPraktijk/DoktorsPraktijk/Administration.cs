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
        public Administration() { Patients = new List<Patient>(); }

        public void AddPatient(string FirstName, string LastName, SimpleDate birthDay)
        {
            if(!string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName) || birthDay != null)
            {
                Patient Patient = new Patient(FirstName, LastName, birthDay);
                Patients.Add(Patient);
            }
        }

        public void RemovePatient(string FirstName)
        {
            if (!string.IsNullOrEmpty(FirstName))
            {
                for (int i = 0; i < Patients.Count; i++)
                {
                    if (Patients[i].FirstName == FirstName)
                    {
                        Patients.Remove(Patients[i]);
                    }
                }
            }
        }


    }
}
