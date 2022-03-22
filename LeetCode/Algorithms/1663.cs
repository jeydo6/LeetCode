using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1663
	{
		public static string GetSmallestString(int n, int k)
		{
			var result = new char[n];
			for (var position = n - 1; position >= 0; position--)
			{
				var add = Math.Min(k - position, 26);
				result[position] = (char)(add + 'a' - 1);
				k -= add;
			}
			return new string(result);
		}
	}
}
