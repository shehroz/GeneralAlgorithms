using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class FirstUniqCharClass
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                    map.Add(s[i], 1);
                else
                    map[s[i]] = map[s[i]] + 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    if (map[s[i]] == 1)
                        return i;
            }
            return -1;
        }
    }
}
