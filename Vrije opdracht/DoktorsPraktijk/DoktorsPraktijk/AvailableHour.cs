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
            if (day < 1) throw new ArgumentException("Number of days can't be Zero or lower then Zero", nameof(day));
            if (month < 1 || month > 12) throw new ArgumentException("Number of month has to between 1 and 12", nameof(month));
            if (year < DateTime.Now.Year) throw new ArgumentException($"Number of year can't be lower then : {DateTime.Now.Year}", nameof(year)); // $ <--interpolatie hiermee kan je waardes in de strin zetten zonder string format
            if (hours > 30 || hours < 1) throw new ArgumentException("Number of hours has to be between 1 and 24", nameof(hours));
            if (minutes > 60) throw new ArgumentException("Maximum of minutes is 60", nameof(minutes));

            Day = day;
            Month = month;
            Year = year;
            Hours = hours;
            Minutes = minutes;
            Taken = false;
            date = new DateTime(year, month, day, hours,minutes, 00);
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
