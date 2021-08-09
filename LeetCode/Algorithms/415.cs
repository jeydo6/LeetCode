using System;

namespace LeetCode.Algorithms
{
	// EASY
	class _415
	{
		public static string AddStrings(string num1, string num2)
		{
			var length = Math.Max(num1.Length, num2.Length);
			num1 = new string('0', length - num1.Length) + num1;
			num2 = new string('0', length - num2.Length) + num2;

			var carry = 0;
			var result = new int[length];
			for (var i = length - 1; i >= 0; i--)
			{
				var sum = num1[i] - '0' + num2[i] - '0' + carry;

				result[i] = sum % 10;
				carry = sum / 10;
			}

			if (carry == 0)
			{
				return string.Concat(result);
			}
			else
			{
				return carry.ToString() + string.Concat(result);
			}
		}
	}
}
