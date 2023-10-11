namespace LeetCode.Algorithms;

// MEDIUM
internal class _129
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

	public static int SumNumbers(TreeNode root, int sum = 0)
	{
		if (root == null)
		{
			return 0;
		}

		if (root.left == null && root.right == null)
		{
			return sum * 10 + root.val;
		}

		return SumNumbers(root.left, sum * 10 + root.val) + SumNumbers(root.right, sum * 10 + root.val);
	}
}
