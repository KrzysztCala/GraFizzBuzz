using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraFizzBuzz
{
    internal class FizzBuzz
    {
        public FizzBuzz(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public string Process()
        {
            if (Number % 3 == 0 && Number % 5 == 0)
            {
                return "== FizzBuzz ==";
            }
            else if (Number % 3 == 0)
            {
                return "== Fizz ==";
            }
            else if (Number % 5 == 0)
            {
                return "== Buzz ==";
            }
            else
            {
                return Number.ToString();
            }
        }
    }
}
