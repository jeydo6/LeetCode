using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _118
	{
		public static IList<IList<int>> Generate(int n)
		{
			var rows = new List<IList<int>>();
			var row = new List<int>();
			for (var i = 0; i < n; i++)
			{
				row.Insert(0, 1);
				for (var j = 1; j < row.Count - 1; j++)
				{
					row[j] = row[j] + row[j + 1];
				}
				rows.Add(new List<int>(row));
			}
			return rows;
		}
	}
}
