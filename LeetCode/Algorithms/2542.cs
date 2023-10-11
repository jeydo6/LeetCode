using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2542
{
	public static long MaxScore(int[] nums1, int[] nums2, int k)
	{
		var n = nums1.Length;
		var pairs = new int[n][];
		for (var i = 0; i < n; i++)
		{
			pairs[i] = new int[] { nums1[i], nums2[i] };
		}
		Array.Sort(pairs, (a, b) => b[1] - a[1]);

		var pqueue = new PriorityQueue<int, int>(k);
		var sum = 0L;
		for (var i = 0; i < k; i++)
		{
			sum += pairs[i][0];
			pqueue.Enqueue(pairs[i][0], pairs[i][0]);
		}

		var result = sum * pairs[k - 1][1];
		for (var i = k; i < n; i++)
		{
			sum += pairs[i][0] - pqueue.Dequeue();
			pqueue.Enqueue(pairs[i][0], pairs[i][0]);

			result = Math.Max(result, sum * pairs[i][1]);
		}

		return result;
	}
}
