using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class LengthOfLongestSubstringClass
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            int MaxLength = 0;
            Dictionary<char, int> Map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!Map.ContainsKey(s[i]))
                {
                    Map.Add(s[i], i);
                    if (MaxLength < Map.Count)
                        MaxLength = Map.Count;
                }
                else
                {
                    int index = Map[s[i]];
                    Map.Clear();
                    i = index;

                }
            }
            return MaxLength;
        }
        public static string LongestSubstring(string s)
        {
            if (s.Length == 0) return "";
            int MaxLength = 0;
            Dictionary<char, int> Map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!Map.ContainsKey(s[i]))
                {
                    Map.Add(s[i], i);
                    if (MaxLength < Map.Count)
                        MaxLength = Map.Count;
                }
                else
                {
                    int index = Map[s[i]];
                    Map.Clear();
                    i = index;

                }
            }
            string result = Helper.DictionaryToString(Map);
            return result;
        }
        
    }
}
