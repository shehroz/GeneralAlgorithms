using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class ConnectSticksClass
    {
        static SortedDictionary<int, int> map = new SortedDictionary<int, int>();
        static int size = 0;
        public static int ConnectSticks(int[] sticks)
        {
            int cost = 0;
            for (int i = 0; i < sticks.Length; i++)
            {
                AddSticks(sticks[i]);
            }

            while(size > 1)
            {
                int first = GetMin();
                int second = GetMin();
                int sum = first + second;
                cost += sum;
                AddSticks(sum);
            }

            return cost;
        }
        static void AddSticks(int v)
        {
            if (!map.ContainsKey(v))
                map.Add(v, 1);
            else
                map[v] = map[v] + 1;
            size++;
        }
        static int GetMin()
        {
            var first = map.First();
            if (first.Value == 1)
                map.Remove(first.Key);
            else
                map[first.Key]--;
            size--;
            return first.Key;
        }
    }
}
