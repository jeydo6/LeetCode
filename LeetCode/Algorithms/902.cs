using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _902
	{
		public static int AtMostNGivenDigitSet(string[] digits, int n)
		{
			var nStr = n.ToString();
			var result = 0;
			for (var i = 1; i < nStr.Length; i++)
			{
				result += (int)Math.Pow(digits.Length, i);
			}
			for (var i = 0; i < nStr.Length; i++)
			{
				var same = false;
				for (var j = 0; j < digits.Length; j++)
				{
					if (digits[j][0] < nStr[i])
					{
						result += (int)Math.Pow(digits.Length, nStr.Length - 1 - i);
					}
					else if (digits[j][0] == nStr[i])
					{
						same = true;
					}
				}
				if (!same)
				{
					return result;
				}
			}
			return result + 1;
		}
	}
}
