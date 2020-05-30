using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    class ThreeSumClass
    {
        
        public static int[] CreateNewArray(int[] arr, int startingIndex)
        {
            int[] res = new int[arr.Length - 1];
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i != startingIndex)
                    res[index++] = arr[i];
            }
            return res;
        }
        public static int[] SumofDualOptimize(int[] arr, int sum)
        {
            int[] result = null;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int comp = sum - arr[i];
                if (dict.ContainsKey(arr[i]))
                {
                    result = new int[2];
                    result[0] = arr[i];
                    result[1] = comp;

                    return result;
                }
                else
                {
                    if (!dict.ContainsKey(comp))
                        //dict.Add(comp, arr[i]);
                        dict.Add(comp, i);
                }
            }
            return result;
        }
        public static int[] Sort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        public static bool IsAllZeros(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0) return false;

            }
            return true;
        }
        public static IList<IList<int>> ThreeSum(int[] num)
        {
            Array.Sort(num);
            var res = new List<IList<int>>();

            for (int i = 0; i < num.Length; i++)
            {
                if (i != 0 && num[i] == num[i - 1])
                {
                    continue;
                }
                for (int start = i + 1, end = num.Length - 1; start < end;)
                {
                    if (start != i + 1 && num[start] == num[start - 1])
                    {
                        start++;
                        continue;
                    }
                    if (num[i] + num[start] + num[end] == 0)
                    {
                        res.Add(new List<int> { num[i], num[start], num[end] });
                        start++;
                    }
                    else if (num[i] + num[start] + num[end] < 0)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }
            return res;

        }
        
    }
}

