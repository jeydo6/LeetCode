using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1799
{
	public static int MaxScore(int[] nums)
	{
		var maxStates = 1 << nums.Length;
		var dp = new int[maxStates];

		var finalMask = maxStates - 1;
		for (var state = finalMask; state >= 0; state--)
		{
			if (state == finalMask)
			{
				dp[state] = 0;
				continue;
			}

			var numbersTaken = BitCount(state);
			if (numbersTaken % 2 != 0)
			{
				continue;
			}

			var pairsFormed = numbersTaken / 2;
			for (var firstIndex = 0; firstIndex < nums.Length; firstIndex++)
			{
				for (var secondIndex = firstIndex + 1; secondIndex < nums.Length; secondIndex++)
				{
					if (((state >> firstIndex) & 1) == 1 || ((state >> secondIndex) & 1) == 1)
					{
						continue;
					}
					var currentScore = (pairsFormed + 1) * GCD(nums[firstIndex], nums[secondIndex]);
					var stateAfterPickingCurrPair = state | (1 << firstIndex) | (1 << secondIndex);
					var remainingScore = dp[stateAfterPickingCurrPair];
					dp[state] = Math.Max(dp[state], currentScore + remainingScore);
				}
			}
		}
		return dp[0];
	}

	private static int GCD(int value1, int value2)
	{
		while (value2 != 0)
		{
			var temp = value1 % value2;
			value1 = value2;
			value2 = temp;
		}
		return value1;
	}

	private static int BitCount(int value)
	{
		var result = 0;
		while (value != 0)
		{
			result++;
			value &= value - 1;
		}
		return result;
	}
}
