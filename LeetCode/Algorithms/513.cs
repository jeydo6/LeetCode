using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _513
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

	public int FindBottomLeftValue(TreeNode root)
	{
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		var current = root;
		while (queue.Count > 0)
		{
			current = queue.Dequeue();
			if (current.right != null)
			{
				queue.Enqueue(current.right);
			}
			if (current.left != null) {
				queue.Enqueue(current.left);
			}
		}
		return current.val;
	}
}