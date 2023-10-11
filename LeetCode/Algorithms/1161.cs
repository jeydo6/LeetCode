using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1161
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

	public static int MaxLevelSum(TreeNode root)
	{
		var result = 0;

		var level = 0;
		var maxSum = int.MinValue;

		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);
		while (queue.Count > 0)
		{
			level++;

			var currentSum = 0;
			for (var size = queue.Count; size > 0; size--)
			{
				var node = queue.Dequeue();
				currentSum += node.val;

				if (node.left != null)
				{
					queue.Enqueue(node.left);
				}

				if (node.right != null)
				{
					queue.Enqueue(node.right);
				}
			}

			if (maxSum < currentSum)
			{
				maxSum = currentSum;
				result = level;
			}
		}

		return result;
	}
}