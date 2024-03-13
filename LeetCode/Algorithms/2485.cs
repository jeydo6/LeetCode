namespace LeetCode.Algorithms;

// EASY
internal sealed class _2485
{
	public static int PivotInteger(int n)
	{
		if (n == 1)
		{
			return n;
		}

		var lo = 1;
		var hi = n;
		var sumLeft = lo;
		var sumRight = hi;

		while (lo < hi)
		{
			if (sumLeft < sumRight)
			{
				sumLeft += ++lo;
			}
			else
			{
				sumRight += --hi;
			}

			if (sumLeft == sumRight && lo + 1 == hi - 1)
			{
				return lo + 1;
			}
		}

		return -1;
	}
}