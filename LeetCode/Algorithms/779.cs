namespace LeetCode.Algorithms;

// MEDIUM
internal class _779
{
	public static int KthGrammar(int n, int k)
	{
		var count = BitCount(k - 1);
		return count % 2 == 0 ? 0 : 1;
	}

	private static int BitCount(int value)
	{
		var count = 0;
		while (value != 0)
		{
			count++;
			value &= value - 1;
		}
		return count;
	}
}