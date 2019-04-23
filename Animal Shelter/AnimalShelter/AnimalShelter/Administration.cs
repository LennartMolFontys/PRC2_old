using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AnimalShelter
{
   public class Administration
    {
        private BinaryFormatter format = new BinaryFormatter();
        private List<string> ExportStrings = new List<string>();
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

        public void Save(string filename)
        {
            using (FileStream write = new FileStream(filename, FileMode.Create))
            {
               format.Serialize(write, Animals);
            }
        }

        public void Load(string filename)
        {
            Animals.Clear();
            using (FileStream read = new FileStream(filename, FileMode.Open))
            {
                Animals = format.Deserialize(read) as List<Animal>;
            }
        }

        public void Excport(string filename)
        {
            FillExportList();
            using (StreamWriter file = new StreamWriter(filename))
            {
               foreach (string s in ExportStrings)
               {
                  file.WriteLine(s);
               }
            }
        }

        private void FillExportList()
        {
            ExportStrings.Clear();
            foreach (Animal s in Animals)
            {
                if (s is Dog)
                {
                    string dog = "Dog: " + s.ToString();
                    ExportStrings.Add(dog);
                }
                if (s is Cat)
                {
                    string cat = "Cat: " + s.ToString();
                    ExportStrings.Add(cat);
                }
            }
        }
    }
}
