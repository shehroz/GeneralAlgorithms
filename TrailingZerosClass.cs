using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class TrailingZerosClass
    {
        public static int TrailingZeroes(int n)
        {
            int numberOfFives = 0;

            while (n >= 5)
            {
                numberOfFives += n / 5;
                n /= 5; // to further handle the cases like n=25 with 25 having two 5s
            }

            return numberOfFives;
        }
        static long Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1); ;
        }
    }
}
