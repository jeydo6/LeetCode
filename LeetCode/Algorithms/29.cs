namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _29
	{
		private const int HalfMinValue = -1073741824;

		public static int Divide(int dividend, int divisor)
		{
			if (dividend == int.MinValue && divisor == -1)
			{
				return int.MaxValue;
			}

			if (dividend == int.MinValue && divisor == 1)
			{
				return int.MinValue;
			}

			var negatives = 2;
			if (dividend > 0)
			{
				negatives--;
				dividend = -dividend;
			}
			if (divisor > 0)
			{
				negatives--;
				divisor = -divisor;
			}

			var maxBit = 0;
			while (divisor >= HalfMinValue && divisor + divisor >= dividend)
			{
				maxBit += 1;
				divisor += divisor;
			}

			var quotient = 0;
			for (var bit = maxBit; bit >= 0; bit--)
			{
				if (divisor >= dividend)
				{
					quotient -= (1 << bit);
					dividend -= divisor;
				}
				divisor = (divisor + 1) >> 1;
			}

			if (negatives != 1)
			{
				quotient = -quotient;
			}
			return quotient;
		}
	}
}
