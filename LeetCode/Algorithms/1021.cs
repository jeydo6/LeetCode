using System.Collections.Generic;
using System.Text;

namespace Leetcode.Algorithms
{
	internal class _1021
	{
		public static string RemoveOuterParentheses(string s)
		{
			var sb = new StringBuilder();

			var stack = new Stack<char>();
			foreach (var ch in s)
			{
				if (ch == '(')
				{
					if (stack.Count != 0)
					{
						sb.Append(ch);
					}
					stack.Push(ch);
				}
				else if (ch == ')')
				{
					if (stack.Count != 1)
					{
						sb.Append(ch);
					}
					stack.Pop();
				}
			}

			return sb.ToString();
		}
	}
}