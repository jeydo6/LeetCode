using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
public class _1125
{
	public static int[] SmallestSufficientTeam(string[] reqSkills, IList<IList<string>> people)
	{
		var m = people.Count;
		var n = reqSkills.Length;
		var skillId = new Dictionary<string, int>();
		for (var i = 0; i < n; i++)
		{
			skillId[reqSkills[i]] = i;
		}

		var skillsMasks = new int[m];
		for (var i = 0; i < m; i++)
		{
			foreach (var skill in people[i])
			{
				skillsMasks[i] |= 1 << skillId[skill];
			}
		}

		var dp = new long [1 << n];
		Array.Fill(dp, (1L << m) - 1);
		dp[0] = 0;
		for (var skillsMask = 1; skillsMask < dp.Length; skillsMask++)
		{
			for (var i = 0; i < m; i++)
			{
				var smallerSkillsMask = skillsMask & ~skillsMasks[i];
				if (smallerSkillsMask != skillsMask)
				{
					long peopleMask = dp[smallerSkillsMask] | (1L << i);
					if (BitsCount(peopleMask) < BitsCount(dp[skillsMask]))
					{
						dp[skillsMask] = peopleMask;
					}
				}
			}
		}

		var answerMask = dp[(1 << n) - 1];
		var result = new int [BitsCount(answerMask)];
		var p = 0;
		for (var i = 0; i < m; i++)
		{
			if (((answerMask >> i) & 1) == 1)
			{
				result[p++] = i;
			}
		}

		return result;
	}

	private static int BitsCount(long value)
	{
		var count = 0;
		while (value != 0)
		{
			count++;
			value &= value - 1;
		}

		return count;
	}
}