using System.Text;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _9
	{
		public static bool IsPalindrome(int x)
		{
			if (x < 0 || (x % 10 == 0 && x != 0))
			{
				return false;
			}

			var y = Reverse(x);
			return x == y || x == y / 10;
		}

		public static int Reverse(int x)
		{
			var y = 0;
			while (x > 0)
			{
				y = y * 10 + x % 10;
				x /= 10;
			}
			return y;
		}
	}
}
