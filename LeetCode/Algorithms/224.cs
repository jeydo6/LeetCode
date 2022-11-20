using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _224
{
	public static int Calculate(string s)
	{
		var result = 0;
		var number = 0;
		var sign = 1;
		var stack = new Stack<int>();
		for (var i = 0; i < s.Length; i++)
		{
			if (char.IsDigit(s[i]))
			{
				number = 10 * number + s[i] - '0';
			}
			else if (s[i] == '+')
			{
				result += sign * number;
				number = 0;
				sign = 1;
			}
			else if (s[i] == '-')
			{
				result += sign * number;
				number = 0;
				sign = -1;
			}
			else if (s[i] == '(')
			{
				stack.Push(result);
				stack.Push(sign);

				sign = 1;
				result = 0;
			}
			else if (s[i] == ')')
			{
				result += sign * number;
				number = 0;

				result *= stack.Pop();
				result += stack.Pop();
			}
		}
		if (number != 0)
		{
			result += sign * number;
		}
		return result;
	}
}
