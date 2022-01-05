using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _131
	{
		public static IList<IList<string>> Partition(string s)
		{
			var result = new List<IList<string>>();
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
			Helper(result, new List<string>(), dp, s, 0);
			return result;
		}

		private static void Helper(IList<IList<string>> result, IList<string> path, bool[][] dp, string s, int p)
		{
			if (p == s.Length)
			{
				result.Add(new List<string>(path));
				return;
			}

			for (var i = p; i < s.Length; i++)
			{
				if (dp[p][i])
				{
					path.Add(s[p..(i + 1)]);
					Helper(result, path, dp, s, i + 1);
					path.RemoveAt(path.Count - 1);
				}
			}
		}
	}
}
