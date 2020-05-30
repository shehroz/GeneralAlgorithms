using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class SumofThreeConsecutiveNumbersClass
    {
        public static int[] SumofThreeConsecutiveNumbers(int[] array, int targetSum)
        {
            int sum = 0;
            int NumbersToSum = 3;
            int[] res = new int[NumbersToSum];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i >= NumbersToSum - 1)
                {
                    if (sum == targetSum)
                    {
                        int index = 0;
                        for (int j = i; j >= (i - NumbersToSum + 1); j--)
                        {
                            res[index++] = array[j];
                        }
                        return res;
                    }
                    else
                    {
                        sum = sum - array[i - NumbersToSum + 1];
                    }
                }
            }
            return res;
        }
        public static int FindMaxSumSubArray(int[] arr,int k)
        {
            int maxValue = 0;
            int CurrentRunningSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                CurrentRunningSum += arr[i];
                if (i >= k - 1)
                {
                    maxValue = Math.Max(maxValue, CurrentRunningSum);
                    CurrentRunningSum -= arr[i - (k - 1)];
                }
            }
            return maxValue;
        }
        public static int SmallestSubArray(int targetSum,int[] arr)
        {
            int minWindowSize = int.MaxValue;
            int CurrentWindowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                CurrentWindowSum += arr[windowEnd];

                while(CurrentWindowSum >=targetSum)
                {
                    minWindowSize = Math.Min(minWindowSize, windowEnd - windowStart + 1);
                    CurrentWindowSum -= arr[windowStart];
                    windowStart++;
                }
            }
            return minWindowSize;
        }
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];
            int maxSum = nums[0];
            int maxSumRunning = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                maxSumRunning = maxSumRunning + nums[i];
                if (maxSum < maxSumRunning)
                    maxSum = maxSumRunning;
                if (maxSumRunning < 0)
                    maxSumRunning = 0;
            }
            return maxSum;
        }
            
        
    }
}
