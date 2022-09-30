using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _218
{
	public static IList<IList<int>> GetSkyline(int[][] buildings)
	{
		var edges = new List<IList<int>>();
		for (var i = 0; i < buildings.Length; i++)
		{
			edges.Add(new List<int> { buildings[i][0], buildings[i][2] });
			edges.Add(new List<int> { buildings[i][1], -buildings[i][2] });
		}
		edges.Sort((a, b) => a[0] - b[0]);

		var live = new PriorityQueue<int, int>();
		var past = new PriorityQueue<int, int>();

		var result = new List<IList<int>>();

		var index = 0;
		while (index < edges.Count)
		{
			var currentX = edges[index][0];

			while (index < edges.Count && edges[index][0] == currentX)
			{
				var height = edges[index][1];
				if (height > 0)
				{
					live.Enqueue(height, height);
				}
				else
				{
					past.Enqueue(-height, -height);
				}
				index++;
			}

			while (past.Count > 0 && live.Peek() == past.Peek())
			{
				live.Dequeue();
				past.Dequeue();
			}

			var currentHeight = live.Count == 0 ? 0 : live.Peek();

			if (result.Count == 0 || result[^1][1] != currentHeight)
			{
				result.Add(new List<int> { currentX, currentHeight });
			}
		}

		return result;
	}
}
