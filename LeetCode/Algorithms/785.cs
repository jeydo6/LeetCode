using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _785
{
	public static bool IsBipartite(int[][] graph)
	{
		var color = new int[graph.Length];
		for (var i = 0; i < graph.Length; i++)
		{
			color[i] = -1;
		}

		for (var i = 0; i < graph.Length; ++i)
		{
			if (color[i] == -1)
			{
				var stack = new Stack<int>();
				stack.Push(i);
				color[i] = 0;

				while (stack.Count > 0)
				{
					var node = stack.Pop();
					var neighbours = graph[node];
					for (var j = 0; j < neighbours.Length; j++)
					{
						var neighbour = neighbours[j];
						if (color[neighbour] == -1)
						{
							stack.Push(neighbour);
							color[neighbour] = color[node] ^ 1;
						}
						else if (color[neighbour] == color[node])
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}
}
