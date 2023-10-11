using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _277
	{
		public static int FindCelebrity(int n)
		{
			var candidate = 0;
			for (var b = 0; b < n; b++)
			{
				if (Knows(candidate, b))
				{
					candidate = b;
				}
			}

			if (IsCelebrity(candidate, n))
			{
				return candidate;
			}

			return -1;
		}

		private static bool IsCelebrity(int a, int n)
		{
			for (var b = 0; b < n; b++)
			{
				if (a == b)
				{
					continue;
				}

				if (Knows(a, b) || !Knows(b, a))
				{
					return false;
				}
			}
			return true;
		}

		private static bool Knows(int a, int b)
		{
			return a == b;
		}
	}
}
