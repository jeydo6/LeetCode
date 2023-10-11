using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _337
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

			public static int Rob(TreeNode root)
			{
				var result = RobRecursive(root);

				return Math.Max(result[0], result[1]);
			}

			private static int[] RobRecursive(TreeNode root)
			{
				if (root == null)
				{
					return new int[2];
				}

				var left = RobRecursive(root.left);
				var right = RobRecursive(root.right);

				var result = new int[2];
				result[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
				result[1] = root.val + left[0] + right[0];

				return result;
			}
		}
	}
}
