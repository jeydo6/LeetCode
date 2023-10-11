namespace Leetcode.Algorithms
{
	// EASY
	internal class _509
	{
		public static int Fib(int n)
		{
			var array = new int[]
			{
				0,
				1,
				0
			};

			for (var i = 2; i <= n; i++)
			{
				array[2] = array[0] + array[1];
				array[0] = array[1];
				array[1] = array[2];
			}

			if (n <= 2)
			{
				return array[n];
			}

			return array[2];
		}
	}
}
