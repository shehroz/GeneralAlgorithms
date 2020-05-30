using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class RobClass
    {
        public int Rob(int[] nums)
        {
            int sum = 0;
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];
            else if (nums.Length < 4)
            {
                int max = 0, firstElement = nums[0];
                bool IsSame = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == firstElement)
                        IsSame = true;
                    else
                    {
                        IsSame = false;
                        firstElement = nums[i];
                    }
                    max = Math.Max(max, nums[i]);
                }
                if (IsSame)
                    return nums[0] + nums[2];
                return max;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                    sum += nums[i];
            }
            return sum;
        }
    }
}
