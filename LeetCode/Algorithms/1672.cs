using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _1672
	{
		public static int MaximumWealth(int[][] accounts)
		{
			var result = 0;
			for (var i = 0; i < accounts.Length; i++)
			{
				var temp = 0;
				for (var j = 0; j < accounts[i].Length; j++)
				{
					temp += accounts[i][j];
				}
				result = Math.Max(result, temp);
			}
			return result;
		}
	}
}
