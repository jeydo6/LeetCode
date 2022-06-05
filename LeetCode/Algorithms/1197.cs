using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1197
	{
		public static int MinKnightMoves(int x, int y)
		{
			return DFS(Math.Abs(x), Math.Abs(y), new Dictionary<string, int>());
		}

		public static int DFS(int x, int y, IDictionary<string, int> memo)
		{
			var key = x + "," + y;
			if (memo.ContainsKey(key))
			{
				return memo[key];
			}

			if (x + y == 0)
			{
				return 0;
			}
			else if (x + y == 2)
			{
				return 2;
			}
			else
			{
				var value = Math.Min(
					DFS(Math.Abs(x - 1), Math.Abs(y - 2), memo),
					DFS(Math.Abs(x - 2), Math.Abs(y - 1), memo)
				) + 1;
				memo[key] = value;
				return value;
			}
		}
	}
}
