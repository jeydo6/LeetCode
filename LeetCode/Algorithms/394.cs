using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _394
	{
		public static string DecodeString(string s)
		{
			var results = new Stack<string>();
			var counts = new Stack<int>();

			var result = string.Empty;
			var i = 0;
			while (i < s.Length)
			{
				if (char.IsDigit(s[i]))
				{
					var count = 0;
					while (char.IsDigit(s[i]))
					{
						count = 10 * count + s[i] - '0';
						i++;
					}
					counts.Push(count);
				}
				else if (s[i] == '[')
				{
					results.Push(result);
					result = string.Empty;
					i++;
				}
				else if (s[i] == ']')
				{
					var sb = new StringBuilder(results.Pop());
					var count = counts.Pop();
					for (var j = 0; j < count; j++)
					{
						sb.Append(result);
					}
					result = sb.ToString();
					i++;
				}
				else
				{
					result += s[i];
					i++;
				}
			}
			return result;
		}
	}
}
