using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _856
	{
		public static int ScoreOfParentheses(string s)
		{
			var stack = new Stack<int>();
			stack.Push(0);

			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
					stack.Push(0);
				else
				{
					var a = stack.Pop();
					var b = stack.Pop();
					stack.Push(b + Math.Max(2 * a, 1));
				}
			}
			return stack.Pop();
		}
	}
}
