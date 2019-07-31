using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _897
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

        TreeNode current;

        public TreeNode IncreasingBST(TreeNode root)
        {
            ICollection<Int32> values = new List<Int32>();

            TreeNode result = new TreeNode(0);
            current = result;

            Inorder(root);

            return result.right;
        }

        public void Inorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.left);

            node.left = null;
            current.right = node;
            current = node;

            Inorder(node.right);
        }

        //public TreeNode IncreasingBST(TreeNode root)
        //{
        //    ICollection<Int32> values = new List<Int32>();

        //    Inorder(root, values);

        //    TreeNode result = new TreeNode(0);

        //    TreeNode temp = result;
        //    foreach (Int32 value in values)
        //    {
        //        temp.right = new TreeNode(value);
        //        temp = temp.right;
        //    }

        //    return result.right;
        //}

        //public void Inorder(TreeNode node, ICollection<Int32> values)
        //{
        //    if (node == null)
        //    {
        //        return;
        //    }

        //    Inorder(node.left, values);

        //    values.Add(node.val);

        //    Inorder(node.right, values);
        //}
    }
}
