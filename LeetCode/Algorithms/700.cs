using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _700
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

        public TreeNode SearchBST(TreeNode root, Int32 val)
        {
            if (root == null)
            {
                return null;
            }

            if (val == root.val)
            {
                return root;
            }
            else if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else if (val > root.val)
            {
                return SearchBST(root.right, val);
            }

            return null;
        }
    }
}
