using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _343
{
	public static int IntegerBreak(int n)
	{
		if (n <= 3)
		{
			return n - 1;
		}

		return (n % 3) switch
		{
			0 => (int)Math.Pow(3, n / 3),
			1 => (int)Math.Pow(3, n / 3 - 1) * 4,
			_ => (int)Math.Pow(3, n / 3) * 2
		};
	}
}
