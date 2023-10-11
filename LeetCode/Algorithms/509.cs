namespace LeetCode.Algorithms
{
	// EASY
	internal class _509
	{
		public static int Fib(int n)
		{
			if (n <= 1)
			{
				return n;
			}

			var current = 0;
			var prev1 = 1;
			var prev2 = 0;

			for (var i = 2; i <= n; i++)
			{
				current = prev1 + prev2;
				prev2 = prev1;
				prev1 = current;
			}
			return current;
		}
	}
}
