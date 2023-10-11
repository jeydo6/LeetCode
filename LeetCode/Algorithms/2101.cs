using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2101
{
	public static int MaximumDetonation(int[][] bombs)
	{
		var graph = new Dictionary<int, List<int>>();
		for (var i = 0; i < bombs.Length; i++)
		{
			for (var j = 0; j < bombs.Length; j++)
			{
				var xi = (long)bombs[i][0];
				var yi = (long)bombs[i][1];
				var ri = (long)bombs[i][2];

				var xj = (long)bombs[j][0];
				var yj = (long)bombs[j][1];

				if (ri * ri >= (xi - xj) * (xi - xj) + (yi - yj) * (yi - yj))
				{
					graph.TryAdd(i, new List<int>());
					graph[i].Add(j);
				}
			}
		}

		var result = 0;
		for (var i = 0; i < bombs.Length; i++)
		{
			var visited = new HashSet<int> { i };
			var queue = new Queue<int>();
			queue.Enqueue(i);
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				if (graph.ContainsKey(current))
				{
					foreach (var neighbor in graph[current])
					{
						if (!visited.Contains(neighbor))
						{
							visited.Add(neighbor);
							queue.Enqueue(neighbor);
						}
					}
				}
			}
			result = Math.Max(result, visited.Count);
		}

		return result;
	}
}
