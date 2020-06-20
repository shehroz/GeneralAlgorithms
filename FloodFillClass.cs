using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class FloodFillClass
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
                return image;
            CheckAdjancent(image, sr, sc, image[sr][sc],newColor);
            return image;

        }
        private static void CheckAdjancent(int[][]image,int i,int j,int color,int newColor)
        {
            if (i < 0 || j < 0 || i >= image.Length || j >= image[i].Length || image[i][j] != color)
                return;

            image[i][j] = newColor;
            CheckAdjancent(image, i - 1, j, color, newColor);
            CheckAdjancent(image, i + 1, j, color, newColor);
            CheckAdjancent(image, i, j+1, color, newColor);
            CheckAdjancent(image, i, j-1, color, newColor);


        }
    }
}
