using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1376
{
	public static int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
	{
		var graph = new List<int>[n];
		for (var i = 0; i < n; i++)
		{
			graph[i] = new List<int>();
		}
		for (int i = 0; i < n; i++)
		{
			if (manager[i] != -1)
			{
				graph[manager[i]].Add(i);
			}
		}

		var result = int.MinValue;

		var queue = new Queue<(int Parent, int Time)>();
		queue.Enqueue((headID, 0));
		while (queue.Count > 0)
		{
			var (parent, time) = queue.Dequeue();
			result = Math.Max(result, time);
			foreach (var child in graph[parent])
			{
				queue.Enqueue((child, time + informTime[parent]));
			}
		}

		return result;
	}
}
