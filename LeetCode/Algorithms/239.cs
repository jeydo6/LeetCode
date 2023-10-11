using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _239
{
	public static int[] MaxSlidingWindow(int[] nums, int k)
	{
		var queue = new LinkedList<int>();
		for (var i = 0; i < k; i++)
		{
			while (queue.Count > 0 && nums[i] >= nums[queue.Last!.Value])
			{
				queue.RemoveLast();
			}
			queue.AddLast(i);
		}

		var result = new List<int> { nums[queue.First!.Value] };
		for (var i = k; i < nums.Length; i++)
		{
			if (queue.First.Value == i - k)
			{
				queue.RemoveFirst();
			}

			while (queue.Count > 0 && nums[i] >= nums[queue.Last!.Value])
			{
				queue.RemoveLast();
			}

			queue.AddLast(i);
			result.Add(nums[queue.First!.Value]);
		}

		return result.ToArray();
	}
}