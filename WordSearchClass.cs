using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class WordSearchClass
    {
        private static bool DFS(char[][]board,int i,int j,int count,string word)
        {
            if (count == word.Length)
                return true;
            if (i < 0 || j < 0 || i > board.Length - 1 || j > board[i].Length - 1 || board[i][j]!=word[count])
                return false;

            char temp = board[i][j];
            board[i][j] = ' ';
            bool isfound =
                DFS(board, i + 1, j, count + 1, word) ||
                DFS(board, i - 1, j, count + 1, word) ||
                DFS(board, i, j - 1, count + 1, word) ||
                DFS(board, i, j + 1, count + 1, word);

            board[i][j] = temp;
            return isfound;
        }

        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (word[0] == board[i][j] && DFS(board, i, j, 0, word))
                        return true;
                }
            }
            return false;
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (Exist(board, words[i]))
                    result.Add(words[i]);
            }
            return result;
        }

    }
}
