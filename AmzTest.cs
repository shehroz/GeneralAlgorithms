using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    class AmzTest
    {
        public static List<int> lengthEachScene(List<char> inputList)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int step = 0; step < inputList.Count; step++)
            {
                if(!map.ContainsKey(inputList[step]))
                     map.Add(inputList[step], step);
                else
                {
                    map[inputList[step]] = step;
                }
            }

            List<int> result = new List<int>();
            int left = 0, right = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                right = Math.Max(right, map[inputList[i]]);
                if (right == i)
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
            Dictionary<string, int> popularfeatureCountMap = new Dictionary<string, int>();
            foreach (string item in possibleFeatures)
            {
                popularfeatureCountMap.Add(item, 0);
            }

            foreach (string feature in possibleFeatures)
            {
                foreach (string sentence in featureRequests)
                {

                    string[] tokens = sentence.Replace(',', ' ').Replace('?', ' ').Replace('!', ' ').ToLower().Split(' ');

                    foreach (string word in tokens)
                    {
                        if (word.Equals(feature.ToLower()))
                        {

                            popularfeatureCountMap[feature] = popularfeatureCountMap[feature] + 1;
                            break;
                        }
                    }
                }
            }
            IOrderedEnumerable<KeyValuePair<string, int>> sortedCollection =
            popularfeatureCountMap.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            int count = 0;
            List<string> results = new List<string>();
            foreach (KeyValuePair<string, int> item in sortedCollection)
            {
                if (count < topFeatures)
                {
                    results.Add(item.Key);
                    count = count + 1;
                }
            }

            return results;

        }
    }
}
