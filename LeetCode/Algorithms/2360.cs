using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2360
{
	public static int LongestCycle(int[] edges)
	{
		var result = -1;
		var timeStep = 1;
		var visited = new int[edges.Length];
		for (var current = 0; current < edges.Length; current++)
		{
			if (visited[current] > 0)
			{
				continue;
			}

			var startTime = timeStep;
			var next = current;
			while (next != -1 && visited[next] == 0)
			{
				visited[next] = timeStep++;
				next = edges[next];
			}

			if (next != -1 && visited[next] >= startTime)
			{
				result = Math.Max(result, timeStep - visited[next]);
			}
		}

		return result;
	}
}
