using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1857
{
	public static int LargestPathValue(string colors, int[][] edges)
	{
		var graph = new Dictionary<int, IList<int>>();
		var graphCounts = new int[colors.Length];

		for (var i = 0; i < edges.Length; i++)
		{
			if (!graph.ContainsKey(edges[i][0]))
			{
				graph[edges[i][0]] = new List<int>();
			}

			graph[edges[i][0]].Add(edges[i][1]);
			graphCounts[edges[i][1]]++;
		}

		var colorCounts = new int[colors.Length][];
		for (var i = 0; i < colorCounts.Length; i++)
		{
			colorCounts[i] = new int[26];
		}

		var queue = new Queue<int>();
		for (var i = 0; i < graphCounts.Length; i++)
		{
			if (graphCounts[i] == 0)
			{
				queue.Enqueue(i);
			}
		}

		var result = 1;
		var visited = 0;
		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			if (++colorCounts[node][colors[node] - 'a'] > result)
			{
				result = colorCounts[node][colors[node] - 'a'];
			}
			visited++;

			if (!graph.ContainsKey(node))
			{
				continue;
			}

			foreach (var neighbor in graph[node])
			{
				for (var i = 0; i < 26; i++)
				{
					if (colorCounts[node][i] > colorCounts[neighbor][i])
					{
						colorCounts[neighbor][i] = colorCounts[node][i];
					}
				}

				graphCounts[neighbor]--;
				if (graphCounts[neighbor] == 0)
				{
					queue.Enqueue(neighbor);
				}
			}
		}

		return visited < colorCounts.Length ? -1 : result;
	}
}
