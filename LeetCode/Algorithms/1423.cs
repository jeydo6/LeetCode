using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1423
	{
		public static int MaxScore(int[] cardPoints, int k)
		{
			var frontScore = 0;
			var rearScore = 0;

			for (var i = 0; i < k; i++)
			{
				frontScore += cardPoints[i];
			}

			var maxScore = frontScore;

			for (var i = k - 1; i >= 0; i--)
			{
				rearScore += cardPoints[^(k - i)];
				frontScore -= cardPoints[i];

				maxScore = Math.Max(maxScore, rearScore + frontScore);
			}

			return maxScore;
		}
	}
}
