using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Song
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string PathToFile { get; private set; }
        public string Lyrics { get; set; }
        public Artist Artist { get; private set; }

        public Song(string name, int year, Artist artist, string pathToFile)
        {
            this.Name = name;
            this.Year = year;
            this.PathToFile = pathToFile;
            this.Artist = artist;
            
        }

        public override string ToString()
        {
            return Name;
            
        }
    }
}
