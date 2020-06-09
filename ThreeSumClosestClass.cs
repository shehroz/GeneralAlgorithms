using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ThreeSumClosestClass
    {
        public  static int ThreeSumClosest(int[] nums, int target)
        {
            int diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length && diff!=0; i++)
            {
                for (int start=i+1,end=nums.Length-1; start<end;) 
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (Math.Abs(target) - sum < Math.Abs(diff))
                        diff = target - sum;
                    if (sum < target)
                        ++start;
                    else
                        --end;
                }
            }

            return target - diff;
        }
        public static int ThreeSumClosest2(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-2; i++)
            {
                for (int start = i+1,end=nums.Length-1; start < end; )
                {
                    int currentSum = nums[i] + nums[start] + nums[end];
                    if (currentSum > target)
                        end--;
                    else
                        start++;
                    if (Math.Abs(currentSum - target) < Math.Abs(result - target))
                        result = currentSum;
                }
            }
            return result;
        }
    }
}
