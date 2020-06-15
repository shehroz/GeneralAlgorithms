using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public static class TwoSumClass
    {
        //int[] array = { 2, 7, 11, 15 };
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];
                if (map.ContainsKey(nums[i]))
                {
                    res[0] = map[nums[i]];
                    res[1] = i;
                    return res;
                }
                else
                {
                    if (!map.ContainsKey(comp))
                        map.Add(comp, i);
                }
            }
            return res;
        }

        
        //The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.
        public static int[] TwoSum_anotherversio(int[] numbers, int target)
        {
            int[] res = new int[2];
            int sum = 0;
            for (int start = 0, end = numbers.Length - 1; start < end;)
            {
                sum = numbers[start] + numbers[end];
                if (sum == target)
                {
                    res[0] = start + 1;
                    res[1] = end + 1;
                    return res;
                }
                else if (sum > target)
                {
                    end--;
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                    start++;
            }
            return res;
        }


        ///for Arrays Two sum array input array is sorted
        public static int[] TwoSum_array(int[] numbers, int target)
        {
            int[] res = new int[2];

            for (int start = 0, end = numbers.Length - 1; start < end;)
            {
                int sum = numbers[start] + numbers[end];
                if (sum == target)
                {
                    res[0] = start + 1;
                    res[1] = end + 1;
                    return res;
                }
                else if (sum > target)
                    end--;
                else
                    start++;
            }
            return res;
        }
    }
}
