namespace LeetCode.Algorithms
{
	// EASY
	internal class _326
	{
		public static bool IsPowerOfThree(int n)
		{
			if (n < 1)
			{
				return false;
			}

			while (n % 3 == 0)
			{
				n /= 3;
			}

			return n == 1;
		}
	}
}
