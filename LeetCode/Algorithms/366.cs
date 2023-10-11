using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _366
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

		public static IList<IList<int>> FindLeaves(TreeNode root)
		{
			var list = new List<IList<int>>();

			GetHeight(root, list);

			return list;
		}

		private static int GetHeight(TreeNode root, IList<IList<int>> list)
		{
			if (root == null)
			{
				return -1;
			}

			var currentHeight = Math.Max(
				GetHeight(root.left, list),
				GetHeight(root.right, list)
			) + 1;

			if (list.Count == currentHeight)
			{
				list.Add(new List<int>());
			}

			list[currentHeight].Add(root.val);

			return currentHeight;
		}
	}
}
