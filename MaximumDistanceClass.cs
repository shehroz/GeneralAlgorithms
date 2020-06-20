using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MaximumDistanceClass
    {
        public static int MaximumDistance(int[] arr, int n)
        {
            int distance = 0;
            int startindex = -1;
            int endingindex = -1;
            for (int start = 0, end = arr.Length - 1; start < end;)
            {
                if (arr[start] == n)
                {
                    startindex = start;
                    start++;
                }
                else if (arr[end] == n)
                {
                    endingindex = end;
                    end--;
                }
                else if(startindex != -1 && endingindex != -1)
                {
                    break;
                }
                else if (startindex != -1)
                    end--;
                else if (endingindex != -1)
                    start++;
                else
                {
                    start++;
                    end--;
                }
                
            }
            distance = endingindex - startindex;
            return distance;
            
        }

        
        }

}
