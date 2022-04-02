using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _14
	{
		public static string LongestCommonPrefix(string[] strs)
		{
			if (strs == null || strs.Length == 0)
			{
				return "";
			}

			var lo = 1;
			var hi = int.MaxValue;
			for (var i = 0; i < strs.Length; i++)
			{
				hi = Math.Min(hi, strs[i].Length);
			}

			while (lo <= hi)
			{
				var middle = (lo + hi) / 2;
				if (IsCommonPrefix(strs, middle))
				{
					lo = middle + 1;
				}
				else
				{
					hi = middle - 1;
				}
			}
			return strs[0][..((lo + hi) / 2)];
		}

		private static bool IsCommonPrefix(string[] strs, int length)
		{
			var str = strs[0][..length];
			for (var i = 1; i < strs.Length; i++)
			{
				if (!strs[i].StartsWith(str))
				{
					return false;
				}
			}
			return true;
		}
	}
}
