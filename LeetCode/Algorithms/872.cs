using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _872
	{
		public class TreeNode
		{
			public TreeNode(int val)
			{
				this.val = val;
			}

			public int val;

			public TreeNode left;

			public TreeNode right;
		}

		public static bool LeafSimilar(TreeNode root1, TreeNode root2)
		{
			var nodes1 = GetLeaves(root1);
			var nodes2 = GetLeaves(root2);

			if (nodes1.Length != nodes2.Length)
			{
				return false;
			}

			for (var i = 0; i < nodes1.Length; i++)
			{
				if (nodes1[i].val != nodes2[i].val)
				{
					return false;
				}
			}

			return true;
		}

		private static TreeNode[] GetLeaves(TreeNode root)
		{
			var result = new List<TreeNode>();

			var stack = new Stack<TreeNode>();
			stack.Push(root);

			while (stack.Count > 0)
			{
				var node = stack.Pop();

				if (node.left != null || node.right != null)
				{
					if (node.right != null)
					{
						stack.Push(node.right);
					}

					if (node.left != null)
					{
						stack.Push(node.left);
					}
				}
				else
				{
					result.Add(node);
				}
			}

			return result.ToArray();
		}
	}
}
