using System;
namespace Leetcode.Algorithms
{
    public class _965
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

        public Boolean IsUnivalTree(TreeNode root)
        {
            Boolean leftCorrect = (root.left == null
                || (root.val == root.left.val && IsUnivalTree(root.left)));

            Boolean rightCorrect = (root.right == null
                || (root.val == root.right.val && IsUnivalTree(root.right)));

            return leftCorrect && rightCorrect;
        }
    }
}
