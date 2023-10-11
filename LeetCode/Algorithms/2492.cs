using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2492
{
	public static int MinScore(int n, int[][] roads)
	{
		var graph = new Dictionary<int, IDictionary<int, int>>();
		for (var i = 0; i < roads.Length; i++)
		{
			if (!graph.ContainsKey(roads[i][0]))
			{
				graph[roads[i][0]] = new Dictionary<int, int>();
			}
			graph[roads[i][0]][roads[i][1]] = roads[i][2];

			if (!graph.ContainsKey(roads[i][1]))
			{
				graph[roads[i][1]] = new Dictionary<int, int>();
			}
			graph[roads[i][1]][roads[i][0]] = roads[i][2];
		}

		var visited = new HashSet<int>();
		var queue = new Queue<int>();
		queue.Enqueue(1);

		var result = int.MaxValue;
		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			foreach (var (adj, score) in graph[node])
			{
				if (!visited.Contains(adj))
				{
					queue.Enqueue(adj);
					visited.Add(adj);
				}

				if (score < result)
				{
					result = score;
				}
			}
		}
		return result;
	}
}
