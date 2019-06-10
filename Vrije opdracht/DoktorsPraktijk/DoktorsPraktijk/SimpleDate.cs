using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
   public class SimpleDate : IComparable<SimpleDate>
   {
        public DateTime date { get; private set; }
        public int Day { get { return date.Day; } }
        public int Month { get { return date.Month; } }
        public int Year { get { return date.Year; } }

        public SimpleDate(int Day, int Month, int Year)
        {
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
