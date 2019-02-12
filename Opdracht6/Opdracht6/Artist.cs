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

        public Artist(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public void AddSong(Song song)
        {

        }

        public override string ToString()
        {
            return
        }
    }
}
