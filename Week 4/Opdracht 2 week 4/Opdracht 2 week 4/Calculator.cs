using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_week_4
{
   public class Calculator
    {
        public double result { get; private set; }

        public Calculator()
        {
            result = 0;
        }

        public void Add(double value)
        {
            result = result + value;
        }

        public void Subtract(double value)
        {
            result = result - value;
        }

        public void Multiply(double value)
        {
            result = result * value;
        }

        public void Divide(double value)
        {
            result = result / value;
        }

        public void clear()
        {
            result = 0;
        }
    }
}
