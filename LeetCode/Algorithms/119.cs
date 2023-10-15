using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _119
{
	public static IList<int> GetRow(int rowIndex)
	{
		var result = new List<int> { 1 };
		for (var i = 1; i <= rowIndex; i++)
		{
			for (var j = i - 1; j >= 1; j--)
			{
				var temp = result[j - 1] + result[j];
				result[j] = temp;
			}

			result.Add(1);
		}

		return result;
	}
}