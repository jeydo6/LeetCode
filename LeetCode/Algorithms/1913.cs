using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _1913
{
	public static int MaxProductDifference(int[] numbers)
	{
		Array.Sort(numbers);
		return numbers[^2] * numbers[^1] - numbers[0] * numbers[1];
	}
}