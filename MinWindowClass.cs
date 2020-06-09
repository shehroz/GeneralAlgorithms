using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MinWindowClass
    {
        public static string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return "";
            string res="";
            int[] letterCount = new int[128];
            int left = 0, count = 0, minlen = int.MaxValue;

            foreach (char c in t.ToCharArray())
            {
                ++letterCount[c];
            }
            
            for (int right = 0; right < s.Length; ++right)
            {
                if (--letterCount[s[right]] >= 0)
                    ++count;
                while (count == t.Length)
                {
                    if(minlen > right - left + 1)
                    {
                        minlen = right - left + 1;
                        res=s.Substring(left , right-left +1);
                    }
                    if (++letterCount[s[left]] > 0)
                        --count;
                    ++left;
                }
            }
            
            return res;
        }
    }
}
