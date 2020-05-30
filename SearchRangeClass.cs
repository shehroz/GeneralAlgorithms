using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class SearchRangeClass
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            bool IsFilled = false;            
            if (nums == null || nums.Length == 0 )
            {
                return new int[2] { -1, -1 };
            }
            List<int> res = new List<int>();
            int len = nums.Length-1;
            int index = 0;
            for (int i = 0; i <= nums.Length/2; i++)
            {
                if (nums[i] == target)
                {
                    res.Add(i);
                    IsFilled = true;
                    index = i+1;
                    break;
                }
            }
            for (int i = len; i >= index; i--)
            {
                if (nums[i] == target)
                {
                    if (IsFilled)
                    {
                        res.Add(i);
                        break;
                    }
                    else
                    {
                        if (res.Count == 0 || res.Count==1)
                        {
                            res.Add(i);
                        }
                        else if (res.Count == 2)
                        {
                            res.Remove(res[res.Count - 1]);
                            res.Add(i);
                        }
                    }
                }
            }

            if (res.Count == 0)
            {
                return new int[2] { -1, -1 };
            }
            else if (res.Count == 1)
            {
                res.Add(res[0]);
            }

            int[] result = res.ToArray();
            Array.Sort(result);
            return result;

        }
    }
}
