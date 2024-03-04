using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _948
{
	public static int BagOfTokensScore(int[] tokens, int power)
	{
		Array.Sort(tokens);
		var lo = 0;
		var hi = tokens.Length - 1;

		var points = 0;
		var result = 0;
		while (lo <= hi && (power >= tokens[lo] || points > 0))
		{
			while (lo <= hi && power >= tokens[lo])
			{
				power -= tokens[lo++];
				points++;
			}

			if (points > result)
			{
				result = points;
			}

			if (lo <= hi && points > 0)
			{
				power += tokens[hi--];
				points--;
			}
		}

		return result;
	}
}
