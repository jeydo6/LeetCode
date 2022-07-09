using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1696
	{
		public static int MaxResult(int[] nums, int k)
		{
			var result = nums[0];
			var pQueue = new PriorityQueue<int[], int>();
			pQueue.Enqueue(new int[] { nums[0], 0 }, nums[0]);

			for (var i = 1; i < nums.Length; i++)
			{
				while (pQueue.Peek()[1] < i - k)
				{
					pQueue.Dequeue();
				}

				result = nums[i] + pQueue.Peek()[0];
				pQueue.Enqueue(new int[] { result, i }, result);
			}

			return result;
		}
	}
}
