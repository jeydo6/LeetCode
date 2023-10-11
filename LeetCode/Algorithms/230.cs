using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _230
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

		public static int KthSmallest(TreeNode root, int k)
		{
			var stack = new Stack<TreeNode>();
			while (true)
			{
				while (root != null)
				{
					stack.Push(root);
					root = root.left;
				}
				root = stack.Pop();
				if (--k == 0)
				{
					return root.val;
				}
				root = root.right;
			}
		}
	}
}
