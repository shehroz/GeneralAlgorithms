using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class KClosestClass
    {
        public static int[][] KClosest(int[][] points, int K)
        {
            Dictionary<int, int> distances = new Dictionary<int, int>();

            // for each point calculate its distance from origin and save it in dictionary
            // key is index of point array and d is its distance from origin
            for (int i = 0; i < points.Length; i++)
            {
                int d = EuclideanDistanceFromOrigin(points[i][0], points[i][1]);
                distances.Add(i, d);
            }
            // sort disctionary by value (value is distance)
            var ordered = distances.OrderBy(x => x.Value).Take(K);

            int[][] result = new int[K][];
            int index = 0;

            // take top k elements and add them in result array
            foreach (KeyValuePair<int, int> kvp in ordered)
            {
                // from points array select coordinates
                result[index] = new int[]
                {
                    points[kvp.Key][0],
                    points[kvp.Key][1]
                };
                index++;
            }
            return result;
        }

        private static int EuclideanDistanceFromOrigin(int p1, int p2)
        {
            return ((p1 * p1) + (p2 * p2));
            // actual formula for euclidean distance is below but we do not need to take sqrt in our case.
            // Math.Sqrt((p1*p1)+(p2*p2));
        }

    }
}
