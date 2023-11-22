using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1424
{
    public static int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        var result = new List<int>();

        var queue = new Queue<(int Row, int Col)>();
        queue.Enqueue((0, 0));
        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();

            result.Add(nums[row][col]);

            if (col == 0 && row + 1 < nums.Count)
            {
                queue.Enqueue((row + 1, col));
            }
            
            if (col + 1 < nums[row].Count)
            {
                queue.Enqueue((row, col + 1));
            }
        }

        return result.ToArray();
    }
}