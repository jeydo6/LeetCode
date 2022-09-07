using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms;

// EASY
internal class _606
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

	public static string Tree2str(TreeNode root)
	{
		if (root == null)
		{
			return string.Empty;
		}

		var stack = new Stack<TreeNode>();
		stack.Push(root);
		var visited = new HashSet<TreeNode>();

		var sb = new StringBuilder();
		while (stack.Count > 0)
		{
			var node = stack.Peek();

			if (visited.Contains(node))
			{
				stack.Pop();
				sb.Append(')');
			}
			else
			{
				visited.Add(node);
				sb.Append("(" + node.val);

				if (node.left == null && node.right != null)
				{
					sb.Append("()");
				}

				if (node.right != null)
				{
					stack.Push(node.right);
				}

				if (node.left != null)
				{
					stack.Push(node.left);
				}
			}
		}

		return sb.ToString()[1..(sb.Length - 1)];
	}
}
