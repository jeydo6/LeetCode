using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2462
{
	public static long TotalCost(int[] costs, int k, int candidates)
	{
		var comparer = Comparer<int[]>.Create((a, b) =>
			a[0] != b[0] ? a[0] - b[0] : a[1] - b[1]
		);
		var pQueue = new PriorityQueue<int[], int[]>(comparer);

		for (var i = 0; i < candidates; i++)
		{
			var item = new int[] { costs[i], 0 };
			pQueue.Enqueue(item, item);
		}

		for (var i = Math.Max(candidates, costs.Length - candidates); i < costs.Length; i++)
		{
			var item = new int[] { costs[i], 1 };
			pQueue.Enqueue(item, item);
		}

		var result = 0L;
		var nextHead = candidates;
		var nextTail = costs.Length - 1 - candidates;

		for (var i = 0; i < k; i++)
		{
			var currentWorker = pQueue.Dequeue();
			var currentCost = currentWorker[0];
			var currentSectionId = currentWorker[1];
			result += currentCost;

			if (nextHead <= nextTail)
			{
				if (currentSectionId == 0)
				{
					var item = new int[] { costs[nextHead], 0 };
					pQueue.Enqueue(item, item);
					nextHead++;
				}
				else
				{
					var item = new int[] { costs[nextTail], 1 };
					pQueue.Enqueue(item, item);
					nextTail--;
				}
			}
		}

		return result;
	}
}