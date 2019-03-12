    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4__opdracht_4
{
    public class Student
    {
        public int TotaalBSU { get; private set; }
        public int Studentenummer { get; private set; }
        public string Studentennaam { get; private set; }
        public string Address { get; private set; }
        public string Geboortedatum { get; private set; }
        public List<Vak> Vakken { get; private set; }
        public List<string> Cijfers { get; private set; }




        public Student(int studentnummer, string studentnaam, string addres, string geboortedatum)
        {
            this.Studentenummer = studentnummer;
            this.Studentennaam = studentnaam;
            this.Address = addres;
            this.Geboortedatum = geboortedatum;
        }

        public void Addcijfer(Vak vak, int cijfer)
        {

            if (Cijfers.Contains(vak.Vakcode.ToString()))
            {
                int i = BekijkCijfer(vak);
                if (cijfer < i)
                {
                    cijfer = i;
                    int index = Cijfers.IndexOf(vak.Vakcode.ToString());
                    Cijfers[index] = vak.Vakcode + "  :  " + cijfer;
                }
            }
            else
            {
                int index = Cijfers.IndexOf(vak.Vakcode.ToString());
                vak.Resultaat(vak, cijfer);
                string toevoegen = vak.Resultaten() + ":" + cijfer;
                Cijfers.Add(toevoegen);
            }
        }

        public int BekijkCijfer(Vak vak)
        {
            int index = Cijfers.IndexOf(vak.Vakcode.ToString());
            string Vak = Cijfers[index];
            string x = Vak.Substring(Vak.IndexOf(":") + 1);
            int i = Convert.ToInt32(x);
            return i;
        }
        public int Hoogstecijfer()
        {
            int hoogstecijfer = 0;
            for (int i = 0; i < Cijfers.Count; i++)
            {
                string x = Cijfers[i].Substring(Cijfers[i].IndexOf(":") + 1);
                int j = Convert.ToInt32(x);
                if (j > hoogstecijfer)
                {
                    hoogstecijfer = j;
                }
            }
            return hoogstecijfer;
        }

        public int behaaldevakken()
        {
            int behaald = 0;
            for (int i = 0; i < Cijfers.Count; i++)
            {
                string vak = Cijfers[i].Substring(0, Cijfers.IndexOf(":"));
                string x = Cijfers[i].Substring(Cijfers[i].IndexOf(":") + 1);
                int j = Convert.ToInt32(x);
                if (j >= 6)
                {
                    behaald++;
                }
            }
            return behaald;
        }

        public void behaaldeBSU(Vak vak)
        {
            int totaal = 0;
            totaal = totaal + vak.Bsu;
        }

        public void NameChange(string naam)
        {
            this.Studentennaam = naam;
        }

        public void adressChange(string adress)
        {
            this.Address = adress;
        }
        public void Vak()
        {
            Vak NT = new Vak(1, "NT", 3);
            Vakken.Add(NT);
            Vak PTT = new Vak(2, "PTT", 6);
            Vakken.Add(PTT);
            Vak ES2 = new Vak(3, "ES2", 9);
            Vakken.Add(ES2);
            Vak LPA = new Vak(4, "LPA", 12);
            Vakken.Add(LPA);
        }

    }
}
