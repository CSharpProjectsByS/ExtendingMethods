using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyRozszerzające
{
    static class MyInt
    {
        public static bool IsOneDigit(this int number)
        {
            Console.WriteLine("Początkowa wersja int: " + number.ToString());
            bool test = true;

            if (number >= 10 || number <= -10)
            {
                test = false;
            }

            return test;
        }

        public static bool IsNegative(this int number)
        {
            bool test = true;

            if (number > 0)
            {
                test = false;
            }

            return test;
        }

        public static int Pow(this int number, int pow)
        {
            return (int)Math.Pow(number, pow);
        }
    }
}
