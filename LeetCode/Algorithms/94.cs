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

	public static IList<int> InorderTraversal(TreeNode node)
	{
		var list = new List<int>();
		var stack = new Stack<TreeNode>();
		while (node != null || stack.Count > 0)
		{
			if (node != null)
			{
				stack.Push(node);
				node = node.left;
			}
			else
			{
				var temp = stack.Pop();
				list.Add(temp.val);
				node = temp.right;
			}
		}
		return list;
	}
}
