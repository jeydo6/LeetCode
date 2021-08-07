using System;

namespace LeetCode.Algorithms
{
	class _132
	{
		public static int MinCut(string s)
		{
			var cut = new int[s.Length];
			var palindrom = new bool[s.Length][];
			for (var i = 0; i < s.Length; i++)
			{
				var min = i;
				palindrom[i] = new bool[s.Length];
				for (var j = 0; j <= i; j++)
				{
					if (s[j] == s[i] && (j + 1 > i - 1 || palindrom[j + 1][i - 1]))
					{
						palindrom[j][i] = true;
						min = j == 0 ? 0 : Math.Min(min, cut[j - 1] + 1);
					}
				}
				cut[i] = min;
			}
			return cut[^1];
		}
	}
}
