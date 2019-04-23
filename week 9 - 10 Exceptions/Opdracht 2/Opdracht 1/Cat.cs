using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    public class Cat : Animal
    {
        /// <summary>
        /// Description of the bad habits that the cat has (e.g. "Scratches the couch").
        /// or null if the cat has no bad habits.
        /// </summary>
        public string BadHabits { get; private set; }
        public override decimal Price
        {
            get
            {
                decimal price = 60 - BadHabits.Length;
                if (price < 20)
                {
                    return 20;
                }
                else
                {
                    return price;
                }
            }
        }

        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits, Gender gender) : base(chipRegistrationNumber, dateOfBirth, name, gender)
        {
            BadHabits = badHabits;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(BadHabits))
            {
                BadHabits = "none";
            }
            return base.ToString() + ", " + BadHabits;
        }
    }
}

