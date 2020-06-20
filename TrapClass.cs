using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GenericAlgorithms
{
    public class TrapClass
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;
            int ans = 0;
            int size = height.Length;

            int[] left_max = new int[size];
            int[] right_max = new int[size];

            left_max[0] = height[0];
            for (int i = 1; i < size; i++)
            {
                left_max[i] = Math.Max(height[i], left_max[i - 1]);
            }
            right_max[size - 1] = height[size - 1];
            for (int i = size - 2; i >= 0; i--)
            {
                right_max[i] = Math.Max(height[i], right_max[i + 1]);
            }
            for (int i = 1; i < size - 1; i++)
            {
                int min = Math.Min(left_max[i], right_max[i]);
                ans +=  min - height[i];
            }
            return ans;
        }

        public int Trap2(int[] height)
        {
            int water = 0;
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] < max)
                    water += max - height[i];
                if (height[i] >= max)
                {
                    max = 0;
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        if (height[j] >= height[i])
                        {
                            max = height[i];
                            break;
                        }
                        max = Math.Max(max, height[j]);
                    }
                }
            }
            return water;
        }

        
    }
}
