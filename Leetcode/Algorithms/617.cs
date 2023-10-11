using System;

public class _617
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

    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if (t1 == null && t2 == null)
        {
            return null;
        }

        if (t1 == null)
        {
            t1 = new TreeNode(0);
        }
        if (t2 == null)
        {
            t2 = new TreeNode(0);
        }

        TreeNode result = new TreeNode(t1.val + t2.val);

        if (t1.left != null || t2.left != null)
        {
            result.left = MergeTrees(t1.left, t2.left);
        }

        if (t1.right != null || t2.right != null)
        {
            result.right = MergeTrees(t1.right, t2.right);
        }

        return result;
    }
}