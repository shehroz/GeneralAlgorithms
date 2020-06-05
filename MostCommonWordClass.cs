using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace GenericAlgorithms
{
    public class MostCommonWordClass
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            if (string.IsNullOrEmpty(paragraph))
                return "";
            Dictionary<string, int> map = new Dictionary<string, int>();
            Regex regex = new Regex("[*'\",_&#^@!?.;:]");

            string[] paragraphList = regex.Replace(paragraph, " ").Trim().Split(" ");
            for (int i = 0; i < paragraphList.Length; i++)
            {
                if (!string.IsNullOrEmpty(paragraphList[i]))
                {
                    if (!map.ContainsKey(paragraphList[i].ToLower()))
                        map.Add(paragraphList[i].ToLower(), 1);
                    else
                        map[paragraphList[i].ToLower()] = map[paragraphList[i].ToLower()] + 1;
                }
            }


            bool IsFound = false;
            List<string> paraWordList = map.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            foreach (var item in paraWordList)
            {
                foreach (var bandword in banned)
                {
                    if (item == bandword)
                    {
                        IsFound = true;
                        break;
                    }
                    else
                        IsFound = false;
                }

                if (!IsFound)
                    return item;
            }
            return "";
            
        }
    }
}
