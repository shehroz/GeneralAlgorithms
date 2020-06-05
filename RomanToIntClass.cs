using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class RomanToIntClass
    {
        public int RomanToInt(string s)
        {
            var res = 0;
            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && map[s[i]] > map[s[i - 1]])
                {
                    res = res + map[s[i]] - (2 * map[s[i - 1]]);
                }
                else
                    res += map[s[i]];
                
            }

            return res;
        }

        public int RomanToInt2(string s)
        {
            var res = 0;
            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            for (int i = 0; i < s.Length; i++)
            {

                if (i == 0)
                {
                    res += map[s[i]];
                    continue;
                }
                if (map[s[i - 1]] >= map[s[i]])
                {
                    res += map[s[i]];
                }
                else
                {
                    res = res + map[s[i]] - (2 * map[s[i - 1]]);
                }
            }

            return res;
        }
    }
}
