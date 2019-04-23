using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    public abstract class Animal
    {
        public  Gender gender { get; private set }
        public int ChipRegistrationNumber { get; private set; }

        public SimpleDate DateOfBirth { get; private set; }

        public string Name { get; private set; }

   
        public bool IsReserved { get; set; }

        public abstract decimal Price { get; }

        public Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, Gender gender)
        {
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            this.gender = gender;
            IsReserved = false;
        }

        public int CompareTo(Animal animal)
        {
            if (animal == null)
            {
                return 1;
            }
            else
            {
                return ChipRegistrationNumber.CompareTo(animal.ChipRegistrationNumber);
            }
        }

        public override string ToString()
        {
            string IsReservedString;
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + IsReservedString
                          + ", " + gender;
            return info;
        }
    }
}

