using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _947
{
	private const int K = 10_001;

	public static int RemoveStones(int[][] stones)
	{
		var arr = new int[2 * K + 1];
		var size = new int[2 * K + 1];

		for (var i = 0; i < 2 * K + 1; i++)
		{
			arr[i] = i;
			size[i] = 1;
		}

		var count = 0;
		var marked = new Dictionary<int, int>();
		foreach (var stone in stones)
		{
			if (!marked.ContainsKey(stone[0]))
			{
				count++;
			}

			if (!marked.ContainsKey(stone[1] + K))
			{
				count++;
			}

			marked[stone[0]] = 1;
			marked[stone[1] + K] = 1;
		}

		for (var i = 0; i < stones.Length; i++)
		{
			var val1 = stones[i][0];
			var val2 = stones[i][1] + K;

			count -= PerformUnion(arr, size, val1, val2);
		}

		return stones.Length - count;
	}

	private static int PerformUnion(int[] arr, int[] size, int val1, int val2)
	{
		val1 = Find(arr, val1);
		val2 = Find(arr, val2);

		if (val1 == val2)
		{
			return 0;
		}

		if (size[val1] > size[val2])
		{
			arr[val2] = val1;
			size[val1] += size[val2];
		}
		else
		{
			arr[val1] = val2;
			size[val2] += size[val1];
		}

		return 1;
	}

	private static int Find(int[] arr, int val)
	{
		if (val == arr[val])
		{
			return val;
		}
		return arr[val] = Find(arr, arr[val]);
	}
}
