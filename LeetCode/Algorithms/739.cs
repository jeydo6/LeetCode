using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _739
{
	public static int[] DailyTemperatures(int[] temperatures)
	{
		var result = new int[temperatures.Length];

		var stack = new Stack<int>();
		for (var i = 0; i < temperatures.Length; i++)
		{
			while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
			{
				var index = stack.Pop();
				result[index] = i - index;
			}
			stack.Push(i);
		}

		return result;
	}
}
