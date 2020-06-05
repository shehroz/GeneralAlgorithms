using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ZigzagLevelOrderClass
    {
        public  static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool IsZigZag = false;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                List<int> currentlevel = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    currentlevel.Add(current.val);
                    if (current.left != null)
                        queue.Enqueue(current.left);
                    if (current.right != null)
                        queue.Enqueue(current.right);
                }

                if (IsZigZag)
                    currentlevel.Reverse();
                result.Add(currentlevel);
                IsZigZag = !IsZigZag;
            }

            return result;
        }
    }
}
