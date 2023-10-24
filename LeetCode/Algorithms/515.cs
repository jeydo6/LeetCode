using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _515
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

	public static IList<int> LargestValues(TreeNode root)
	{
		if (root == null)
		{
			return new List<int>();
		}

		var result = new List<int>();

		var stack = new Stack<(TreeNode Node, int Depth)>();
		stack.Push((root, 0));
		while (stack.Count > 0)
		{
			var (node, depth) = stack.Pop();
			if (depth == result.Count)
			{
				result.Add(node.val);
			}
			else if (node.val > result[depth])
			{
				result[depth] = node.val;
			}

			if (node.left != null)
			{
				stack.Push((node.left, depth + 1));
			}

			if (node.right != null)
			{
				stack.Push((node.right, depth + 1));
			}
		}

		return result;
	}
}
