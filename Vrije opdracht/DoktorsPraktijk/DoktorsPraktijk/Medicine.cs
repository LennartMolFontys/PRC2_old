using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    public class Medicine : Treatment
    {
        public int Dosage { get;  private set; }
        public override decimal Price
        {
            get
            {
                int dosagde = Dosage;
                if (Dosage <= 0)
                {
                    Dosage = 1;
                }
                return Math.Round((0.025m * Dosage), 2);
            }
        }

        public Medicine(int days, SimpleDate startDate, string treatmentName, int dosage) : base(days, startDate, treatmentName)
        {
            if (days <= 0) throw new ArgumentException("Number of days can't be 0 or less then 0", nameof(days));
            if (dosage <= 0) throw new ArgumentException("Dosage can't be 0 or less then 0", nameof(dosage));
 
            Dosage = dosage;

        }

        public override string ToString()
        {
            return base.ToString() + ", Dosage: " +  Dosage + " Price: " + Math.Round(Price,2);
        }
    }
}
