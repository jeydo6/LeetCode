using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _145
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

		public static IList<int> PostorderTraversal(TreeNode node)
		{
			var list = new List<int>();
			var stack = new Stack<TreeNode>();
			while (node != null || stack.Count > 0)
			{
				if (node != null)
				{
					list.Insert(0, node.val);
					stack.Push(node.left);
					node = node.right;
				}
				else
				{
					node = stack.Pop();
				}
			}
			return list;
		}
	}
}
