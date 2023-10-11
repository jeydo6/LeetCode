using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2272
{
	public static int LargestVariance(string s)
	{
		var counter = new int[26];
		for (var i = 0; i < s.Length; i++)
		{
			counter[s[i] - 'a']++;
		}

		var result = 0;
		for (var i = 0; i < counter.Length; i++)
		{
			for (var j = 0; j < counter.Length; j++)
			{
				if (i == j || counter[i] == 0 || counter[j] == 0)
				{
					continue;
				}

				var major = (char)('a' + i);
				var minor = (char)('a' + j);
				var majorCount = 0;
				var minorCount = 0;

				var restMinor = counter[j];

				for (var k = 0; k < s.Length; k++)
				{
					if (s[k] == major)
					{
						majorCount++;
					}

					if (s[k] == minor)
					{
						minorCount++;
						restMinor--;
					}

					if (minorCount > 0)
					{
						result = Math.Max(result, majorCount - minorCount);
					}

					if (majorCount < minorCount && restMinor > 0)
					{
						majorCount = 0;
						minorCount = 0;
					}
				}
			}
		}

		return result;
	}
}