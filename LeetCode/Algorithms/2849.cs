using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2849
{
    public static bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        var width = Math.Abs(sx - fx);
        var height = Math.Abs(sy - fy);
        if (width == 0 && height == 0 && t == 1)
        {
            return false;
        }

        return t >= Math.Max(width, height);
    }
}