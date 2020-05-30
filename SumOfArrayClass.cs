using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    class SumOfArrayClass
    {
        public static int SumofArray(int[] arr)
        {
            if (arr.Length == 0)
                return 0;
            else if (arr.Length == 1)
                return arr[0];
            string Sum = arr[0].ToString();
            for (int i = 1; i < arr.Length; i++)
            {
                Sum = SumofTwoStrings(Sum, arr[i].ToString());
            }
            int Result = Convert.ToInt32(Sum);
            return Result;
        }
        public static string SumofTwoStrings(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                s2 = s2.PadLeft(s1.Length, '0');
            else if (s2.Length > s1.Length)
                s1 = s1.PadLeft(s2.Length , '0');

            int carry = 0,len=s1.Length-1;
            string sum = "";
            for (int i = len; i >= 0; i--)
            {
                int temp = Helper.ToInt(s1[i]) + Helper.ToInt(s2[i]) + carry;
                sum = (temp % 10).ToString() + sum;
                carry = temp / 10;
            }
            if (carry != 0)
                sum = carry.ToString() + sum;
            return sum;
        }

        
    }
}
