using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _316
{
	public static string RemoveDuplicateLetters(string s)
	{
		var count = new int[26];
		for (var i = 0; i < s.Length; i++)
		{
			count[s[i] - 'a'] = i;
		}

		var seen = new bool[26];
		var stack = new Stack<int>();
		for (var i = 0; i < s.Length; i++)
		{
			var current = s[i] - 'a';
			if (seen[current])
			{
				continue;
			}

			while (stack.Count > 0 && stack.Peek() > current && i < count[stack.Peek()])
			{
				seen[stack.Pop()] = false;
			}
			
			stack.Push(current);
			seen[current] = true;
		}

		var result = new char[stack.Count];
		var index = stack.Count - 1;
		while (stack.Count > 0)
		{
			result[index] = (char)(stack.Pop() + 'a');
			index--;
		}

		return new string(result);
	}
}