using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1026
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

	public static int MaxAncestorDiff(TreeNode root)
	{
		return MaxAncestorDiff(root, root.val, root.val);
	}

	private static int MaxAncestorDiff(TreeNode root, int min, int max)
	{
		if (root == null)
		{
			return max - min;
		}

		min = Math.Min(min, root.val);
		max = Math.Max(max, root.val);

		return Math.Max(
			MaxAncestorDiff(root.left, min, max),
			MaxAncestorDiff(root.right, min, max)
		);
	}
}
