using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _98
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

		public static bool IsValidBST(TreeNode root)
		{
			if (root == null)
			{
				return true;
			}
			
			TreeNode prev = null;
			var stack = new Stack<TreeNode>();
			while (stack.Count > 0 || root != null)
			{
				while (root != null)
				{
					stack.Push(root);
					root = root.left;
				}
				root = stack.Pop();
				if (prev != null && root.val <= prev.val)
				{
					return false;
				}
				prev = root;
				root = root.right;
			}
			return true;
		}
	}
}
