using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class OrangesRottingClass
    {
        public static int OrangesRotting(int[][] grid)
        {
            HashSet<string> freshOranges = new HashSet<string>();
            HashSet<string> rottenOranges = new HashSet<string>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                        freshOranges.Add("" + i + j);
                    else if (grid[i][j] == 2)
                        rottenOranges.Add("" + i + j);

                }
            }
            int minutes = 0;
            int[][] directions = 
                {
                new int[]{ 0, 1 },
                new int[]{ 1, 0 },
                new int[]{ -1, 0 },
                new int[]{ 0, -1 }
            };

            while (freshOranges.Count > 0)
            {
                HashSet<string> infected = new HashSet<string>();
                foreach (string item in rottenOranges)
                {
                    int i = item[0]-'0';
                    int j = item[1]-'0';
                    foreach (int[] dd in directions)
                    {
                        int nextI = i+ dd[0];
                        int nextJ = j+ dd[1];
                        if(freshOranges.Contains(""+nextI+nextJ))
                        {
                            freshOranges.Remove("" + nextI + nextJ);
                            infected.Add("" + nextI + nextJ);
                        }
                    }

                }
                if (infected.Count == 0)
                {
                    return -1;
                }
                rottenOranges = infected;
                minutes++;
                
            }

            return minutes;
        }
        public static int OrangesRotting2(int[][] grid)
        {
            var rows = grid.Length;
            var columns = grid[0].Length;

            var freshOranges = new HashSet<int>();
            var rottenOranges = new HashSet<int>();

            var customColumns = rows + columns;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var current = grid[row][col];
                    if (current == 1)
                    {
                        freshOranges.Add(row * customColumns + col);
                    }
                    else if (current == 2)
                    {
                        rottenOranges.Add(row * customColumns + col);
                    }
                }
            }

            if (freshOranges.Count == 0)
            {
                return 0;
            }

            int minutes = 0;
            while (freshOranges.Count > 0)
            {
                var foundOne = false;
                var nextMinuteRotten = new HashSet<int>();

                foreach (var item in rottenOranges)
                {
                    var row = item / customColumns;
                    var col = item - row * customColumns;

                    var leftOneFresh = (col - 1) >= 0 && grid[row][col - 1] == 1;
                    var rightOneFresh = (col + 1) < columns && grid[row][col + 1] == 1;
                    var upOneFresh = (row - 1) >= 0 && grid[row - 1][col] == 1;
                    var downOneFresh = (row + 1) < rows && grid[row + 1][col] == 1;

                    if (leftOneFresh)
                    {
                        var key = row * customColumns + (col - 1);

                        nextMinuteRotten.Add(key);
                        freshOranges.Remove(key);
                        grid[row][col - 1] = 2;
                    }

                    if (rightOneFresh)
                    {
                        var key = row * customColumns + (col + 1);
                        nextMinuteRotten.Add(key);
                        freshOranges.Remove(key);
                        grid[row][col + 1] = 2;
                    }

                    if (upOneFresh)
                    {
                        var key = (row - 1) * customColumns + col;
                        nextMinuteRotten.Add(key);
                        freshOranges.Remove(key);
                        grid[row - 1][col] = 2;
                    }

                    if (downOneFresh)
                    {
                        var key = (row + 1) * customColumns + col;
                        nextMinuteRotten.Add(key);
                        freshOranges.Remove(key);
                        grid[row + 1][col] = 2;
                    }

                    foundOne = foundOne || leftOneFresh || rightOneFresh || upOneFresh || downOneFresh;
                }

                if (!foundOne)
                {
                    return -1;
                }

                rottenOranges = new HashSet<int>(nextMinuteRotten);
                minutes++;
            }

            return minutes;
        }

        public static int OrangesRotting3(int[][] grid)
        {
            HashSet<string> freshOranges = new HashSet<string>();
            HashSet<string> rottenOranges = new HashSet<string>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                        freshOranges.Add("" + i + j);
                    else if (grid[i][j] == 2)
                        rottenOranges.Add("" + i + j);
                }
            }

            int minutes = 0;
            int[][] directons = new int[][]
            {
                new int[]{0,1},
                new int[]{1,0},
                new int[]{-1,0},
                new int[]{0,-1},
            };
            while (freshOranges.Count > 0)
            {
                HashSet<string> infected = new HashSet<string>();
                foreach (var item in rottenOranges)
                {
                    int i = item[0] - '0';
                    int j = item[1] - '0';
                    foreach (int[] dir in directons)
                    {
                        int nexti = i + dir[0];
                        int nextj = j + dir[1];
                        if (freshOranges.Contains("" + nexti + nextj))
                        {
                            infected.Add("" + nexti + nextj);
                            freshOranges.Remove("" + nexti + nextj);
                        }

                    }
                }
                if (infected.Count == 0)
                    return -1;
                rottenOranges = infected;
                minutes++;
                
            }

            return minutes;
        }
    }
}
