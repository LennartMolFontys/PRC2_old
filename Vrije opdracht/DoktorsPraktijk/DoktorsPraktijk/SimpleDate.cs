using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    [Serializable]
   public class SimpleDate : IComparable<SimpleDate>
   {
        public DateTime date { get; private set; }
        public int Day { get { return date.Day; } }
        public int Month { get { return date.Month; } }
        public int Year { get { return date.Year; } }

        public SimpleDate(int Day, int Month, int Year)
        {
            if (Day <= 0) throw new ArgumentException("Days can't be Zero or lower then Zero");
            if (Month <= 0 || Month > 12) throw new ArgumentException("Month must be between 1 and - 12");
            if (Year <= 0) throw new ArgumentException("Year can't be lower then 0");

            date = new DateTime(Year, Month, Day);
        }

        public override string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }

        public int CompareTo(SimpleDate date)
        {
            if(date == null)
            {
                return -1;
            }
            else
            {
                return Year.CompareTo(date.Year);
            }
        }     
   }
}
