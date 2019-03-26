using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Cat : Animal
    {
        public Cat(string name) : base (name)
        {
           
        }

        public override string MakeNoise()
        {
            return "Miauw"; 
        }
    }
}
