using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class HasPathSumClass
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            else if (root.left == null && root.right == null && sum - root.val == 0)
                return true;
            else
                return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);

        }
    }
}
