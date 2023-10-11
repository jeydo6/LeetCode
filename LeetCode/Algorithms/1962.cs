using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1962
{
	public static int MinStoneSum(int[] piles, int k)
	{
		var pqueue = new PriorityQueue<int, int>();
		for (var i = 0; i < piles.Length; i++)
		{
			pqueue.Enqueue(piles[i], -piles[i]);
		}

		for (var i = 0; i < k; i++)
		{
			var current = pqueue.Dequeue();
			var remove = current / 2;
			pqueue.Enqueue(current - remove, remove - current);
		}

		var result = 0;
		while (pqueue.Count > 0)
		{
			result += pqueue.Dequeue();
		}
		return result;
	}
}
