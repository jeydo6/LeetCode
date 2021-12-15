using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _111
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

		public static int MinDepth(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}
			var left = MinDepth(root.left);
			var right = MinDepth(root.right);
			return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
		}
	}
}
