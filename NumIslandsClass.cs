using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class NumIslandsClass
    {

        #region Num of Island
        public static int NumIslands(char[][] grid)
        {
            int NumberofIsland = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        NumberofIsland++;
                        CheckAdjacent(i, j, grid);
                    }
                }
            }
            return NumberofIsland;
        }
        private static void CheckAdjacent(int i, int j, char[][] grid)
        {
            if (i < 0 || j < 0 || i > grid.Length - 1 || j > grid[i].Length - 1 || grid[i][j] != '1')
            {
                return;
            }
            if (i >= grid.Length || i < 0 || j >= grid[i].Length || j < 0)
                return;
            if (grid[i][j] != '1')
                return;
            grid[i][j] = '*';
            CheckAdjacent(i + 1, j, grid);
            CheckAdjacent(i, j + 1, grid);
            CheckAdjacent(i - 1, j, grid);
            CheckAdjacent(i, j - 1, grid);

        }
        public int NumIslands_approach2(char[][] grid)
        {
            int numofdays = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        CheckAdjacent_approach2(i, j, grid);
                        numofdays++;
                    }
                }
            }
            return numofdays;
        }
        private void CheckAdjacent_approach2(int row, int column, char[][] grid)
        {

            if (row < 0 || column < 0 || row > grid.Length-1 || column > grid[0].Length - 1)
                return;
            if (grid[row][column] == '0')
                return;
            else if (grid[row][column] == '1')
            {
                grid[row][column] = '2';
                CheckAdjacent(row - 1, column, grid);
                CheckAdjacent(row, column - 1, grid);
                CheckAdjacent(row + 1, column, grid);
                CheckAdjacent(row, column + 1, grid);
            }
        }
        #endregion

        #region maxArea
        public  static int MaxAreaOfIsland(int[][] grid)
        {
            int MaxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        MaxArea = Math.Max(MaxArea, DFS(i, j, grid));
                    }
                }
            }
            return MaxArea;

        }
        private static int DFS(int row, int column, int[][] grid)
        {
            if (row < 0 || column < 0 || row > grid.Length - 1 || column > grid[row].Length - 1 || grid[row][column] == 0)
                return 0;
            grid[row][column] = 0;

            int count = 1;
            count += DFS(row - 1, column, grid);
            count += DFS(row + 1, column, grid);
            count += DFS(row, column - 1, grid);
            count += DFS(row, column + 1, grid);
            return count;
        }
        #endregion

        public static int MaxNumberOfIslands(char[][] grid)
        {
            int MaxCount = 0;
            
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        int numofisland = 1;
                        numofisland+=MaxNumberOfIslands_CheckAdjacent(i, j, grid);
                        MaxCount = Math.Max(MaxCount, numofisland);
                        
                    }
                }
            }
            return MaxCount;
        }
        private static int MaxNumberOfIslands_CheckAdjacent(int i,int j,char[][] grid)
        {
            //if (i < 0 || i > grid.Length - 1 || j < 0 || j > grid[i].Length - 1 || grid[i][j] != '1')
            //    return 0;

            int count = 0;
            if(i>0)
            {
                if (grid[i - 1][j] == '1')
                    count++;
            }
            if(j>0)
            {
                if (grid[i][j - 1] == '1')
                    count++;
            }
            if(i<grid.Length-1)
            {
                if (grid[i + 1][j] == '1')
                    count++;
            }
            if(j<grid[i].Length-1)
            {
                if (grid[i][j + 1] == '1')
                    count++;
            }
            return count;
        }

        
    }
}
