namespace LeetCode.Algorithms;

// EASY
internal class _374
{
	public static int GuessNumber(int n)
	{
		var lo = 1;
		var hi = n;
		while (lo <= hi)
		{
			int m = lo + (hi - lo) / 2;
			if (Guess(m) == 0)
			{
				return m;
			}

			if (Guess(m) < 0)
			{
				hi = m - 1;
			}
			else
			{
				lo = m + 1;
			}
		}
		return -1;
	}

	private static int Guess(int n)
	{
		return n;
	}
}
