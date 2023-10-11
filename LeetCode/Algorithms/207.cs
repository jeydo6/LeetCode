using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _207
{
	public static bool CanFinish(int numCourses, int[][] prerequisites)
	{
		var courses = new int[numCourses];
		var graph = new IList<int>[numCourses];
		for (var i = 0; i < numCourses; i++)
		{
			graph[i] = new List<int>();
		}

		foreach (var prerequisite in prerequisites)
		{
			graph[prerequisite[1]].Add(prerequisite[0]);
			courses[prerequisite[0]]++;
		}

		var queue = new Queue<int>();
		for (var i = 0; i < numCourses; i++)
		{
			if (courses[i] == 0) {
				queue.Enqueue(i);
			}
		}

		var visited = 0;
		while (queue.Count > 0)
		{
			var node = queue.Dequeue();
			visited++;

			foreach (var neighbor in graph[node])
			{
				courses[neighbor]--;
				if (courses[neighbor] == 0) {
					queue.Enqueue(neighbor);
				}
			}
		}

		return visited == numCourses;
	}
}