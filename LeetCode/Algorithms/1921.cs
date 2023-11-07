using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1921
{
    public static int EliminateMaximum(int[] dist, int[] speed)
    {
        var arrivals = new double[dist.Length];
        for (var i = 0; i < dist.Length; i++)
        {
            arrivals[i] = (double)dist[i] / speed[i];
        }

        Array.Sort(arrivals);
        int result = 0;

        for (var i = 0; i < arrivals.Length; i++)
        {
            if (arrivals[i] <= i)
            {
                break;
            }

            result++;
        }

        return result;
    }
}