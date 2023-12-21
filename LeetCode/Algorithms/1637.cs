using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1637
{
    public static int MaxWidthOfVerticalArea(int[][] points)
    {
        Array.Sort(points, (a, b) => a[0] - b[0]);

        var result = 0;
        for (var i = 1; i < points.Length; i++)
        {
            result = Math.Max(result, points[i][0] - points[i - 1][0]);
        }

        return result;
    }
}