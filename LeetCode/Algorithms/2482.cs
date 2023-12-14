namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2482
{
    public static int[][] OnesMinusZeros(int[][] grid)
    {
        var rowCount = new int[grid.Length];
        var colCount = new int[grid[0].Length];
        for (var row = 0; row < rowCount.Length; row++)
        {
            for (var col = 0; col < colCount.Length; col++)
            {
                rowCount[row] += grid[row][col];
                colCount[col] += grid[row][col];
            }
        }

        var result = new int[rowCount.Length][];
        for (var row = 0; row < rowCount.Length; row++)
        {
            result[row] = new int[colCount.Length];
            for (var col = 0; col < colCount.Length; col++)
            {
                result[row][col] = 2 * rowCount[row] + 2 * colCount[col] - (rowCount.Length + colCount.Length);
            }
        }

        return result;
    }
}