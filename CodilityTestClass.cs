using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class CodilityTestClass
    {
        #region Q1
        //Which gives an integer N returns the smallest integer that is greater than N and the sum of whose is equal to the sum of the digits of N
        //Q1
        public static int SumOfNumber(int N)
        {
            int sum = GetSum(N);
            int secondSum = 0;
            int desiredNum = N;
            
            while (secondSum != sum)
            {
                desiredNum++;
                secondSum = GetSum(desiredNum);
            }
            return desiredNum;
        }
        private static int GetSum(int N)
        {
            int sum = 0;
            while (N != 0)
            {
                sum += N % 10;
                N /= 10;
            }
            return sum;
        }
        #endregion

        #region Q2
        public static int Question2(int[] A, int[] B)
        {
            int count = 0;
            int aTotal = 0;
            int bTotal = 0;
            int aPartial = 0;
            int bPartial = 0;

            for (int i = 0; i < A.Length; i++)
            {
                aTotal += A[i];
                bTotal += B[i];
            }

            for (int i = A.Length-1; i >=0; i--)
            {
                aPartial += A[i];
                bPartial += B[i];
                if (aTotal - aPartial == aPartial && bTotal - bPartial == bPartial)
                    count++;
            }

            return count;
        }
        #endregion
    }
}
