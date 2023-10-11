namespace LeetCode.Algorithms;

// EASY
internal class _1523
{
	public static int CountOdds(int low, int high)
	{
		if (low % 2 == 0)
		{
			low++;
		}

		return low > high ? 0 : (high - low) / 2 + 1;
	}
}
