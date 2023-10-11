using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _227
	{
		public static int Calculate(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			var stack = new Stack<int>();
			var value = 0;
			var op = '+';
			for (var i = 0; i < s.Length; i++)
			{
				if (char.IsDigit(s[i]))
				{
					value = value * 10 + s[i] - '0';
				}
				if ((!char.IsDigit(s[i]) && s[i] != ' ') || i == s.Length - 1)
				{
					if (op == '-')
					{
						stack.Push(-value);
					}
					if (op == '+')
					{
						stack.Push(value);
					}
					if (op == '*')
					{
						stack.Push(stack.Pop() * value);
					}
					if (op == '/')
					{
						stack.Push(stack.Pop() / value);
					}

					op = s[i];
					value = 0;
				}
			}

			var result = 0;
			while (stack.Count > 0)
			{
				result += stack.Pop();
			}
			return result;
		}
	}
}
