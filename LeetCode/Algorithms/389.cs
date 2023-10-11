namespace LeetCode.Algorithms;

// EASY
internal class _389
{
	public static char FindTheDifference(string s, string t)
	{
		var n = t.Length;
		var ch = t[^1];
		for (var i = 0; i < n - 1; ++i)
		{
			ch ^= s[i];
			ch ^= t[i];
		}
		return ch;
	}
}