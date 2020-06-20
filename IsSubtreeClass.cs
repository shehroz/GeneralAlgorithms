using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class IsSubtreeClass
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
                return false;
            else if (SameTree(s, t))
            {
                return true;
            }
            else
                return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        public bool SameTree(TreeNode s, TreeNode t)
        {
            if (t == null || s == null)
                return s == null && t == null;
            else if (s.val == t.val)
                return SameTree(s.left, t.left) && SameTree(s.right, t.right);
            else
                return false;

        }
        }
}
