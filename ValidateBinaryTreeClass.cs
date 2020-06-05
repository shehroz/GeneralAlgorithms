using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class ValidateBinaryTreeClass
    {
        public static bool IsValidBST(TreeNode root)
        {
            return ValidateBST(root, long.MinValue, long.MaxValue);
        }
        public static bool ValidateBST(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;
            else if (root.left != null && root.left.val >= root.val)
                return false;
            else if (root.right != null && root.right.val <= root.val)
                return false;
            else if (min != long.MinValue && root.val <= min)
                return false;
            else if (max != long.MaxValue && root.val >= max)
                return false;
            else
                return ValidateBST(root.left, min, root.val) &&
                ValidateBST(root.right, root.val, max);
        }
    }
}
