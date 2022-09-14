using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1457
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

	public static int PseudoPalindromicPaths(TreeNode root)
	{
		var count = 0;

		var stack = new Stack<(TreeNode Node, int Path)>();
		stack.Push((root, 0));
		while (stack.Count > 0)
		{
			var (node, path) = stack.Pop();

			if (node != null)
			{
				path ^= (1 << node.val);

				if (node.left == null && node.right == null)
				{
					if ((path & (path - 1)) == 0)
					{
						++count;
					}
				}
				else
				{
					stack.Push((node.right, path));
					stack.Push((node.left, path));
				}
			}
		}

		return count;
	}
}
