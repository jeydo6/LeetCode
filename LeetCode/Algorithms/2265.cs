namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2265
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static int AverageOfSubtree(TreeNode root)
    {
        var count = 0;
        PostOrder(root, ref count);

        return count;
    }

    private static (int Sum, int Count) PostOrder(TreeNode root, ref int count)
    {
        if (root == null)
        {
            return (0, 0);
        }

        var left = PostOrder(root.left, ref count);
        var right = PostOrder(root.right, ref count);

        var nodeSum = left.Sum + right.Sum + root.val;
        var nodeCount = left.Count + right.Count + 1;

        if (root.val == nodeSum / nodeCount)
        {
            count++;
        }

        return (nodeSum, nodeCount);
    }
}