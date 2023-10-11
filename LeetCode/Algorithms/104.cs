using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _104
	{
		public class TreeNode
		{
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}

			public int val;

			public TreeNode left;

			public TreeNode right;
		}

		public static int MaxDepth(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			var depth = 0;
			var path = new Stack<TreeNode>();

			var stack = new Stack<TreeNode>();
			stack.Push(root);
			while (stack.Count > 0)
			{
				var node = stack.Peek();
				if (path.Count > 0 && node == path.Peek())
				{
					if (path.Count > depth)
					{
						depth = path.Count;
					}

					path.Pop();
					stack.Pop();
				}
				else
				{
					path.Push(node);
					if (node.left != null)
					{
						stack.Push(node.left);
					}
					if (node.right != null)
					{
						stack.Push(node.right);
					}
				}
			}

			return depth;
		}
	}
}
