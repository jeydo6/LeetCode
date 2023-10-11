using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _99
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

		public static void RecoverTree(TreeNode root)
		{
			var stack = new Stack<TreeNode>();
			TreeNode x = null;
			TreeNode y = null;

			TreeNode predecessor = null;
			while (stack.Count > 0 || root != null)
			{
				while (root != null)
				{
					stack.Push(root);
					root = root.left;
				}
				
				root = stack.Pop();
				if (predecessor != null && root.val < predecessor.val)
				{
					y = root;
					if (x == null)
					{
						x = predecessor;
					}
					else
					{
						break;
					}
				}
				predecessor = root;
				root = root.right;
			}

			(y.val, x.val) = (x.val, y.val);
		}
	}
}
