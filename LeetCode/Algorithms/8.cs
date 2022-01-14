namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _8
	{
		public static int MyAtoi(string s)
		{
			var index = 0;
			while (index < s.Length && char.IsWhiteSpace(s[index]))
			{
				index++;
			}

			var sign = 1;
			if (index < s.Length && (s[index] == '-' || s[index] == '+'))
			{
				if (s[index] == '-')
				{
					sign = -1;
				}
				index++;
			}

			var result = 0;
			while (index < s.Length && char.IsDigit(s[index]))
			{
				var digit = s[index] - '0';
				if (result > (int.MaxValue - digit) / 10)
				{
					return sign == -1 ? int.MinValue : int.MaxValue;
				}
				result = (result * 10) + digit;
				index++;
			}
			return result * sign;
		}
	}
}
