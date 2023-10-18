using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2050
{
	public static int MinimumTime(int n, int[][] relations, int[] time)
	{
		var graph = new IList<int>[n];
		for (var i = 0; i < n; i++)
		{
			graph[i] = new List<int>();
		}

		var indegree = new int[n];
		for (var i = 0; i < relations.Length; i++)
		{
			var x = relations[i][0] - 1;
			var y = relations[i][1] - 1;
			graph[x].Add(y);
			indegree[y]++;
		}

		var queue = new Queue<int>();
		var maxTime = new int[n];
		for (var node = 0; node < n; node++)
		{
			if (indegree[node] == 0)
			{
				queue.Enqueue(node);
				maxTime[node] = time[node];
			}
		}

		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			foreach (var neighbor in graph[node])
			{
				maxTime[neighbor] = Math.Max(maxTime[neighbor], maxTime[node] + time[neighbor]);
				indegree[neighbor]--;
				if (indegree[neighbor] == 0)
				{
					queue.Enqueue(neighbor);
				}
			}
		}

		var result = 0;
		for (var node = 0; node < n; node++)
		{
			result = Math.Max(result, maxTime[node]);
		}

		return result;
	}
}
