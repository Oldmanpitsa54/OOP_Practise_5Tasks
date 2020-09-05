using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    class Validation
    {
        public static void Decimal_Digits_check(string input, out decimal output)
        {
            if (!decimal.TryParse(input, out output))
            {
                while (true)
                {
                    Console.WriteLine("Invalid value (not a digit). Try again.");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out output))
                    {
                        output = decimal.Parse(input); //
                        break;
                    }
                }
            }
            else
            {
                output = decimal.Parse(input);
            }
        }
    }
}
