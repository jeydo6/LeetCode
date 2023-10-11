using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1319
{
	public static int MakeConnected(int n, int[][] connections)
	{
		if (connections.Length < n - 1)
		{
			return -1;
		}

		var graph = new List<int>[n];
		for (var i = 0; i < n; i++)
		{
			graph[i] = new List<int>();
		}

		for (var i = 0; i < connections.Length; i++)
		{
			graph[connections[i][0]].Add(connections[i][1]);
			graph[connections[i][1]].Add(connections[i][0]);
		}

		var components = 0;
		var visited = new bool[n];
		for (var i = 0;i < n; i++)
		{
			if (visited[i])
			{
				continue;
			}
			visited[i] = true;

			var queue = new Queue<int>();
			queue.Enqueue(i);
			while (queue.Count > 0)
			{
				var u = queue.Dequeue();
				foreach (var v in graph[u])
				{
					if (!visited[v])
					{
						visited[v] = true;
						queue.Enqueue(v);
					}
				}
			}

			components++;
		}
		return components - 1;
	}
}
