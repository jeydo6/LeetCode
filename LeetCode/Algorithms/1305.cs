using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1305
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

		public static IList<int> GetAllElements(TreeNode root1, TreeNode root2)
		{
			var result = new List<int>();
			var stack1 = new Stack<TreeNode>();
			var stack2 = new Stack<TreeNode>();

			while (root1 != null || root2 != null || stack1.Count > 0 || stack2.Count > 0)
			{
				while (root1 != null)
				{
					stack1.Push(root1);
					root1 = root1.left;
				}
				while (root2 != null)
				{
					stack2.Push(root2);
					root2 = root2.left;
				}

				if (stack2.Count == 0 || (stack1.Count > 0 && stack1.Peek().val <= stack2.Peek().val))
				{
					root1 = stack1.Pop();
					result.Add(root1.val);
					root1 = root1.right;
				}
				else
				{
					root2 = stack2.Pop();
					result.Add(root2.val);
					root2 = root2.right;
				}
			}
			return result;
		}
	}
}
