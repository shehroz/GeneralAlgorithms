using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericAlgorithms
{
    public class TopKFrequentClass
    {
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!map.ContainsKey(words[i]))
                    map.Add(words[i], 1);
                else
                    map[words[i]] = map[words[i]] + 1;
            }
            IList<string> result = map.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
            return result;
        }
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                    map[nums[i]] = map[nums[i]] + 1;
            }
            IList<int> result = map.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
            return result.ToArray();
        }
    }
}
