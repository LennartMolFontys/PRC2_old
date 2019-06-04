using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    public class Doctor
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public SimpleDate BirthDay { get; private set; }
        public List<AvailableHours> AvailableHours { get; private set; }

        public Doctor(string firstName, string lastName, SimpleDate birthDay)
        {
            if(!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName) || birthDay != null)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthDay = birthDay;
            }
            else
            {
                throw new ArgumentException("One of the input Values is Empty");
            }

        }

        public void Add(string day, int hour, int minutes)
        {
            AvailableHours.Add(new AvailableHours());
        }


    }
}
