using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _783
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

	public static int MinDiffInBST(TreeNode root)
	{
		var nodes = new List<int>();
		MinDiffInBST(root, nodes);

		var result = int.MaxValue;
		for (var i = 1; i < nodes.Count; i++)
		{
			result = Math.Min(result, nodes[i] - nodes[i - 1]);
		}

		return result;
	}

	private static void MinDiffInBST(TreeNode root, IList<int> nodes)
	{
		if (root == null)
		{
			return;
		}

		MinDiffInBST(root.left, nodes);
		nodes.Add(root.val);
		MinDiffInBST(root.right, nodes);
	}
}
