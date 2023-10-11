namespace LeetCode.Algorithms;

// MEDIUM
internal class _50
{
	public static double MyPow(double x, long n)
	{
		if (n == 0)
		{
			return 1;
		}

		if (n < 0)
		{
			n *= -1;
			x = 1.0 / x;
		}

		var result = 1.0;
		while (n != 0)
		{
			if (n % 2 == 1)
			{
				result *= x;
				n -= 1;
			}

			x *= x;
			n /= 2;
		}

		return result;
	}
}