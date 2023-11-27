using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _935
{
	private const int Modulo = 1_000_000_007;

	private static readonly int[][] _jumps = new int[][]
	{
		new int[] { 4, 6 }, new int[] { 6, 8 }, new int[] { 7, 9 }, new int[] { 4, 8 }, new int[] { 3, 9, 0 },
		Array.Empty<int>(), new int[] { 1, 7, 0 }, new int[] { 2, 6 }, new int[] { 1, 3 }, new int[] { 2, 4 }
	};

	public static int KnightDialer(int n)
	{
		var prevDp = new int[10];
		Array.Fill(prevDp, 1);

		for (var remain = 1; remain < n; remain++)
		{
			var dp = new int[10];
			for (var square = 0; square < 10; square++)
			{
				for (var j = 0; j < _jumps[square].Length; j++)
				{
					dp[square] = (dp[square] + prevDp[_jumps[square][j]]) % Modulo;
				}
			}

			prevDp = dp;
		}

		var result = 0;
		for (var square = 0; square < 10; square++)
		{
			result = (result + prevDp[square]) % Modulo;
		}

		return result;
	}
}