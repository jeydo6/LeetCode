namespace LeetCode.Algorithms;

// EASY
internal class _263
{
	public static bool IsUgly(int n)
	{
		if (n <= 0)
		{
			return false;
		}

		foreach (var factor in new[] { 2, 3, 5 })
		{
			n = KeepDividingWhenDivisible(n, factor);
		}

		return n == 1;
	}

	private static int KeepDividingWhenDivisible(int dividend, int divisor)
	{
		while (dividend % divisor == 0)
		{
			dividend /= divisor;
		}
		return dividend;
	}
}
