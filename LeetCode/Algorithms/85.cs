using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _85
	{
		public static int MaximalRectangle(char[][] matrix)
		{
			if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
			{
				return 0;
			}

			var n = matrix.Length;
			var m = matrix[0].Length;

			var left = new int[m];
			var right = new int[m];
			var height = new int[m];

			Array.Fill(left, 0);
			Array.Fill(right, m);
			Array.Fill(height, 0);
			
			var result = 0;
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					if (matrix[i][j] == '1')
					{
						height[j]++;
					}
					else
					{
						height[j] = 0;
					}
				}

				var currentLeft = 0;
				for (var j = 0; j < m; j++)
				{
					if (matrix[i][j] == '1')
					{
						left[j] = Math.Max(left[j], currentLeft);
					}
					else
					{
						left[j] = 0;
						currentLeft = j + 1;
					}
				}

				var currentRight = m;
				for (var j = m - 1; j >= 0; j--)
				{
					if (matrix[i][j] == '1')
					{
						right[j] = Math.Min(right[j], currentRight);
					}
					else
					{
						right[j] = m;
						currentRight = j;
					}
				}

				for (var j = 0; j < m; j++)
				{
					result = Math.Max(result, (right[j] - left[j]) * height[j]);
				}
			}
			return result;
		}
	}
}
