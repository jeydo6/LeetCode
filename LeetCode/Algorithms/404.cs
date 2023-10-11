using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _404
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

		public static int SumOfLeftLeaves(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			var result = 0;

			var stack = new Stack<TreeNode>();

			stack.Push(root);
			while (stack.Count > 0)
			{
				var node = stack.Pop();
				if (node.left != null)
				{
					if (node.left.left == null && node.left.right == null)
					{
						result += node.left.val;
					}
					else
					{
						stack.Push(node.left);
					}
				}
				if (node.right != null)
				{
					if (node.right.left != null || node.right.right != null)
					{
						stack.Push(node.right);
					}
				}
			}

			return result;
		}
	}
}
