using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
    public class _872
    {
        public class TreeNode
        {
            public TreeNode(Int32 x)
            {
                val = x;
            }

            public Int32 val;

            public TreeNode left;

            public TreeNode right;
        }

        public Boolean LeafSimilar(TreeNode root1, TreeNode root2)
        {
            TreeNode[] nodes1 = GetLeaves(root1);
            TreeNode[] nodes2 = GetLeaves(root2);

            if (nodes1.Length != nodes2.Length)
            {
                return false;
            }

            for (Int32 i = 0; i < nodes1.Length; i++)
            {
                if (nodes1[i].val != nodes2[i].val)
                {
                    return false;
                }
            }

            return true;
        }

        private TreeNode[] GetLeaves(TreeNode root)
        {
            ICollection<TreeNode> resultCollection = new List<TreeNode>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                
                if (node.left != null || node.right != null)
                {
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }

                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                }
                else
                {
                    resultCollection.Add(node);
                }
            }

            TreeNode[] resultArray = new TreeNode[resultCollection.Count];

            resultCollection.CopyTo(resultArray, 0);

            return resultArray;
        }
    }
}
