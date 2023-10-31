namespace LeetCode.Algorithms;

// MEDIUM
internal class _2433
{
	public static int[] FindArray(int[] pref)
	{
		for (var i = pref.Length - 1; i > 0; i--)
		{
			pref[i] ^= pref[i - 1];
		}

		return pref;
	}
}