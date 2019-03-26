using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            
        }

        public override string MakeNoise()
        {
            return "Woef";
        }
    }
}
