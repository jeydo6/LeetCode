using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _32
	{
		public static int LongestValidParentheses(string s)
		{
			var result = 0;
			var stack = new Stack<int>();
			stack.Push(-1);
			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					stack.Push(i);
				}
				else
				{
					stack.Pop();
					if (stack.Count == 0)
					{
						stack.Push(i);
					}
					else
					{
						result = Math.Max(result, i - stack.Peek());
					}
				}
			}
			return result;
		}
	}
}
