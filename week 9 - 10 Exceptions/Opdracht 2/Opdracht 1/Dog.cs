using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    public class Dog : Animal
    {
   
        public SimpleDate LastWalkDate { get; private set; }

        public override decimal Price
        {
            get
            {
                if (ChipRegistrationNumber < 50000)
                {
                    return 200;
                }
                else
                {
                    return 350;
                }
            }
        }

        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lastWalkDate, Gender gender) : base(chipRegistrationNumber, dateOfBirth, name, gender)
        {
            LastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {

            string lastwalkdate;

            if (LastWalkDate == null)
            {
                lastwalkdate = "Unknown";
            }
            else
            {
                lastwalkdate = LastWalkDate.ToString();
            }

            return base.ToString() + ", " + lastwalkdate;
        }
    }
}


