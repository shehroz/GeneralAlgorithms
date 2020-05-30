using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class SingleNumberClass
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(); 
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], 1);
                }
                else
                {
                    int count = map[nums[i]];
                    map.Remove(nums[i]);
                    map.Add(nums[i], ++count);
                }
            }
            if(map.Count!=0)
            {
                foreach (var item in map)
                {
                    if (item.Value < 2)
                    {
                        return item.Key;
                    }
                }
                
            }
            return -1;
        }
    }
}
