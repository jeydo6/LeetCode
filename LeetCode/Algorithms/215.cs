using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _215
	{
		public static int FindKthLargest(int[] nums, int k)
		{
			var pqueue = new PriorityQueue<int, int>();
			for (var i = 0; i < nums.Length; i++)
			{
				pqueue.Enqueue(nums[i], nums[i]);
				if (pqueue.Count > k)
				{
					pqueue.Dequeue();
				}
			}

			return pqueue.Dequeue();
		}
	}
}
