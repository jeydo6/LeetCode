using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _735
{
	public static int[] AsteroidCollision(int[] asteroids)
	{
		var stack = new Stack<int>();
		for (var i = 0; i < asteroids.Length; i++)
		{
			var flag = true;
			while (stack.Count > 0 && stack.Peek() > 0 && asteroids[i] < 0)
			{
				if (Math.Abs(stack.Peek()) < Math.Abs(asteroids[i]))
				{
					stack.Pop();
					continue;
				}
				else if (Math.Abs(stack.Peek()) == Math.Abs(asteroids[i]))
				{
					stack.Pop();
				}

				flag = false;
				break;
			}

			if (flag)
			{
				stack.Push(asteroids[i]);
			}
		}

		var result = new int[stack.Count];
		for (var i = result.Length - 1; i >= 0; i--)
		{
			result[i] = stack.Peek();
			stack.Pop();
		}

		return result;
	}
}