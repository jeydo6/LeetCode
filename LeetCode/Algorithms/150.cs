using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _150
{
	public static int EvalRPN(string[] tokens)
	{
		var stack = new Stack<int>();
		for (var i = 0; i < tokens.Length; i++)
		{
			if (!"+-*/".Contains(tokens[i]))
			{
				stack.Push(int.Parse(tokens[i]));
				continue;
			}

			var number2 = stack.Pop();
			var number1 = stack.Pop();

			var result = 0;
			switch (tokens[i])
			{
				case "+":
					result = number1 + number2;
					break;
				case "-":
					result = number1 - number2;
					break;
				case "*":
					result = number1 * number2;
					break;
				case "/":
					result = number1 / number2;
					break;
			}

			stack.Push(result);

		}

		return stack.Pop();
	}
}
