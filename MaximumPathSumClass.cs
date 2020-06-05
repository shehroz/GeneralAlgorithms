using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MaximumPathSumClass
    {
        private static int MaxSum;
        public static int MaxPathSum(TreeNode root)
        {
            MaxSum = int.MinValue;
            PathSum(root);
            return MaxSum;
        }
        private static int PathSum(TreeNode root)
        {
            if (root == null)
                return 0;
            int sumleft = Math.Max(0, PathSum(root.left));
            int sumright = Math.Max(0, PathSum(root.right));
            MaxSum = Math.Max(MaxSum, sumleft + sumright + root.val);
            return Math.Max(sumleft,sumright) + root.val;
        }
    }
}
