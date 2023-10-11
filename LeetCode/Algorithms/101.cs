using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _101
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

	public static bool IsSymmetric(TreeNode root)
	{
		if (root == null)
		{
			return true;
		}

		var stack = new Stack<TreeNode>();
		if (root.left != null)
		{
			if (root.right == null)
			{
				return false;
			}
			stack.Push(root.left);
			stack.Push(root.right);
		}
		else if (root.right != null)
		{
			return false;
		}

		while (stack.Count > 0)
		{
			if (stack.Count % 2 != 0)
			{
				return false;
			}
			var right = stack.Pop();
			var left = stack.Pop();
			if (right.val != left.val)
			{
				return false;
			}

			if (left.left != null)
			{
				if (right.right == null)
				{
					return false;
				}

				stack.Push(left.left);
				stack.Push(right.right);
			}
			else if (right.right != null)
			{
				return false;
			}

			if (left.right != null)
			{
				if (right.left == null)
				{
					return false;
				}

				stack.Push(left.right);
				stack.Push(right.left);
			}
			else if (right.left != null)
			{
				return false;
			}
		}

		return true;
	}
}
