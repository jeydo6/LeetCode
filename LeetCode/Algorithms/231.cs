namespace LeetCode.Algorithms
{
	class _231
	{
		public static bool IsPowerOfTwo(int n)
		{
			if (n <= 0)
			{
				return false;
			}
			while (n % 2 == 0)
			{
				n /= 2;
			}
			return n == 1;
		}
	}
}
