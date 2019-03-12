using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Song
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string PathToFile { get; set; }
        public string Lyrics { get; set; }

        public Song(string name, int year, Artist artist, string pathToFile)
        {
            this.Name = name;
            this.Year = year;
            this.PathToFile = pathToFile;
        }

        public override string ToString()
        {
            return
        }
    }
}
