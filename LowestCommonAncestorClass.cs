using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class LowestCommonAncestorClass
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            else if (root == p || root == q)
                return root;

            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;
            else
                return left != null ? left : right != null ? right : null;

        }
    }
}
