using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2359
{
	public static int ClosestMeetingNode(int[] edges, int node1, int node2)
	{
		var dist1 = ClosestMeetingNode(edges, node1);
		var dist2 = ClosestMeetingNode(edges, node2);

		var result = -1;
		var minDistance = int.MaxValue;
		for (var current = 0; current < edges.Length; current++)
		{
			if (minDistance > Math.Max(dist1[current], dist2[current]))
			{
				result = current;
				minDistance = Math.Max(dist1[current], dist2[current]);
			}
		}

		return result;
	}

	public static int[] ClosestMeetingNode(int[] edges, int node)
	{
		var distances = new int[edges.Length];
		for (var i = 0; i < distances.Length; i++)
		{
			distances[i] = int.MaxValue;
		}

		var visited = new bool[edges.Length];
		distances[node] = 0;

		var queue = new Queue<int>();
		queue.Enqueue(node);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();

			if (visited[current])
			{
				continue;
			}
			visited[current] = true;

			var neighbor = edges[current];
			if (neighbor != -1 && !visited[neighbor])
			{
				distances[neighbor] = 1 + distances[current];
				queue.Enqueue(neighbor);
			}
		}

		return distances;
	}
}
