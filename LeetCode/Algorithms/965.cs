namespace Leetcode.Algorithms
{
	// EASY
	internal class _965
	{
		public class TreeNode
		{
			public TreeNode(int val)
			{
				this.val = val;
			}

			public int val;
			public TreeNode left;
			public TreeNode right;
		}

		public static bool IsUnivalTree(TreeNode root)
		{
			var leftCorrect = root.left == null || (root.val == root.left.val && IsUnivalTree(root.left));

			var rightCorrect = root.right == null || (root.val == root.right.val && IsUnivalTree(root.right));

			return leftCorrect && rightCorrect;
		}
	}
}
