using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1569
{
	private const long Modulo = 1_000_000_007L;

	public static int NumOfWays(int[] nums)
	{
		var n = nums.Length;

		var table = new long[n][];
		for (var i = 0; i < n; i++)
		{
			table[i] = new long[n];
			table[i][0] = 1;
			table[i][i] = 1;
		}

		for (var i = 2; i < n; i++)
		{
			for (var j = 1; j < i; j++)
			{
				table[i][j] = (table[i - 1][j - 1] + table[i - 1][j]) % Modulo;
			}
		}
		return (int)((NumOfWays(nums) - 1) % Modulo);
	}

	private static long NumOfWays(IReadOnlyList<int> nums, IReadOnlyList<long[]> table)
	{
		var n = nums.Count;
		if (n < 3) {
			return 1;
		}

		var leftNodes = new List<int>();
		var rightNodes = new List<int>();
		for (var i = 1; i < n; i++)
		{
			if (nums[i] < nums[0])
			{
				leftNodes.Add(nums[i]);
			}
			else
			{
				rightNodes.Add(nums[i]);
			}
		}
		var leftWays = NumOfWays(leftNodes, table) % Modulo;
		var rightWays = NumOfWays(rightNodes, table) % Modulo;
		return leftWays * rightWays % Modulo * table[^1][leftNodes.Count] % Modulo;
	}
}