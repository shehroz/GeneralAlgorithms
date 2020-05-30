using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class Amazon_GCDClass
    {
        public static int generalizedGCD(int num, int[] arr)
        {
            return arr.Aggregate(CalculateGCD);
        }
        public static int CalculateGCD(int a, int b)
        {
            return b == 0 ? a : CalculateGCD(b, a % b);
        }

        public static int myGCD_one_test_case_not_passed(int num, int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return -1;
            int divider = arr.Min();
            bool isDivisible = false;
            while (divider != 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % divider == 0)
                    {
                        isDivisible = true;
                    }
                    else
                    {
                        divider--;
                        i = 0;
                    }
                }
                if (isDivisible)
                    return divider;
            }
            return 1;
        }
    }
}
