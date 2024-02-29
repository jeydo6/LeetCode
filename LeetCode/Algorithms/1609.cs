using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1609
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

	public static bool IsEvenOddTree(TreeNode root)
	{
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		var isEven = true;
		while (queue.Count > 0)
		{
			var size = queue.Count;
			var prev = isEven ? int.MinValue : int.MaxValue;
			while (size > 0)
			{
				var current = queue.Dequeue();
				if ((isEven && (current.val % 2 == 0 || current.val <= prev)) ||
				    (!isEven && (current.val % 2 == 1 || current.val >= prev)))
				{
					return false;
				}

				prev = current.val;
				if (current.left != null)
				{
					queue.Enqueue(current.left);
				}

				if (current.right != null)
				{
					queue.Enqueue(current.right);
				}

				size--;
			}

			isEven = !isEven;
		}

		return true;
	}
}