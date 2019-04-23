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
            FileStream write = new FileStream(filename, FileMode.Create);
            try
            {
                format.Serialize(write, Animals);
            }catch (SerializationException e)
            {
                throw new SerializationException("Unable to Serialize:" + e.ToString());
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException("Invalid Characters in File Path \n" + e.ToString());
            }
            catch(PathTooLongException)
            {
                throw new PathTooLongException("File Path is to long");
            }
            catch(DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The specified path is invalid");
            }
            catch(IOException e)
            {
                throw new IOException("Unable to create file \n error: " + e.ToString());
            }
            catch (NotSupportedException)
            {
                throw new IOException("Invalid Path format");
            }
            finally
            {
                write.Close();
            }
        }

        public void Load(string filename)
        {
            Animals.Clear();
            FileStream read = new FileStream(filename, FileMode.Open);
            try
            {
                Animals = format.Deserialize(read) as List<Animal>;
            }
            catch (SerializationException e)
            {
                throw new SerializationException("Unable to Serialize:" + e.ToString());
            }
            finally
            {
                read.Close();
            }
        }

        public void Excport(string filename)
        {
            FillExportList();
            try
            {
                using (StreamWriter file = new StreamWriter(filename))
                {
                    foreach (string s in ExportStrings)
                    {
                        file.WriteLine(s);
                    }
                }
            }catch
            {

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
                    string cat = "Cat:" + s.ToString();
                    ExportStrings.Add(cat);
                }
            }
        }
    }
}
