using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1428
{
	public abstract class BinaryMatrix
	{
		public abstract int Get(int row, int col);
		public abstract IList<int> Dimensions();
	}

	public static int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
	{
		var dimensions = binaryMatrix.Dimensions();
		var rows = dimensions[0];
		var cols = dimensions[1];

		var currentRow = 0;
		var currentCol = cols - 1;

		while (currentRow < rows && currentCol >= 0)
		{
			if (binaryMatrix.Get(currentRow, currentCol) == 0)
			{
				currentRow++;
			}
			else
			{
				currentCol--;
			}
		}

		return (currentCol == cols - 1) ? -1 : currentCol + 1;
	}
}
