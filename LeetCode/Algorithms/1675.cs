using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1675
	{
		public static int MinimumDeviation(int[] nums)
		{
			var pqueue = new PriorityQueue<int, int>();
			var min = int.MaxValue;
			for (var i = 0; i < nums.Length; i++)
			{
				var num = nums[i];
				if (num % 2 == 1)
				{
					num *= 2;
				};
				pqueue.Enqueue(num, -num);
				min = Math.Min(min, num);
			}

			var result = int.MaxValue;
			while (true)
			{
				var num = pqueue.Dequeue();
				result = Math.Min(result, num - min);
				if (num % 2 == 1)
				{
					break;
				}
				min = Math.Min(min, num / 2);
				pqueue.Enqueue(num / 2, -num / 2);
			}
			return result;
		}
	}
}
