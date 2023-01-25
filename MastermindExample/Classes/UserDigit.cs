using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindExample.Classes
{
    internal class UserDigit
    {
        public UserDigit()
        {

        }

        private int givenDigit;

        public int GivenDigit
        {
            set
            {
                if (value > 6 || value < 1) givenDigit = -1;
                givenDigit = value;
            }
            get {
                return givenDigit;
            }
        }

        public char Result { get; set; } = ' ';

    }
}
