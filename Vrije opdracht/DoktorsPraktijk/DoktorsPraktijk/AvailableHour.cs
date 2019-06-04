using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    public class AvailableHour : IComparable<AvailableHour>
    {
        private DateTime date;
        public bool Taken { get; private set; }
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public AvailableHour(int day, int month, int year, int hours, int minutes)
        {
            date = new DateTime(year, month, day, hours,minutes, 00);
            Day = day;
            Month = month;
            Year = year;
            Hours = hours;
            Minutes = minutes;
            Taken = false;
        }

        public override string ToString()
        {
            return date.ToString("dd/MM/yyyy  HH:mm:ss");
        }

        public void SetTaken()
        {
            Taken = true;
        }

        public int CompareTo(AvailableHour hour)
        {
            if(hour== null)
            {
                return -1;
            }
            else
            {
                return date.CompareTo(hour.date);
            }
        }
    }
}
