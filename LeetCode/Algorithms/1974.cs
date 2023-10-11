using System;

namespace LeetCode.Algorithms
{
	class _1974
	{
		public static int MinTimeToType(string word)
		{
			var result = 0;
			var prev = 'a';
			foreach (var ch in word)
			{
				result += 1 + Math.Min(
					Math.Abs(ch - prev),
					26 - Math.Abs(ch - prev)
				);
				prev = ch;
			}
			return result;
		}
	}
}
