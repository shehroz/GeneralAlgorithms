using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericAlgorithms
{
    public class ReorganizeStringClass
    {
        public static string ReorganizeString(string S)
        {
            if (S == null || S.Length < 2)
                return S;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int n = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (!map.ContainsKey(S[i]))
                    map.Add(S[i], 1);
                else
                    map[S[i]] = map[S[i]] + 1;
            }
            int max = map.OrderByDescending(x => x.Value).Select(x => x.Value).FirstOrDefault();
            if (max > (S.Length + 1) / 2)
                return "";

            StringBuilder str = new StringBuilder(S);
            int position = 0;
            IOrderedEnumerable<KeyValuePair<char, int>> sortedCollection = map.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in sortedCollection)
            {
                char current = item.Key;
                for (int i = 0; i < item.Value; i++)
                {
                    str[position] = item.Key;
                    position = (position + 2 >= n) ? 1 : position + 2;
                }

            }


            return str.ToString();
        }
        public static string ReorganizeString2(string s)
        {
            if (s == null || s.Length < 2)
                return s;

            int n = s.Length;

            // Calculate and store frequencies in char-frequency map.
            // Find character and frequency with max frequency
            int freqChar = -1;
            int freqCharCount = -1;
            int[] freq = new int[26];
            for (int i = 0; i < n; i++)
            {
                freq[s[i] - 'a']++;
                if (freq[s[i] - 'a'] > freqCharCount)
                {
                    freqCharCount = freq[s[i] - 'a'];
                    freqChar = s[i] - 'a';
                }
            }

            // Required string is only possible when char with max frequency is less than equal to half of size of given string.
            if (freqCharCount > (n + 1) / 2)
                return "";

            StringBuilder str = new StringBuilder(s);
            int position = 0;
            // In case it is possible, arrange the most occuring character on even positions. 
            // Arrange the remaining characters on alternate remaining positions. 
            // This makes sure that no 2 same character occurs together.
            for (int i = -1; i < 26; i++)
            {
                int current = (i == -1) ? freqChar : i;
                while (freq[current]-- > 0)
                {
                    str[position] = (char)('a' + current);
                    position = (position + 2 >= n) ? 1 : position + 2;
                }
            }

            return str.ToString();
        }
    }
}
