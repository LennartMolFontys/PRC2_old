using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
   public class Administration
    {
        public List<Animal> Animals { get; private set; }
        public Administration()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            for(int i = 0; i < Animals.Count; i++)
            {
                if(Animals[i].ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }

            Animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int ChipRegistrationNumber)
        {
            for(int i = 0; i < Animals.Count; i++)
            {
                if(Animals[i].ChipRegistrationNumber == ChipRegistrationNumber)
                {
                    Animals.Remove(Animals[i]);
                    return true;
                }              
            }
            return false;
        }

        public Animal FindAnimal(int ChipRegistrationNumber)
        {
            for(int i = 0; i < Animals.Count; i++)
            {
                if(Animals[i].ChipRegistrationNumber == ChipRegistrationNumber)
                {
                    return Animals[i];
                }
            }

            return null;
        }

        public void SortList()
        {
            Animals.Sort();
        }
    }
}
