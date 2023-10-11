using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2477
{
	public static long MinimumFuelCost(int[][] roads, int seats)
	{
		var adj = new Dictionary<int, IList<int>>();
		var degree = new int[roads.Length + 1];

		for (var i = 0; i < roads.Length; i++)
		{
			if (!adj.ContainsKey(roads[i][0]))
			{
				adj[roads[i][0]] = new List<int>();
			}
			adj[roads[i][0]].Add(roads[i][1]);
			degree[roads[i][0]]++;

			if (!adj.ContainsKey(roads[i][1]))
			{
				adj[roads[i][1]] = new List<int>();
			}
			adj[roads[i][1]].Add(roads[i][0]);
			degree[roads[i][1]]++;
		}

		var queue = new Queue<int>();
		for (var i = 1; i < roads.Length + 1; i++)
		{
			if (degree[i] == 1)
			{
				queue.Enqueue(i);
			}
		}

		var representatives = new int[roads.Length + 1];
		for (var i = 0; i < representatives.Length; i++)
		{
			representatives[i] = 1;
		}

		var result = 0.0;
		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			result += Math.Ceiling((double)representatives[node] / seats);

			foreach (var neighbor in adj[node])
			{
				degree[neighbor]--;
				representatives[neighbor] += representatives[node];
				if (degree[neighbor] == 1 && neighbor != 0)
				{
					queue.Enqueue(neighbor);
				}
			}
		}
		return (long)result;
	}
}
