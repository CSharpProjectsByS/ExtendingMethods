using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyRozszerzające
{
    static class MyString
    {
        public static string Capitalize(this string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string part in str.Split())
            {
                stringBuilder.Append(char.ToUpper(part[0]));
                for (int i = 1; i < part.Length; i++)
                {
                    stringBuilder.Append(char.ToLower(part[i]));
                }
                stringBuilder.Append(" ");
            }

            return stringBuilder.ToString();
        }

        public static bool IsCapitalized(this string str)
        {
            bool test = true;

            foreach (string part in str.Split())
            {
                if (char.IsLower(part[0]))
                {
                    test = false;
                    break;
                }

                for (int i = 1; i < part.Length; i++)
                {
                    if (char.IsUpper(part[i])) {
                        test = false;
                        break;
                    }
                }

                if (!test)
                {
                    break;
                }
            }

            return test;
        }

        public static String CountWords(this string str)
        {
            int count = 0;

            foreach (string part in str.Split())
            {
                count++;   
            }

            return "Ilość słów: " + count.ToString();
        }

        public static string CountLetters(this string str, char[] charTable)
        {
            int[] count = new int[charTable.Length];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < charTable.Length; i++)
            {
                foreach (char c in str)
                {
                    if (c == charTable[i])
                    {
                        count[i]++;
                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < charTable.Length; i++)
            {
                stringBuilder.Append(charTable[i]);
                stringBuilder.Append(": ");
                stringBuilder.Append(count[i].ToString());
                stringBuilder.Append(", ");
            }

            return stringBuilder.ToString();
        }

        public static IEnumerable<T> Jump<T>(this IEnumerable<T> t, int jumpVal)
        {
            int count = 0;
            List<T> elements = new List<T>();
            foreach (T elem in t)
            {
                count++;
                if (count % jumpVal == 0)
                {
                    elements.Add(elem);
                }

            }

            return elements;
        }
    }
}
