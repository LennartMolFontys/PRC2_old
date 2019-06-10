using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DoktorsPraktijk
{
    public class FileHandler
    {
        //public string Filename { get;  private set; }
        public FileHandler() { }
        private BinaryFormatter format;

        public void Filehander()
        {
            format = new BinaryFormatter();
        }

        public bool ExportPatients(string fileName, List<Patient> patients)
        {
            if(!string.IsNullOrEmpty(fileName) || !string.IsNullOrWhiteSpace(fileName) && patients != null)
            {
                using (FileStream write = new FileStream(fileName, FileMode.Create))
                {
                    format.Serialize(write, patients);
                }
                return true;
            }
            return false;
        }

        public List<Patient> LoadPatients(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName) || !string.IsNullOrWhiteSpace(fileName))
            {
                using (FileStream Read = new FileStream(fileName, FileMode.Open))
                {
                    return format.Deserialize(Read) as List<Patient>;
                }
            }
            return null;
        }

        public bool ExportDokter(string fileName, List<Doctor> docters)
        {
            if(!string.IsNullOrEmpty(fileName) || !string.IsNullOrWhiteSpace(fileName) && docters !=null)
            {
                using (FileStream write = new FileStream(fileName, FileMode.Create))
                {
                    format.Serialize(write, docters);
                    return true;
                }
            }
            return false;
        }

        public List<Doctor> LoadDocter(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName) || !string.IsNullOrWhiteSpace(fileName))
            {
                using (FileStream read = new FileStream(fileName, FileMode.Open))
                {
                    return format.Deserialize(read) as List<Doctor>;
                }
            }
            return null;
        }

        public bool ExportAppointment(string fileName, List<Appointment> appointments)
        {
            if(!string.IsNullOrEmpty(fileName) || !string.IsNullOrWhiteSpace(fileName) && appointments !=null)
            {
                using (FileStream write = new FileStream(fileName, FileMode.Create))
                {
                    format.Serialize(write, appointments);
                    return true;
                }
            }
            return false;
        }

        public List<Appointment> LoadAppointment(string fileName)
        {
            if(!string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(fileName))
            {
                using (FileStream read = new FileStream(fileName, FileMode.Open))
                {
                    return format.Deserialize(read) as List<Appointment>;
                }
            }
            return null;
        }
    }
}
