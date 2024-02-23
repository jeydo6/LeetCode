using System.Collections.Generic;

namespace LeetCode.Algorithms;

internal sealed class _787
{
	public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
	{
		var dict = new Dictionary<int, IList<int[]>>();
		for (var i = 0; i < flights.Length; i++)
		{
			if (!dict.ContainsKey(flights[i][0]))
			{
				dict[flights[i][0]] = new List<int[]>();
			}

			dict[flights[i][0]].Add(new int[] { flights[i][1], flights[i][2] });
		}

		var result = new int[n];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = int.MaxValue;
		}

		var stops = 0;
		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { src, 0 });
		while (stops <= k && queue.Count > 0)
		{
			var count = queue.Count;
			while (count-- > 0)
			{
				var current = queue.Dequeue();
				var node = current[0];
				var distance = current[1];

				if (!dict.ContainsKey(node))
				{
					continue;
				}

				foreach (var item in dict[node])
				{
					var neighbour = item[0];
					var price = item[1];
					if (price + distance >= result[neighbour])
					{
						continue;
					}
					result[neighbour] = price + distance;

					queue.Enqueue(new int[] { neighbour, result[neighbour] });
				}
			}
			stops++;
		}
		return result[dst] == int.MaxValue ? -1 : result[dst];
	}
}
