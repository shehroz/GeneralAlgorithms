using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MajorityElementClass
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
                return -1;
            int element = 0,minOcc=nums.Length/2;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                {
                    int count = map[nums[i]];
                    map.Remove(nums[i]);
                    map.Add(nums[i], ++count);
                }

            }
            foreach (var item in map)
            {
                if(item.Value>minOcc)
                {
                    element = item.Key;
                }
            }

            return element;
        }
    }
}
