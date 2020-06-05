using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class LevelOrderClass
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                List<int> currentlevel = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    currentlevel.Add(current.val);

                    if (current.left != null)
                        queue.Enqueue(current.left);
                    if (current.right != null)
                        queue.Enqueue(current.right);
                }
                result.Add(currentlevel);
                
            }

            return result;
        }
    }
}
