using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _844
	{
		public static bool BackspaceCompare(string s, string t)
		{
			return BuildString(s) == BuildString(t);
		}

		private static string BuildString(string str)
		{
			var stack = new Stack<char>();
			for (var i = 0; i < str.Length; i++)
			{
				if (str[i] != '#')
				{
					stack.Push(str[i]);
				}
				else if (stack.Count > 0)
				{
					stack.Pop();
				}
			}
			return new string(stack.ToArray());
		}
	}
}
