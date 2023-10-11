using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _131
{
	public static IList<IList<string>> Partition(string s)
	{
		var dp = new bool[s.Length][];
		for (var i = 0; i < s.Length; i++)
		{
			dp[i] = new bool[s.Length];
		}
		for (var i = 0; i < s.Length; i++)
		{
			for (var j = 0; j <= i; j++)
			{
				if (s[i] == s[j] && (i - j <= 2 || dp[j + 1][i - 1]))
				{
					dp[j][i] = true;
				}
			}
		}

		return Partition(s, dp, new LinkedList<string>(), 0);
	}

	private static IList<IList<string>> Partition(string s, bool[][] dp, LinkedList<string> path, int p)
	{
		if (p == s.Length)
		{
			return new List<IList<string>>
			{
				new List<string>(path)
			};
		}

		var result = new List<IList<string>>();
		for (var i = p; i < s.Length; i++)
		{
			if (dp[p][i])
			{
				path.AddLast(s[p..(i + 1)]);
				result.AddRange(Partition(s, dp, path, i + 1));
				path.RemoveLast();
			}
		}
		return result;
	}
}
