using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class CombinationSumClass
    {
        static IList<IList<int>> result = new List<IList<int>>();
        static IList<IList<int>> resultCombinations = new List<IList<int>>();
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            FindCombinations(candidates, target, 0, new List<int>(), 0, 0);
            return result;
        }
        static void FindCombinations(int[] candidates, int target, int start, List<int> list, int sum, int NumberOfElements)
        {
            if (sum >= target)
            {
                if (sum == target)
                    result.Add(list.Take(NumberOfElements).ToList());
                return;
            }
            for (int i = start; i < candidates.Length; i++)
            {
                if (NumberOfElements == list.Count)
                    list.Add(candidates[i]);
                else
                    list[NumberOfElements] = candidates[i];
                FindCombinations(candidates, target, i, list, sum + candidates[i], NumberOfElements + 1);
            }
        }
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            FindCombinations2(candidates, target, 0, new List<int>(), 0, 0);
            return resultCombinations;
        }
        static void FindCombinations2(int[] candidates, int target, int start, List<int> list, int sum, int NumberOfElements)
        {
            if (sum >= target)
            {
                if (sum == target)
                {
                    List<int> listToAdd = list.Take(NumberOfElements).ToList();
                    bool IsFound = resultCombinations.Any(x => x.SequenceEqual(listToAdd));
                    if (!IsFound)
                    {
                        resultCombinations.Add(listToAdd);
                    }
                }
                return;
            }
            for (int i = start; i < candidates.Length; i++)
            {
                if (NumberOfElements == list.Count)
                    list.Add(candidates[i]);
                else
                    list[NumberOfElements] = candidates[i];
                FindCombinations2(candidates, target, i + 1, list, sum + candidates[i], NumberOfElements + 1);
            }
        }

            
    }
}
