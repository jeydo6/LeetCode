using System;

namespace LeetCode.Algorithms;

// EASY
internal class _1356
{
	public static int[] SortByBits(int[] arr)
	{
		Array.Sort(arr, (a, b) =>
		{
			var diff = GetWeight(a) - GetWeight(b);
			if (diff is not 0)
			{
				return diff;
			}

			return a - b;
		});

		return arr;
	}

	private static int GetWeight(int num)
	{
		var result = 0;
		while (num > 0)
		{
			result++;
			num &= num - 1;
		}

		return result;
	}
}