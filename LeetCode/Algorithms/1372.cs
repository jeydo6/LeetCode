using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1372
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

	public static int LongestZigZag(TreeNode root)
	{
		var result = 0;
		LongestZigZag(root, false, 0, ref result);
		LongestZigZag(root, true, 0, ref result);
		return result;
	}

	private static void LongestZigZag(TreeNode node, bool goLeft, int steps, ref int result)
	{
		if (node == null)
		{
			return;
		}

		result = Math.Max(result, steps);
		if (goLeft)
		{
			LongestZigZag(node.left, !goLeft, steps + 1, ref result);
			LongestZigZag(node.right, goLeft, 1, ref result);
		}
		else
		{
			LongestZigZag(node.left, goLeft, 1, ref result);
			LongestZigZag(node.right, !goLeft, steps + 1, ref result);
		}
	}
}
