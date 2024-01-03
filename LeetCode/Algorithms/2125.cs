namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2125
{
	public static int NumberOfBeams(string[] bank)
	{
		var result = 0;

		var prevCount = 0;
		for (var i = 0; i < bank.Length; i++)
		{
			var count = 0;
			for (var j = 0; j < bank[i].Length; j++)
			{
				if (bank[i][j] == '1')
				{
					count++;
				}
			}

			if (count > 0)
			{
				result += prevCount * count;
				prevCount = count;
			}
		}

		return result;
	}
}