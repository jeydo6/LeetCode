using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1167
{
	public static int ConnectSticks(int[] sticks)
	{
		var pqueue = new PriorityQueue<int, int>();
		for (var i = 0; i < sticks.Length; i++)
		{
			pqueue.Enqueue(sticks[i], sticks[i]);
		}

		var result = 0;
		while (pqueue.Count > 1)
		{
			var cost = pqueue.Dequeue() + pqueue.Dequeue();
			result += cost;

			pqueue.Enqueue(cost, cost);
		}

		return result;
	}
}
