using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
   public class Administration
    {
        public List<Animal> animals { get; private set; }
        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            for(int i = 0; i < animals.Count; i++)
            {
                if(animals[i].ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }

            animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int ChipRegistrationNumber)
        {
            for(int i = 0; i < animals.Count; i++)
            {
                if(animals[i].ChipRegistrationNumber == ChipRegistrationNumber)
                {
                    animals.Remove(animals[i]);
                    return true;
                }              
            }
            return false;
        }

        public Animal FindAnimal(int ChipRegistrationNumber)
        {
            for(int i = 0; i < animals.Count; i++)
            {
                if(animals[i].ChipRegistrationNumber == ChipRegistrationNumber)
                {
                    return animals[i];
                }
            }

            return null;
        }

        public void SortList()
        {
            animals.Sort();
        }
    }
}
