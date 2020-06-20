using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class NumberToWordsClass
    {
        private static string[] LessThan20 = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                                   "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        private static string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static string[] Thousands = { "", "Thousand", "Million", "Billion" };

        public static string NumberToWords(int num)
        {

            if (num == 0)
                return "Zero";

            int i = 0; // point to Thousands
            string res = "";
            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    res = Helper(num % 1000) + Thousands[i] + " " + res;
                }

                num /= 1000;
                i++;
            }

            return res.Trim();
        }

        private static string Helper(int num)
        {
            if (num == 0)
                return "";
            else if (num < 20)
                return LessThan20[num] + " ";
            else if (num < 100)
                return Tens[num / 10] + " " + Helper(num % 10);
            else
                return LessThan20[num / 100] + " Hundred " + Helper(num % 100);
        }

        
    }
}
