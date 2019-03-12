using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_week_4
{
    public class Dice
    {
        public int Sides { get; private set; }
        public int Throw { get; private set; }

        private List<int> ogen = new List<int>();
        public List<int> Ogen{ get { return ogen; } private set { } }

        private Random dice = new Random();
        public Dice()
        {
            Sides = 6;
        }
        public Dice(int sides)
        {
            if(sides > 6)
            {
                this.Sides = sides;
            }
        }

        public int Thrown()
        {
            Throw = dice.Next(1, Sides);
            Ogen.Add(Throw);
            return Throw;
        }

        public int NrOfTimesThrown(int side)
        {
            int count = 0;
            for (int i = 0; i < Ogen.Count; i++)
            {
                if (side == Ogen[i])
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public void ResetStatistics()
        {
            Ogen.Clear();
        }

    }
}

