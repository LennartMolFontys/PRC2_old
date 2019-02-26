using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_week_4
{
    public class Student
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }

        public Student(string name, string address)
        {
            if(address == "")
            {
                address = "Onbekend";
            }
            if (name == "") 
            {
                name = "Onbekend";
            }
            this.Name = name;
            this.Adress = address;
        }

        public override string ToString()
        {
            return Name + "  " + Adress;
        }
    }
}
