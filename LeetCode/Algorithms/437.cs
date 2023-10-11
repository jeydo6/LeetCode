namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _437
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

		public static int PathSum(TreeNode root, int targetSum)
		{
			if (root == null)
			{
				return 0;
			}

			return PathSum(root.left, targetSum) + PathSum(root.right, targetSum) + PathSum(root, targetSum, 0);
		}

		private static int PathSum(TreeNode root, int targetSum, int current)
		{
			if (root == null)
			{
				return 0;
			}

			current += root.val;

			return (current == targetSum ? 1 : 0) + PathSum(root.left, targetSum, current) + PathSum(root.right, targetSum, current);
		}
	}
}