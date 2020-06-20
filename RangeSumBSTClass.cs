using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class RangeSumBSTClass
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root == null)
                return sum;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode current = queue.Dequeue();
                if (current.val >= L && current.val <= R)
                    sum += current.val;
                if (current.left != null && current.val > L)
                    queue.Enqueue(current.left);
                if (current.right != null && current.val < R)
                    queue.Enqueue(current.right);
            }
            return sum;
        }
    }
}
