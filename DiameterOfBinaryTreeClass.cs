using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class DiameterOfBinaryTreeClass
    {
        int maxD = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxD = 1;
            DFS(root);
            return maxD - 1;
        }
        public int DFS(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = DFS(root.left);
            int right = DFS(root.right);
            maxD = Math.Max(maxD, left + right + 1);
            return 1 + Math.Max(left, right);
        }
    }
}
