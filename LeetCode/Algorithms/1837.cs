namespace LeetCode.Algorithms
{
	class _1837
	{
		public static int SumBase(int n, int k)
		{
			var result = 0;
			while (n > 0)
			{
				result += n % k;
				n /= k;
			}
			return result;
		}
	}
}
