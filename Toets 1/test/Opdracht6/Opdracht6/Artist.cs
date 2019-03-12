using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Artist
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<Song> Songs { get; private set; }

        public Artist(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            Songs = new List<Song>();
        }

        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            return String.Format("Naam: {0} \nGeboortedatum: {1}", Name, Birthday.ToShortDateString());
        }
    }
}
