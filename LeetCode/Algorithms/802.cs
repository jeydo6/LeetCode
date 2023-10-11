using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _802
{
	public static IList<int> EventualSafeNodes(int[][] graph)
	{
		var n = graph.Length;
		var arr = new int[n];
		var adj = new IList<int>[n];
		for (var i = 0; i < n; i++)
		{
			adj[i] = new List<int>();
		}

		for (var i = 0; i < n; i++)
		{
			foreach (var node in graph[i])
			{
				adj[node].Add(i);
				arr[i]++;
			}
		}

		var queue = new Queue<int>();
		for (var i = 0; i < n; i++)
		{
			if (arr[i] == 0)
			{
				queue.Enqueue(i);
			}
		}

		var isSafe = new bool[n];
		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			isSafe[node] = true;

			foreach (var neighbor in adj[node])
			{
				arr[neighbor]--;
				if (arr[neighbor] == 0)
				{
					queue.Enqueue(neighbor);
				}
			}
		}

		var result = new List<int>();
		for (var i = 0; i < n; i++)
		{
			if (isSafe[i])
			{
				result.Add(i);
			}
		}

		return result;
	}
}