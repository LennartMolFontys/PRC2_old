using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    [Serializable]
    public abstract class Treatment : Ipractrice
    {
        public abstract decimal Price { get; }
        public string Adress { get; private set; }

        public int Days { get; private set; }
        public SimpleDate StartDate { get; private set; }

        public string TreatmentName { get; private set; }

        public Treatment(int days, SimpleDate startDate, string treatmentName)
        {
            if (string.IsNullOrEmpty(treatmentName)) throw new ArgumentException("Treatment name can't be null or Empty", nameof(treatmentName));
            if (days <= 0) throw new ArgumentException("Days can't be zero or less then zero", nameof(days));
            if (startDate == null) throw new ArgumentException("StartDate can't be null", nameof(startDate));

            TreatmentName = treatmentName;
            Days = days;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return TreatmentName + ", "+ "Number of days: " + Days + ", " + StartDate.ToString();
        }
    }
}
