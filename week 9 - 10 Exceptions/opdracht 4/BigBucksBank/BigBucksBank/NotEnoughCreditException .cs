using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigBucksBank
{
   public class NotEnoughCreditException : Exception
    {
        private string message;
        public NotEnoughCreditException(string Message)
        {
            this.message = Message;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
