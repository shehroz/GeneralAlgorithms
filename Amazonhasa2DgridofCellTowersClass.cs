using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    class Amazonhasa2DgridofCellTowersClass
    {
        private static bool CheckAdjacent(int i, int j, int rows, int columns, int[,] grid)
        {
            if (i > 0)
            {
                if (grid[i - 1, j] == 1) return true;
            }
            if (j > 0)
            {
                if (grid[i, j - 1] == 1) return true;
            }
            if (i < rows - 1)
            {
                if (grid[i + 1, j] == 1) return true;
            }
            if (j < columns - 1)
            {
                if (grid[i, j + 1] == 1) return true;
            }

            return false;
        }

        public static int DaystoUpgradeServer(int rows, int columns, int[,] grid)
        {
            int days = 0;
            bool isServerUpgrade = false;
            while (!isServerUpgrade)
            {
                int[,] temp = (int[,])grid.Clone();
                isServerUpgrade = true;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {

                        if (grid[i, j] == 0)
                        {
                            isServerUpgrade = false;
                            if (CheckAdjacent(i, j, rows, columns, grid))
                            {
                                temp[i, j] = 1;

                            }
                        }
                    }
                }
                grid = temp;
                days++;
            }

            return days - 1;
        }
    }
}
