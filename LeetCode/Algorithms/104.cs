using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _104
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

        public Int32 MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Int32 depth = 0;
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            Stack<TreeNode> path = new Stack<TreeNode>();

            TreeNode node = root;
            nodes.Push(node);

            while (nodes.Count > 0)
            {
                node = nodes.Peek();
                if (path.Count > 0 && node == path.Peek())
                {
                    if (path.Count > depth)
                    {
                        depth = path.Count;
                    }

                    path.Pop();
                    nodes.Pop();
                }
                else
                {
                    path.Push(node);
                    if (node.left != null)
                    {
                        nodes.Push(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Push(node.right);
                    }
                }
            }

            return depth;
        }
    }
}
