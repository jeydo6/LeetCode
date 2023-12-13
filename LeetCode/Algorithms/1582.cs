namespace LeetCode.Algorithms;

// EASY
internal sealed class _1582
{
    public static int NumSpecial(int[][] mat)
    {
        var rowCount = new int[mat.Length];
        var colCount = new int[mat[0].Length];
        for (var row = 0; row < rowCount.Length; row++)
        {
            for (int col = 0; col < colCount.Length; col++)
            {
                if (mat[row][col] == 1)
                {
                    rowCount[row]++;
                    colCount[col]++;
                }
            }
        }

        var result = 0;
        for (var row = 0; row < rowCount.Length; row++)
        {
            for (var col = 0; col < colCount.Length; col++)
            {
                if (mat[row][col] == 1)
                {
                    if (rowCount[row] == 1 && colCount[col] == 1)
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }
}