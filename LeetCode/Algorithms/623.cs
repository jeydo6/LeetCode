using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _623
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

	public static TreeNode AddOneRow(TreeNode root, int val, int depth)
	{
		if (depth == 1)
		{
			return new TreeNode(val)
			{
				left = root
			};
		}

		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		var currentDepth = 1;
		while (currentDepth < depth - 1)
		{
			var temp = new Queue<TreeNode>();
			while (queue.Count > 0)
			{
				var node = queue.Dequeue();
				if (node.left != null)
				{
					temp.Enqueue(node.left);
				}

				if (node.right != null)
				{
					temp.Enqueue(node.right);
				}
			}
			queue = temp;
			currentDepth++;
		}

		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			node.left = new TreeNode(val)
			{
				left = node.left
			};
			node.right = new TreeNode(val)
			{
				right = node.right
			};
		}

		return root;
	}
}
