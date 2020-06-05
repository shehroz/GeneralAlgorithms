using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericAlgorithms
{
    public class AmzTestPracticeClass
    {
        public static List<int> lengthEachScene(List<char> inputList)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (!map.ContainsKey(inputList[i]))
                    map.Add(inputList[i], i);
                else
                    map[inputList[i]] = i;
            }

            List<int> result = new List<int>();
            int left = 0, right = 0;
            for (int i = 0; i < inputList.Count; i++)
            {
                right = Math.Max(right, map[inputList[i]]);
                if(i==right)
                {
                    result.Add(1 + right - left);
                    left = right + 1;
                }
            }
            return result;
        }

        public static List<string> popularNFeatures(int numFeatures,
                                        int topFeatures,
                                        List<string> possibleFeatures,
                                        int numFeatureRequests,
                                        List<string> featureRequests)
        {
            Regex regex = new Regex("[*'\",_&#^@!?.]");
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var possiblefeature in possibleFeatures)
            {
                foreach (string sentence in featureRequests)
                {
                    string[] wordList = regex.Replace(sentence, " ").Trim().Split(" ");
                    foreach (var word in wordList)
                    {
                        string wordInLowerCase = possiblefeature.ToLower();
                        if (word.ToLower().Equals(wordInLowerCase))
                        {
                            if (!map.ContainsKey(wordInLowerCase))
                                map.Add(wordInLowerCase, 1);
                            else
                                map[wordInLowerCase] = map[wordInLowerCase] + 1;
                        }
                    }
                }
            }
            List<string> result =  map.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(topFeatures).Select(x=>x.Key).ToList();
            return result;

        }
    }
}
