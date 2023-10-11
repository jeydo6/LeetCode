namespace LeetCode.Algorithms
{
	// HARD
	internal class _878
	{
		public static int NthMagicalNumber(int n, int a, int b)
		{
			var lcm = (long)(a * b) / GCD(a, b);

			var l = 2L;
			var r = (long)1e14;
			while (l < r)
			{
				var m = (l + r) / 2;
				if (m / a + m / b - m / lcm < n)
				{
					l = m + 1;
				}
				else
				{
					r = m;
				}
			}

			var mod = (long)1e9 + 7;
			return (int)(l % mod);
		}

		private static int GCD(int a, int b)
		{
			while (b > 0)
			{
				var tmp = a;
				a = b;
				b = tmp % b;
			}

			return a;
		}
	}
}
