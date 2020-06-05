using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class IntegerToRomanClass
    {
        public static string IntToRoman(int num)
        {
            string[] thousand = { "", "M", "MM", "MMM" };

            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            string[] units = { "", "I", "II", "III", "IV","V" ,"VI", "VII", "VIII", "IX" };

            return thousand[num / 1000] +
                    hundred[(num % 1000) / 100] +
                    tens[(num % 100) / 10] +
                    units[num % 10 -1];

        }
    }
}
