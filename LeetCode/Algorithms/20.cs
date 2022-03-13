using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	// 2022-03-13
	internal class _20
	{
		public static bool IsValid(string s)
		{
			var stack = new Stack<char>();
			for (var i = 0; i < s.Length; i++)
			{
				var ch = s[i];
				if (ch == '(')
				{
					stack.Push(')');
				}
				else if (ch == '{')
				{
					stack.Push('}');
				}
				else if (ch == '[')
				{
					stack.Push(']');
				}
				else if (stack.Count == 0 || stack.Pop() != ch)
				{
					return false;
				}
			}
			return stack.Count == 0;
		}
	}
}
