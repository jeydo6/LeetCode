using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2385
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

	public static int AmountOfTime(TreeNode root, int start)
	{
		var graph = GetGraph(root);
		return GetAmountOfTime(graph, start);
	}

	private static IReadOnlyDictionary<int, ISet<int>> GetGraph(TreeNode root)
	{
		var graph = new Dictionary<int, ISet<int>>();
		if (root is null)
			return graph;

		var queue = new Queue<(TreeNode Node, int Parent)>();
		queue.Enqueue((root, 0));
		while (queue.Count > 0)
		{
			var (node, parent) = queue.Dequeue();
			if (node is null) continue;

			graph.TryAdd(node.val, new HashSet<int>());

			if (parent > 0)
			{
				graph[node.val].Add(parent);
			}

			if (node.left is not null)
			{
				graph[node.val].Add(node.left.val);
			}
			queue.Enqueue((node.left, node.val));

			if (node.right is not null)
			{
				graph[node.val].Add(node.right.val);
			}
			queue.Enqueue((node.right, node.val));
		}

		return graph;
	}

	private static int GetAmountOfTime(IReadOnlyDictionary<int, ISet<int>> graph, int start)
	{
		var visited = new HashSet<int> { start };

		var queue = new Queue<int>(); 
		queue.Enqueue(start);

		var minute = 0;
		while (queue.Count > 0)
		{
			var count = queue.Count;
			while (count > 0)
			{
				var current = queue.Dequeue();
				foreach (var val in graph[current])
				{
					if (visited.Add(val))
					{
						queue.Enqueue(val);
					}
				}
				count--;
			}
			minute++;
		}
		return minute - 1;
	}
}