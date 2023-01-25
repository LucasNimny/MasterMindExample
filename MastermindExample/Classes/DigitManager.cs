using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MastermindExample.Classes
{
    internal class DigitManager
    {
        public DigitManager()
        {
            for(int i = 0; i <4; i++) { RandomDigit randomDigit = new(); Digits[i] = randomDigit; }
        }

        RandomDigit[] Digits = new RandomDigit[4];
        public bool won = false;
        public string CheckInput(ref UserDigit[] givenDigits)
        {
            if (givenDigits.Length != Digits.Length)
            {
                return "Error! Given Length not accurate...";
            }

            for (int i = 0; i < givenDigits.Length; i++)
            {
                if (givenDigits[i].Result == '+') continue;
                for (int j = 0; j < Digits.Length; j++)
                {
                    if (givenDigits[i].GivenDigit == Digits[j].RandomNumber)
                    {
                        if (i == j)
                        {
                            givenDigits[i].Result = '+';
                            break;
                        }

                        givenDigits[i].Result = '-';
                        continue;
                    }
                }
            }

            string finalOutput = string.Empty;
            foreach(var d in givenDigits)
            {
                finalOutput += d.Result;
            }
            if (finalOutput.Equals("++++")) won = true;

            return finalOutput;
        }
    }

}
