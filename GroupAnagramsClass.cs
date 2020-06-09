using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    class GroupAnagramsClass
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] strarr = strs[i].ToArray();
                Array.Sort(strarr);
                string sortedstring = new string(strarr);
                if (!map.ContainsKey(sortedstring))
                    map.Add(sortedstring, new List<string> { strs[i] });
                else
                {
                    List<string> currentlist = map[sortedstring];
                    currentlist.Add(strs[i]);
                    map[sortedstring] = currentlist;
                }
            }

            foreach (var item in map)
            {
                List<string> res = item.Value;
                result.Add(res);
            }
            return result;
        }
    }
}
