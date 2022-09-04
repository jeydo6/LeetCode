using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _987
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

		public static IList<IList<int>> VerticalTraversal(TreeNode root)
		{
			var result = new List<IList<int>>();

			if (root == null)
			{
				return result;
			}

			var nodes = BFS(root);
			Array.Sort(nodes, (t1, t2) =>
			{
				if (t1.Item1 == t2.Item1)
				{
					if (t1.Item2 == t2.Item2)
					{
						return t1.Item3 - t2.Item3;
					}
					else
					{
						return t1.Item2 - t2.Item2;
					}
				}
				else
				{
					return t1.Item1 - t2.Item1;
				}
			});

			var currentColumn = new List<int>();
			var currentColumnIndex = nodes[0].Column;
			for (var i = 0; i < nodes.Length; i++)
			{
				var (column, _ , value) = nodes[i];

				if (column == currentColumnIndex)
				{
					currentColumn.Add(value);
				}
				else
				{
					result.Add(currentColumn);
					
					currentColumnIndex = column;

					currentColumn = new List<int>();
					currentColumn.Add(value);
				}
			}
			result.Add(currentColumn);

			return result;
		}

		private static (int Column, int Row, int Value)[] BFS(TreeNode root)
		{
			var result = new List<(int, int, int)>();
			var queue = new Queue<(TreeNode Node, int Row, int Column)>();
			queue.Enqueue((root, 0, 0));

			while (queue.Count > 0)
			{
				var (node, row, column) = queue.Dequeue();
				if (node != null)
				{
					result.Add((column, row, node.val));

					queue.Enqueue((node.left, row + 1, column - 1));
					queue.Enqueue((node.right, row + 1, column + 1));
				}
			}

			return result.ToArray();
		}
	}
}
