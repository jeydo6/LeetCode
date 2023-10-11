using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _673
{
	public static int FindNumberOfLIS(int[] nums)
	{
		var n = nums.Length;
		var length = new int[n];
		var count = new int[n];

		Array.Fill(length, 1);
		Array.Fill(count, 1);

		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < i; j++)
			{
				if (nums[j] < nums[i])
				{
					if (length[j] + 1 > length[i])
					{
						length[i] = length[j] + 1;
						count[i] = 0;
					}

					if (length[j] + 1 == length[i])
					{
						count[i] += count[j];
					}
				}
			}
		}

		var result = 0;
		var maxLength = 0;

		for (var i = 0; i < n; i++)
		{
			maxLength = Math.Max(maxLength, length[i]);
		}

		for (var i = 0; i < n; i++)
		{
			if (length[i] == maxLength)
			{
				result += count[i];
			}
		}

		return result;
	}
}