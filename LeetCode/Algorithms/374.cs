namespace LeetCode.Algorithms
{

	// EASY
	internal class _374
	{
		public static int GuessNumber(int n)
		{
			var l = 1;
			var r = n;
			while (l <= r)
			{
				int m = l + (r - l) / 2;
				if (Guess(m) == 0)
				{
					return m;
				}

				if (Guess(m) < 0)
				{
					r = m - 1;
				}
				else
				{
					l = m + 1;
				}
			}
			return 0;
		}

		private static int Guess(int n)
		{
			return n;
		}
	}
}
