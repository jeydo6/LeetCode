using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _210
	{
		public static int[] FindOrder(int numCourses, int[][] prerequisites)
		{
			if (numCourses == 0)
			{
				return null;
			}

			var indegree = new int[numCourses];
			for (int i = 0; i < prerequisites.Length; i++)
			{
				indegree[prerequisites[i][0]]++;
			}

			var index = 0;
			var queue = new Queue<int>();
			var order = new int[numCourses];
			for (var i = 0; i < numCourses; i++)
			{
				if (indegree[i] == 0)
				{
					order[index++] = i;
					queue.Enqueue(i);
				}
			}

			while (queue.Count > 0)
			{
				var prerequisite = queue.Dequeue();
				for (var i = 0; i < prerequisites.Length; i++)
				{
					if (prerequisites[i][1] == prerequisite)
					{
						indegree[prerequisites[i][0]]--;
						if (indegree[prerequisites[i][0]] == 0)
						{
							order[index++] = prerequisites[i][0];
							queue.Enqueue(prerequisites[i][0]);
						}
					}
				}
			}

			return (index == numCourses) ? order : Array.Empty<int>();
		}
	}
}
