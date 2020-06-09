using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class FindNMaximumClass
    {
        public static int FindNHighest(int[] arr,int N=2)
        {
            int max = arr[0], smax = arr[0], tmax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]> max)
                {
                    if (smax < max)
                        smax = max;
                    else if (tmax < smax)
                        tmax = smax;
                    max = arr[i];
                }
                else if(arr[i] > smax)
                {
                    if (tmax < smax)
                        tmax = smax;
                    smax = arr[i];
                }
                else
                {
                    tmax = arr[i];
                }
            }

            return smax;
        } 
        
    }
}
