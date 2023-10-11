using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _662
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

		public static int WidthOfBinaryTree(TreeNode root)
		{
			return WidthOfBinaryTree(root, 0, 1, new List<int>(), new List<int>());
		}

		public static int WidthOfBinaryTree(TreeNode root, int level, int order, IList<int> start, List<int> end)
		{
			if (root == null)
			{
				return 0;
			}

			if (start.Count == level)
			{
				start.Add(order);
				end.Add(order);
			}
			else
			{
				end.Insert(level, order);
			}
			var current = end[level] - start[level] + 1;
			var left = WidthOfBinaryTree(root.left, level + 1, 2 * order, start, end);
			var right = WidthOfBinaryTree(root.right, level + 1, 2 * order + 1, start, end);
			return Math.Max(current, Math.Max(left, right));
		}
	}
}
