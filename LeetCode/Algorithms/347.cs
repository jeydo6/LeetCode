using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _347
{
	public static int[] TopKFrequent(int[] nums, int k)
	{
		if (k == nums.Length)
		{
			return nums;
		}

		var count = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (!count.ContainsKey(nums[i]))
			{
				count[nums[i]] = 0;
			}
			count[nums[i]]++;
		}

		var pQueue = new PriorityQueue<int, int>();
		foreach (var key in count.Keys)
		{
			pQueue.Enqueue(key, count[key]);
			if (pQueue.Count > k)
			{
				pQueue.Dequeue();
			}
		}

		var result = new int[k];
		for (var i = k - 1; i >= 0; --i)
		{
			result[i] = pQueue.Dequeue();
		}

		return result;
	}
}
