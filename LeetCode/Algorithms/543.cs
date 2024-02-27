using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _543
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

	private static int _diameter;

	public static int DiameterOfBinaryTree(TreeNode root)
	{
		MaxHeight(root);

		return _diameter;
	}

	private static int MaxHeight(TreeNode root)
	{
		if (root == null)
		{
			return 0;
		}

		var left = MaxHeight(root.left);
		var right = MaxHeight(root.right);
		_diameter = Math.Max(_diameter, left + right);

		return Math.Max(left, right) + 1;
	}
}