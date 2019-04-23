using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Student : IComparable<Student>
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public int Number { get; private set; }

        public Student(string name, string address, int number)
        {
            Name = name;
            Address = address;
            Number = number;
        }

        public int CompareTo(Student student)
        {
            if (student == null)
            {
                return -1;
            }
            else
            {
                return Name.CompareTo(student.Name);
            }
        }

        public override string ToString()
        {
            return string.Format("Name:  {0}, Adress: {1}, StudentNumber: {2}", Name, Address, Number.ToString());
        }

    }
}
