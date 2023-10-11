using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1129
{
	public static int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
	{
		var adj = new Dictionary<int, IList<int[]>>();
		for (var i = 0; i < redEdges.Length; i++)
		{
			if (!adj.ContainsKey(redEdges[i][0]))
			{
				adj[redEdges[i][0]] = new List<int[]>();
			}
			adj[redEdges[i][0]].Add(new int[] { redEdges[i][1], 0 });
		}

		for (var i = 0; i < blueEdges.Length; i++)
		{
			if (!adj.ContainsKey(blueEdges[i][0]))
			{
				adj[blueEdges[i][0]] = new List<int[]>();
			}
			adj[blueEdges[i][0]].Add(new int[] { blueEdges[i][1], 1 });
		}

		var result = new int[n];
		var visited = new bool[n][];
		for (var i = 0; i < n; i++)
		{
			result[i] = -1;
			visited[i] = new bool[2];
		}

		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { 0, 0, -1 });
		
		result[0] = 0;
		visited[0][1] = true;
		visited[0][0] = true;
		while (queue.Count > 0)
		{
			var item = queue.Dequeue();
			var node = item[0];
			var steps = item[1];
			var prevColor = item[2];

			if (!adj.ContainsKey(node))
			{
				continue;
			}

			for (var i = 0; i < adj[node].Count; i++)
			{
				var neighbor = adj[node][i][0];
				var color = adj[node][i][1];
				if (!visited[neighbor][color] && color != prevColor)
				{
					if (result[neighbor] == -1)
					{
						result[neighbor] = 1 + steps;
					}

					visited[neighbor][color] = true;
					queue.Enqueue(new int[] { neighbor, 1 + steps, color });
				}
			}
		}

		return result;
	}
}
