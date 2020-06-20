using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class WordBreakClass
    {
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            int len = s.Length;
            bool[] foundArr = new bool[len + 1];
            foundArr[0] = true;

            for (int i = 1; i < len+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if(foundArr[j] && wordDict.Contains(s.Substring(j, i - j))){
                        foundArr[i] = true;
                        break;
                    }
                }
            }

            return foundArr[len];
        }
    }
}
