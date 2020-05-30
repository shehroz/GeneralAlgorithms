using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class Solution
    {
        public static string LongestPalindrome(string s)
        {
            var start = 0;
            var length = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var len1 = Expand(s, i, i);
                var len2 = Expand(s, i, i + 1);
                var len = Math.Max(len1, len2);

                if (len > length)
                {
                    start = i - (len - 1) / 2;
                    length = len;
                }
            }
            return s.Substring(start, length);
        }
        public static int Expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }


}

