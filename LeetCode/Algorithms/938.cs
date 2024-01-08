using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _938
{
	public class TreeNode
	{
		public TreeNode(int value)
		{
			val = value;
		}

		public TreeNode(int value, TreeNode left, TreeNode right)
		{
			val = value;
			this.left = left;
			this.right = right;
		}

		public int val;

		public TreeNode left;

		public TreeNode right;
	}

	public static int RangeSumBST(TreeNode root, int low, int high)
	{
		var result = 0;

		var stack = new Stack<TreeNode>();
		stack.Push(root);

		while (stack.Count > 0)
		{
			var node = stack.Pop();
			if (node != null)
			{
				if (node.val >= low && node.val <= high)
				{
					result += node.val;
				}

				if (node.val > low)
				{
					stack.Push(node.left);
				}

				if (node.val < high)
				{
					stack.Push(node.right);
				}
			}
		}

		return result;
	}
}
