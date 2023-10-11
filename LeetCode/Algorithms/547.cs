using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _547
{
	public static int FindCircleNum(int[][] isConnected)
	{
		var result = 0;
		var visited = new bool[isConnected.Length];

		for (var i = 0; i < visited.Length; i++)
		{
			if (!visited[i])
			{
				result++;

				var queue = new Queue<int>();
				queue.Enqueue(i);
				visited[i] = true;

				while (queue.Count > 0)
				{
					var node = queue.Dequeue();
					for (var j = 0; j < isConnected.Length; j++)
					{
						if (isConnected[node][j] == 1 && !visited[j])
						{
							queue.Enqueue(j);
							visited[j] = true;
						}
					}
				}
			}
		}

		return result;
	}
}
