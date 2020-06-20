using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class CutOffTreeClass
    {
        public int CutOffTree(IList<IList<int>> forest)
        {
            if (forest == null || forest.Count == 0 || forest[0].Count == 0)
                return -1;
            var trees = new List<int[]>();
            for (int i = 0; i < forest.Count; i++)
                for (int j = 0; j < forest[i].Count; j++)
                    if (forest[i][j] > 1)
                        trees.Add(new int[] { forest[i][j], i, j });

            trees.Sort((a, b) => a[0].CompareTo(b[0]));

            int result = 0, x = 0, y = 0;
            foreach (var tree in trees)
            {
                var pathLength = FindPathLength(forest, x, y, tree[1], tree[2]);
                if (pathLength < 0) return -1;
                forest[tree[1]][tree[2]] = 1;
                result += pathLength;
                x = tree[1]; y = tree[2];
            }

            return result;
        }
        public int FindPathLength(IList<IList<int>> forest, int sr, int sc, int tr, int tc)
        {
            int[] dx = new int[] { -1, 0, 1, 0 };
            int[] dy = new int[] { 0, -1, 0, 1 };

            int n = forest.Count;
            int m = forest[0].Count;
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { sr, sc, 0 });
            bool[,] seen = new bool[n, m];
            seen[sr, sc] = true;
           
            while (queue.Any())
            {
                int[] w = queue.Dequeue();
                if (w[0] == tr && w[1] == tc)
                    return w[2];
                for (int i = 0; i < 4; i++)
                {
                    int x = w[0] + dx[i];
                    int y = w[1] + dy[i];
                    if (x >= 0 && y >= 0 && x < n && y < m && !seen[x, y] && forest[x][y] > 0)
                    {
                        seen[x, y] = true;
                        queue.Enqueue(new int[] { x, y, w[2] + 1 });
                    }
                }
            }
            return -1;
        }
    }
}
