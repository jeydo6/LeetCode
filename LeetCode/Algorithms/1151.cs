using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1151
	{
		public int MinSwaps(int[] data)
		{
			var ones = 0;
			for (var i = 0; i < data.Length; i++)
			{
				ones += data[i];
			}

			var queue = new Queue<int>(ones);
			var count = 0;
			var max = 0;
			for (var i = 0; i < data.Length; i++)
			{
				queue.Enqueue(data[i]);
				count += data[i];

				if (queue.Count > ones)
				{
					count -= queue.Dequeue();
				}

				max = Math.Max(max, count);
			}
			return ones - max;
		}
	}
}
