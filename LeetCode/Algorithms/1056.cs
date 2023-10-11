using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _1056
{
	private readonly static IDictionary<int, int> _digits = new Dictionary<int, int>
	{
		[0] = 0,
		[1] = 1,
		[6] = 9,
		[8] = 8,
		[9] = 6
	};

	public static bool ConfusingNumber(int n)
	{
		var originNumber = n;
		var rotatedNumber = 0;
		while (n > 0)
		{
			var remainder = n % 10;
			if (!_digits.ContainsKey(remainder))
			{
				return false;
			}

			rotatedNumber = rotatedNumber * 10 + _digits[remainder];
			n /= 10;
		}

		return rotatedNumber != originNumber;
	}
}
