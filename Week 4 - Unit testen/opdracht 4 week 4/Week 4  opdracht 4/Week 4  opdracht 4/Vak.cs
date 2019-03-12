using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4__opdracht_4
{
    public class Vak
    {
        public string Vaknaam { get; private set; }
        public int Vakcode { get; private set; }
        public int Bsu { get; private set; }
        public string resultaten { get; private set; }

        public Vak(int vakcode, string vaknaam, int bsu)
        {
            this.Vaknaam = vaknaam;
            this.Vakcode = vakcode;
            this.Bsu = bsu;
        }

        public override string ToString()
        {
            return Vaknaam;
        }

        public void Resultaat(Vak vak, int Cijfer)
        {
            Resultaat resultaat = new Resultaat(vak, Cijfer);
            resultaten = resultaat.ToString();
        }

        public string Resultaten()
        {
            return this.resultaten;
        }

    }
}
