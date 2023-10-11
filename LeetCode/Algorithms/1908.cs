namespace LeetCode.Algorithms;

// MEDIUM
internal class _1908
{
	public static bool NimGame(int[] piles)
	{
		var result = 0;
		for (var i = 0; i < piles.Length; i++)
		{
			result ^= piles[i];
		}
		return result != 0;
	}
}
