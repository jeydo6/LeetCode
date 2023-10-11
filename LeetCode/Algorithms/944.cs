namespace LeetCode.Algorithms;

// EASY
internal class _944
{
	public static int MinDeletionSize(string[] strs)
	{
		if (strs.Length < 2)
		{
			return 0;
		}

		var result = 0;
		for (var j = 0; j < strs[0].Length; j++)
		{
			for (var i = 1; i < strs.Length; i++)
			{
				if (strs[i - 1][j] > strs[i][j])
				{
					result++;
					break;
				}
			}
		}
		return result;
	}
}
