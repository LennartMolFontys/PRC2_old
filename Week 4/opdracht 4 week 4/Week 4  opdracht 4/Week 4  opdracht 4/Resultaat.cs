using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4__opdracht_4
{
    public class Resultaat
    {
        private string vak = "";
        public int Cijfer { get; private set; }

        public Resultaat(Vak vak, int cijfer)
        {
            this.vak = vak.ToString();
            this.Cijfer = cijfer;
        }

        public override string ToString()
        {
            return vak;
        }
    }
}
