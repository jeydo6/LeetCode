using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1338
	{
		public static int MinSetSize(int[] arr)
		{
			var counts = new Dictionary<int, int>();
			var maxCount = 0;
			for (var i = 0; i < arr.Length; i++)
			{
				if (!counts.ContainsKey(arr[i]))
				{
					counts[arr[i]] = 0;
				}

				counts[arr[i]]++;

				if (counts[arr[i]] > maxCount)
				{
					maxCount = counts[arr[i]];
				}
			}

			var buckets = new int[maxCount + 1];
			foreach (var count in counts.Values)
			{
				buckets[count]++;
			}

			var result = 0;
			
			var bucket = maxCount;
			var length = arr.Length / 2;
			while (length > 0)
			{
				var needed = length / bucket;
				if (length % bucket != 0)
				{
					needed++;
				}
				var setSize = Math.Min(buckets[bucket], needed);
				length -= setSize * bucket;
				bucket--;

				result += setSize;
			}

			return result;
		}
	}
}
