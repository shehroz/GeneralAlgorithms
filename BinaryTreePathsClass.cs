using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class BinaryTreePathsClass
    {
        //Time complexity is O(n)
        //Space complexity is O(n)
        // where n is the number of nodes in the tree
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> Paths = new List<string>();
            if (root == null)
            {
                return Paths;
            }
            DFS(root, "", Paths);
            return Paths;
        }
        public void DFS(TreeNode root, string path, List<string> Paths)
        {
            path += root.val;
            if (root.left == null && root.right == null)
            {
                Paths.Add(path);
                return;
            }
            if (root.left != null)
                DFS(root.left, path + "->", Paths);
            if (root.right != null)
                DFS(root.right, path + "->", Paths);


        }
    }
}
