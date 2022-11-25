using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _907
{
	private const int Modulo = 1000000007;

	public static int SumSubarrayMins(int[] arr)
	{
		var stack = new Stack<int>();

		var dp = new int[arr.Length];
		for (var i = 0; i < arr.Length; i++)
		{
			while (stack.Count > 0 && arr[stack.Peek()] >= arr[i])
			{
				stack.Pop();
			}

			if (stack.Count > 0)
			{
				var previousSmaller = stack.Peek();
				dp[i] = dp[previousSmaller] + (i - previousSmaller) * arr[i];
			}
			else
			{
				dp[i] = (i + 1) * arr[i];
			}

			stack.Push(i);
		}

		var result = 0L;
		for (var i = 0; i < dp.Length; i++)
		{
			result += dp[i];
			result %= Modulo;
		}

		return (int)result;
	}
}
