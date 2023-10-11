using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _549
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

		private static int _maxVal;

		public static int LongestConsecutive(TreeNode root)
		{
			DFS(root);
			return _maxVal;
		}

		public static int[] DFS(TreeNode root)
		{
			if (root == null)
			{
				return new int[] { 0, 0 };
			}

			var inc = 1;
			var dcr = 1;
			if (root.left != null)
			{
				var left = DFS(root.left);
				if (root.val == root.left.val + 1)
				{
					dcr = left[1] + 1;
				}
				else if (root.val == root.left.val - 1)
				{
					inc = left[0] + 1;
				}
			}

			if (root.right != null)
			{
				var right = DFS(root.right);
				if (root.val == root.right.val + 1)
				{
					dcr = Math.Max(dcr, right[1] + 1);
				}
				else if (root.val == root.right.val - 1)
				{
					inc = Math.Max(inc, right[0] + 1);
				}
			}

			_maxVal = Math.Max(_maxVal, dcr + inc - 1);

			return new int[] { inc, dcr };
		}
	}
}
