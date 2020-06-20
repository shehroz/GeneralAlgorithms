using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class CanFinishClass
    {
        #region approach 1
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<int>[] map = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++)
                map[i] = new List<int>();
            int[] preCnt = new int[numCourses];

            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                int course = prerequisites[i][0];
                int pre = prerequisites[i][1];
                map[pre].Add(course);
                preCnt[course]++;
            }
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
                if (preCnt[i] == 0)
                    queue.Enqueue(i);

            while (queue.Count > 0)
            {
                int pre = queue.Dequeue();
                foreach (int c in map[pre])
                {
                    if (preCnt[c] == 0) return false;
                    preCnt[c]--;
                    if (preCnt[c] == 0) queue.Enqueue(c);
                }
            }
            return preCnt.All(x => x == 0);

        }

        #endregion



        #region approach 2

        static Dictionary<int, IList<int>> map = new Dictionary<int, IList<int>>();
        static HashSet<int> visited = new HashSet<int>();

        public static bool CanFinish2(int numCourses, int[][] prerequisites)
        {
            foreach (var prereq in prerequisites)
            {  // first load the prerequisites into dictionary for quick visit
                if (!map.ContainsKey(prereq[0]))
                {
                    map[prereq[0]] = new List<int>();
                }
                map[prereq[0]].Add(prereq[1]);
            }

            foreach (var key in map.Keys)
            {
                if (SearchCycle(key, new HashSet<int>()))
                    return false;
            }

            return true;
        }

        private static bool SearchCycle(int current, HashSet<int> chain)
        {
            if (chain.Contains(current))
                return true;     // find cycle
            if (visited.Contains(current))
                return false;  // already accessed course, means it doesn't have cycle

            visited.Add(current);
            if (map.ContainsKey(current))
            {  // has prerequisites, need search them
                chain.Add(current);
                foreach (var next in map[current])
                {
                    if (SearchCycle(next, chain))
                        return true;
                }
                chain.Remove(current);    // super important to remove current from chain so it won't effect the backtracking
            }

            return false;
        }


        #endregion
    }
}
