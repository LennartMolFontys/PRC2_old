using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    public abstract class Animal
    {
        public string name { get; private set; }

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract string MakeNoise();
    }
}
