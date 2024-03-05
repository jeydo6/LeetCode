namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1750
{
	public static int MinimumLength(string s)
	{
		var lo = 0;
		var hi = s.Length - 1;
		while (lo < hi && s[lo] == s[hi])
		{
			var ch = s[lo];

			while (lo <= hi && s[lo] == ch)
			{
				lo++;
			}

			while (hi > lo && s[hi] == ch)
			{
				hi--;
			}
		}

		return hi - lo + 1;
	}
}