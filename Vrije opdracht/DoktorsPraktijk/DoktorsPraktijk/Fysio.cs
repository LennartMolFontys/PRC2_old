using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
   public class Fysio : Treatment
    {
        public override decimal Price
        {
            get
            {
                int days = Days;
                if (days <= 0)
                {
                    days = 1;
                }
                return 30m * days;
            }
        }

        public Fysio(int days, SimpleDate StartDate, string TreatmentName) :base(days, StartDate, TreatmentName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Price: " + Price;
        }
    }
}
