using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _538
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

		public static TreeNode ConvertBST(TreeNode root)
		{
			var stack = new Stack<TreeNode>();

			var sum = 0;
			var node = root;
			while (stack.Count > 0 || node != null)
			{
				while (node != null)
				{
					stack.Push(node);
					node = node.right;
				}

				node = stack.Pop();
				sum += node.val;
				node.val = sum;

				node = node.left;
			}

			return root;
		}
	}
}
