using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ValidParenthesisClass
    {
        //{[()]} {[()
        public static bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            map.Add('}', '{');
            map.Add(')', '(');
            map.Add(']', '[');

            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stk.Push(s[i]);
                }
                else if (map.ContainsKey(s[i]))
                {
                    if (stk.Count > 0 && stk.Peek() == map[s[i]])
                        stk.Pop();
                    else
                        return false;
                }
            }
            return stk.Count == 0;
        }
    }
}
