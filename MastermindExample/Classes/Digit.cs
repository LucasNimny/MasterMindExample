using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MastermindExample.Classes
{
    internal class RandomDigit
    {
        public RandomDigit()
        {
            RandomNumber = new Random().Next(1, 7);
        }
        public int RandomNumber { get; }

    }
}
