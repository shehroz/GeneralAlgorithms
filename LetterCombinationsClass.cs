using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class LetterCombinationsClass
    {
        public static IList<string> LetterCombinations(string digits)
        {
            

            List<string> result = new List<string>();
            if (digits.Length == 0)
                return result;
                string[] mappings = {
                "0",
                "1",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz",
           };

            LetterCombinationsRecursive(result, digits, "", 0, mappings);
            return result;
        }
        public static void LetterCombinationsRecursive(List<string> result,string digits,string current,int index,string[] mappings)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }
            string letters = mappings[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                LetterCombinationsRecursive(result, digits, current + letters[i], index + 1, mappings);
            }
        }
    }
}
