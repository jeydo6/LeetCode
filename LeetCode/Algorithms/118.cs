using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _118
	{
		public static IList<IList<int>> Generate(int numRows)
		{
			var result = new List<IList<int>>();

			var currentRow = new List<int>();
			for (var i = 0; i < numRows; i++)
			{
				currentRow.Insert(0, 1);
				for (var j = 1; j < currentRow.Count - 1; j++)
				{
					currentRow[j] = currentRow[j] + currentRow[j + 1];
				}
				result.Add(new List<int>(currentRow));
			}

			return result;
		}
	}
}
