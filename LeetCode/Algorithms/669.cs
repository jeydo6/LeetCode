using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _669
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

        public TreeNode TrimBST(TreeNode root, Int32 L, Int32 R)
        {
            if (root == null)
            {
                return null;
            }

            while (root.val < L || root.val > R)
            {
                if (root.val < L)
                {
                    root = root.right;
                }

                if (root.val > R)
                {
                    root = root.left;
                }
            }

            TreeNode temp;

            temp = root;
            while (temp != null)
            {
                while (temp.left != null && temp.left.val < L)
                {
                    temp.left = temp.left.right;
                }
                temp = temp.left;
            }

            temp = root;
            while (temp != null)
            {
                while (temp.right != null && temp.right.val > R)
                {
                    temp.right = temp.right.left;
                }
                temp = temp.right;
            }

            return root;
        }
    }
}
