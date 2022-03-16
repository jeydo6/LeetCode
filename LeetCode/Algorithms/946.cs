using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _946
	{
		public static bool ValidateStackSequences(int[] pushed, int[] popped)
		{
			var j = 0;
			var stack = new Stack<int>();
			for (var i = 0; i < pushed.Length; i++)
			{
				stack.Push(pushed[i]);
				while (stack.Count > 0 && j < pushed.Length && stack.Peek() == popped[j])
				{
					stack.Pop();
					j++;
				}
			}
			return j == pushed.Length;
		}
	}
}
