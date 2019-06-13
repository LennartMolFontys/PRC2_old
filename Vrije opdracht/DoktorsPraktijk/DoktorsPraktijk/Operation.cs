using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorsPraktijk
{
    [Serializable]
    public class Operation : Treatment
    {
        public int RecoveryTime { get; private set; }
        public override decimal Price
        {
            get
            {
                int days = RecoveryTime;
                if (days <= 0)
                {
                    days = 1;
                }
                return 150 + (20m * days);
            }
        }

        public Operation(int days, SimpleDate startDate, string treatmentName, int recoveryTime) : base(days, startDate, treatmentName)
        {
            if (recoveryTime <= 0) throw new ArgumentException("Recovery Time can't be Zero or less then Zero", nameof(recoveryTime));

            RecoveryTime = recoveryTime;

        }

        public override string ToString()
        {
            return base.ToString() + ", Recovery Time: " + RecoveryTime + " Price: " + Price;
        }
    }
}
