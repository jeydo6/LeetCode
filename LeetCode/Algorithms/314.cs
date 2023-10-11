using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _314
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

		public static IList<IList<int>> VerticalOrder(TreeNode root)
		{
			if (root == null)
			{
				return new List<IList<int>>();
			}

			var columns = new Dictionary<int, IList<int>>();
			var queue = new Queue<(TreeNode Node, int Column)>();
			queue.Enqueue((root, 0));

			var minColumn = 0;
			var maxColumn = 0;
			while (queue.Count > 0)
			{
				(var node, var column) = queue.Dequeue();
				if (node != null)
				{
					if (!columns.ContainsKey(column))
					{
						columns[column] = new List<int>();
					}
					columns[column].Add(node.val);
					minColumn = Math.Min(minColumn, column);
					maxColumn = Math.Max(maxColumn, column);

					queue.Enqueue((node.left, column - 1));
					queue.Enqueue((node.right, column + 1));
				}
			}

			var result = new List<IList<int>>();
			for (var i = minColumn; i <= maxColumn; i++)
			{
				result.Add(columns[i]);
			}
			return result;
		}
	}
}
