﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    [Serializable]
    public class Doctor :IComparable<Doctor>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public SimpleDate BirthDay { get; private set; }
        public List<AvailableHour> AvailableHours { get; private set; }

        public Doctor(string firstName, string lastName, SimpleDate birthDay)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentException("FirstName can't be null or empty", nameof(firstName));
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentException("LastName can't be null or empty", nameof(lastName));
            if (birthDay == null)  throw new ArgumentException("Birthday can't be null", nameof(birthDay));

            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            AvailableHours = new List<AvailableHour>();
            
        }

        public bool Add(AvailableHour hour)
        {
            if (hour != null)
            {
                AvailableHours.Add(hour);
                SortavailableHours();
                return true;
            }
            return false;
        }

        public bool SetHourTaken(AvailableHour hour)
        {
            if (hour !=null)
            {
                foreach (AvailableHour s in AvailableHours)
                {
                    if (s.ToString() == hour.ToString() && s.Taken == false)
                    {
                        s.SetTaken();
                        return true;
                    }
                }
            }
            return false;
        }

        public bool SetHourUnTaken(AvailableHour hour)
        {
            if (hour != null)
            {
                foreach (AvailableHour s in AvailableHours)
                {
                    if (s.ToString() == hour.ToString() && s.Taken == true)
                    {
                        s.SetNotTaken();
                        return true;
                    }
                }
            }
            return false;
        }

        public void SortavailableHours()
        {
            AvailableHours.Sort();
        }

        public int CompareTo(Doctor doctor)
        {
            if(doctor == null)
            {
                return -1;
            }
            else
            {
                return LastName.CompareTo(doctor.LastName);
            }
        }

        public override string ToString()
        {
            return $"Dr {LastName}";
        }
    }
}
