using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericAlgorithms
{
    public class LongestCommonPrefixClass
    {
        //Input: ["flower","flow","flight"]
        //Output: "fl"
        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            if (strs.Length == 0)
                return result;
            string firstword = strs[0];
            int index = 0;
            foreach (char c in firstword.ToCharArray())
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (i > strs[i].Length || c != strs[i][index])
                        return result;
                }
                result += c;
                index++;
            }
            return result;
        }
    }

}
