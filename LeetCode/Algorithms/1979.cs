namespace LeetCode.Algorithms
{
	class _1979
	{
		public static int FindGCD(int[] nums)
		{
			var min = int.MaxValue;
			var max = int.MinValue;
			foreach (var num in nums)
			{
				if (num < min) min = num;
				if (num > max) max = num;
			}
			for (var divisor = min; divisor >= 1; divisor--)
			{
				if (min % divisor == 0 && max % divisor == 0)
				{
					return divisor;
				}
			}
			return 1;
		}
	}
}
