using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class FindKthLargestClass
    {
        public int FindKthLargest(int[] nums, int k)
        {
            //trivial solution
            Array.Sort(nums);
            return nums[nums.Length - k];

        }
    }
}
