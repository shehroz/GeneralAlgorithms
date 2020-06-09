using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ContainerwithMostWaterClass
    {
        public static int MaxArea(int[] height)
        {
            int MaxArea = int.MinValue;
            for (int i = 0; i < height.Length-1; i++)
            {
                for (int j = i+1; j < height.Length; j++)
                {
                    int min = Math.Min(height[i], height[j]);
                    MaxArea = Math.Max(MaxArea, min * (j - i));
                }
            }
            return MaxArea;
        }
        public static int MaxArea_Optimized(int[] height)
        {
            int MaxArea = int.MinValue;
            int i = 0;
            int j = height.Length - 1;
            while (i < j)
            {
                int min = Math.Min(height[i], height[j]);
                MaxArea = Math.Max(MaxArea, min * (j - i));
                if (height[i] < height[j])
                    i++;
                else
                    j--;
            }
            return MaxArea;
        }
    }
}
