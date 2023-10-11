namespace LeetCode.Algorithms;

// HARD
public class _1601
{
	public static int MaximumRequests(int n, int[][] requests)
	{
		var result = 0;

		for (var mask = 0; mask < 1 << requests.Length; mask++)
		{
			var indegree = new int[n];
			var position = requests.Length - 1;
			var bitCount = BitCount(mask);

			if (bitCount <= result)
			{
				continue;
			}

			for (var current = mask; current > 0; current >>= 1, position--)
			{
				if ((current & 1) == 1)
				{
					indegree[requests[position][0]]--;
					indegree[requests[position][1]]++;
				}
			}

			var flag = true;
			for (var i = 0; i < n; i++)
			{
				if (indegree[i] != 0)
				{
					flag = false;
					break;
				}
			}

			if (flag)
			{
				result = bitCount;
			}
		}

		return result;
	}

	private static int BitCount(int value)
	{
		var count = 0;
		while (value != 0)
		{
			count++;
			value &= value - 1;
		}

		return count;
	}
}