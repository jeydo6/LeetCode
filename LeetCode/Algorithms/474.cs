using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _474
	{
		public static int FindMaxForm(string[] strs, int n, int m)
		{
			var dp = new int[n + 1][];
			for (int i = 0; i < dp.Length; i++)
			{
				dp[i] = new int[m + 1];
			}

			for (var i = 0; i < strs.Length; i++)
			{
				var count = Count(strs[i]);
				for (var zeroes = n; zeroes >= count[0]; zeroes--)
				{
					for (var ones = m; ones >= count[1]; ones--)
					{
						dp[zeroes][ones] = Math.Max(dp[zeroes][ones], 1 + dp[zeroes - count[0]][ones - count[1]]);
					}
				}
			}

			return dp[n][m];
		}

		private static int[] Count(string str)
		{
			var result = new int[2];
			for (var i = 0; i < str.Length; i++)
			{
				result[str[i] - '0']++;
			}
			return result;
		}
	}
}
