namespace LeetCode.Algorithms;

// MEDIUM
internal class _1802
{
	public static int MaxValue(int n, int index, int maxSum)
	{
		var lo = 1;
		var hi = maxSum;
		while (lo < hi)
		{
			var mid = (lo + hi + 1) / 2;
			if (GetSum(index, mid, n) <= maxSum)
			{
				lo = mid;
			}
			else
			{
				hi = mid - 1;
			}
		}

		return lo;
	}

	private static long GetSum(int index, int value, int n)
	{
		var count = 0L;

		if (value > index)
		{
			count += (long)(value + value - index) * (index + 1) / 2;
		}
		else
		{
			count += (long)(value + 1) * value / 2 + index - value + 1;
		}

		if (value >= n - index)
		{
			count += (long)(value + value - n + 1 + index) * (n - index) / 2;
		}
		else
		{
			count += (long)(value + 1) * value / 2 + n - index - value;
		}

		return count - value;
	}
}
