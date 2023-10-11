using System;

namespace LeetCode.Algorithms;

// HARD
internal class _124
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

	private static int _result = int.MinValue;

	public static int MaxPathSum(TreeNode root)
	{
		GetMaxPathSum(root);
		return _result;
	}

	private static int GetMaxPathSum(TreeNode root)
	{
		if (root == null)
		{
			return 0;
		}

		var left = Math.Max(GetMaxPathSum(root.left), 0);
		var right = Math.Max(GetMaxPathSum(root.right), 0);

		_result = Math.Max(_result, left + right + root.val);

		return Math.Max(left + root.val, right + root.val);
	}
}
