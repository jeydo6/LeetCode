using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _402
	{
		public static string RemoveKdigits(string num, int k)
		{
			if (num.Length == k)
			{
				return "0";
			}

			var stack = new Stack<char>();
			var i = 0;
			while (i < num.Length)
			{
				while (k > 0 && stack.Count > 0 && stack.Peek() > num[i])
				{
					stack.Pop();
					k--;
				}
				stack.Push(num[i]);
				i++;
			}

			while (k > 0)
			{
				stack.Pop();
				k--;
			}

			var sb = new StringBuilder();
			while (stack.Count > 0)
			{
				sb.Append(stack.Pop());
			}

			var reverse = sb.ToString();
			sb = new StringBuilder();
			for (var j = 0; j < reverse.Length; j++)
			{
				sb.Append(reverse[^(j + 1)]);
			}
			while (sb.Length > 1 && sb[0] == '0')
			{
				sb.Remove(0, 1);
			}
			return sb.ToString();
		}
	}
}
