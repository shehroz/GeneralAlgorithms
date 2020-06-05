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


    }
}
