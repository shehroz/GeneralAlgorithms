using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    class PalindromeClass
    {
        public static string FindLongestSubstring(string str)
        {
            if (str == null || str.Length < 1) return "";

            int start = 0;
            int end = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int len1 = ExpandFromMiddle(str, i, i);
                int len2 = ExpandFromMiddle(str, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end )
                {
                    start = i - ((len - 1) / 2);
                    //end = i + (len / 2);
                    end = len;
                }
            }
            return str.Substring(start, end);
        }

        public static int ExpandFromMiddle(String str, int left, int right)
        {
            if (str == null || left > right) return 0;

            while (left >= 0 && right<str.Length && str[left] == str[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
        //"babad"
        //cbbd
        public static string LongestPalindrome(string s)
        {
            string str = Helper.RemoveSpaceFromSubstring(s);
            if (IsValidStringPalindrome(str))
                return s;
            Dictionary<char, char> map = new Dictionary<char, char>();
            int len = s.Length - 1, index = 0, maxlength=0; 
            str = "";
            string FinalString = "";
           
            while (index < len)
            {
                str = "";
                for (int i = index; i < s.Length; i++)
                {
                    str += s[i].ToString();
                    if (IsValidStringPalindrome(str))
                    {
                        if (maxlength < str.Length)
                        {
                            maxlength = str.Length;
                            FinalString = str;
                        }
                        
                    }

                }
                index++;
            }
            if (!string.IsNullOrEmpty(FinalString))
                return FinalString;
            else
                return "not found";
        }
        //
        //string stringValue = "A man, a plan, a canal: Panama";
        //string stringValue = "race a car";

        public static bool IsValidStringPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str.Trim()))
                return true;
            if (str.Length == 1)
                return true;
            int len = str.Length - 1;
            bool IsPalindrome = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                bool IsAlphaNumeric1 = IsAlphaNumberic(str[i]);
                bool IsAlphaNumeric2 = IsAlphaNumberic(str[len]);
                if (IsAlphaNumeric1 && IsAlphaNumeric2)
                {
                    if (str[i].ToString().ToUpper() == str[len].ToString().ToUpper())
                    {
                        IsPalindrome = true;
                    }
                    else
                    {
                        return false;
                    }

                    len--;
                }
                else if (!IsAlphaNumeric2 && IsAlphaNumeric1)
                {
                    len--;
                    i--;
                }
            }

            return IsPalindrome;
        }
        private static bool IsAlphaNumberic(char str)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(str.ToString(), @"^[a-zA-Z0-9]+$"))
                return true;
            else
                return false;
        }
        public static bool IsValidIntegerPalindrome(int x)
        {
            if (x < 0)
                return false;
            List<int> numList = ConvertIntToArrayList(x);
            int len = numList.Count-1;
            bool IsValid = true;
            for (int i = 0; i < numList.Count/2; i++)
            {
                if (numList[i] == numList[len])
                    IsValid = true;
                else
                    return false;

                len--;
            }
            return IsValid;
        }
        private static List<int> ConvertIntToArrayList(int x)
        {
            var numArray = new List<int>();
            while (x != 0)
            {
                int rem = x % 10;
                numArray.Add(rem);
                x = x / 10;
            }
            return numArray;
        }
    }
}
