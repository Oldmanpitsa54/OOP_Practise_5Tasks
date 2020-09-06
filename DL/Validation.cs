using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Validation
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

        public static void Int_Digits_check(string input, out int output)
        {
            if (!int.TryParse(input, out output))
            {
                while (true)
                {
                    Console.WriteLine("Invalid value (not a digit). Try again.");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out output))
                    {
                        output = int.Parse(input);
                        break;
                    }
                }
            }
            else
            {
                output = int.Parse(input);
            }
        }

        public static void Ulong_Digits_check(string input, out ulong output)
        {
            if (!ulong.TryParse(input, out output))
            {
                while (true)
                {
                    Console.WriteLine("Invalid value. Try again.");
                    input = Console.ReadLine();
                    if (ulong.TryParse(input, out output))
                    {
                        output = ulong.Parse(input);
                        break;
                    }
                }
            }
            else
            {
                output = ulong.Parse(input);
            }
        }
    }
}
