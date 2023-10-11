using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _839
{
	public static int NumSimilarGroups(string[] strs)
	{
		var graph = new Dictionary<int, IList<int>>();
		for (var i = 0; i < strs.Length; i++)
		{
			for (var j = i + 1; j < strs.Length; j++)
			{
				if (IsSimilar(strs[i], strs[j]))
				{
					if (!graph.ContainsKey(i))
					{
						graph[i] = new List<int>();
					}
					graph[i].Add(j);

					if (!graph.ContainsKey(j))
					{
						graph[j] = new List<int>();
					}
					graph[j].Add(i);
				}
			}
		}

		var result = 0;
		var visited = new bool[strs.Length];
		for (var i = 0; i < visited.Length; i++)
		{
			if (!visited[i])
			{
				var queue = new Queue<int>();
				queue.Enqueue(i);

				visited[i] = true;
				while (queue.Count > 0)
				{
					var j = queue.Dequeue();
					if (!graph.ContainsKey(j))
					{
						continue;
					}

					foreach (var neighbor in graph[j])
					{
						if (!visited[neighbor])
						{
							visited[neighbor] = true;
							queue.Enqueue(neighbor);
						}
					}
				}
				result++;
			}
		}

		return result;
	}

	private static bool IsSimilar(string str1, string str2)
	{
		var diff = 0;
		for (var i = 0; i < str1.Length; i++)
		{
			if (str1[i] != str2[i])
			{
				diff++;
			}
		}
		return diff is 0 or 2;
	}
}
