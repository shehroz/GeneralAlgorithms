using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MissingNumberClass
    {
        public static int MissingNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int item in nums)
            {
                set.Add(item);
            }
            for (int i = 0; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                    return i;
            }
            return 1;
        }
    }
}
