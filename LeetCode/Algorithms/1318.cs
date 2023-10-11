namespace LeetCode.Algorithms;

// MEDIUM
internal class _1318
{
	public static int MinFlips(int a, int b, int c)
	{
		var result = 0;
		while (a != 0 | b != 0 | c != 0)
		{
			if ((c & 1) == 1)
			{
				if ((a & 1) == 0 && (b & 1) == 0)
				{
					result++;
				}
			}
			else
			{
				result += (a & 1) + (b & 1);
			}

			a >>= 1;
			b >>= 1;
			c >>= 1;
		}

		return result;
	}
}
