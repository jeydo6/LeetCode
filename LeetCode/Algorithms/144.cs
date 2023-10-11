using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _144
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

		public static IList<int> PreorderTraversal(TreeNode node)
		{
			var list = new List<int>();
			var stack = new Stack<TreeNode>();
			while (node != null || stack.Count > 0)
			{
				if (node != null)
				{
					list.Add(node.val);
					stack.Push(node);
					node = node.left;
				}
				else
				{
					var temp = stack.Pop();
					node = temp.right;
				}
			}
			return list;
		}
	}
}
