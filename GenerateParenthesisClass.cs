using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    class GenerateParenthesisClass
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            if (n == 0)
                return result;
            GenerateParenthesisRec(result, "", 0, 0, n);
            return result;
        }

        public static void GenerateParenthesisRec(List<string> result, string current, int open, int close, int max)
        {
            if(current.Length== max * 2)
            {
                result.Add(current);
                return;
            }
            if (open < max)
                GenerateParenthesisRec(result, current + "(", open + 1, close, max);
            if (close < open)
                GenerateParenthesisRec(result, current + ")",open, close + 1, max);
        }

    }
}
