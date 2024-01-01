using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _455
{
	public static int FindContentChildren(int[] g, int[] s)
	{
		Array.Sort(g);
		Array.Sort(s);

		var contentChildren = 0;
		var cookieIndex = 0;
		while (cookieIndex < s.Length && contentChildren < g.Length)
		{
			if (s[cookieIndex] >= g[contentChildren])
			{
				contentChildren++;
			}

			cookieIndex++;
		}

		return contentChildren;
	}
}