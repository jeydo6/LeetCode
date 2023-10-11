using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _530
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

	private static readonly IList<int> _nodes = new List<int>();

	public static int GetMinimumDifference(TreeNode root)
	{
		InorderTraversal(root);

		var result = int.MaxValue;
		for (var i = 1; i < _nodes.Count; i++)
		{
			result = Math.Min(result, _nodes[i] - _nodes[i - 1]);
		}

		return result;
	}

	private static void InorderTraversal(TreeNode root)
	{
		if (root is null)
			return;

		InorderTraversal(root.left);
		_nodes.Add(root.val);
		InorderTraversal(root.right);
	}
}