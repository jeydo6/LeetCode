using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1680
{
	private const int Modulo = 1_000_000_007;

	public static int ConcatenatedBinary(int n)
	{
		var length = 0;
		var result = 0L;
		for (var i = 1; i <= n; i++)
		{
			if (Math.Pow(2, (int)(Math.Log(i) / Math.Log(2))) == i)
			{
				length++;
			}
			result = ((result * (int)Math.Pow(2, length)) + i) % Modulo;
		}

		return (int)result;
	}
}
