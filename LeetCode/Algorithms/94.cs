using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _94
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

	public static IList<int> InorderTraversal(TreeNode root)
	{
		var result = new List<int>();

		var stack = new Stack<TreeNode>();
		var node = root;
		while (node != null || stack.Count > 0)
		{
			while (node != null)
			{
				stack.Push(node);
				node = node.left;
			}

			node = stack.Pop();
			result.Add(node.val);
			node = node.right;
		}

		return result;
	}
}
