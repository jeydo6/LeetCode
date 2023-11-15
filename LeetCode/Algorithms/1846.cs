using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1846
{
    public static int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        var counts = new int[arr.Length + 1];

        for (var i = 0; i < arr.Length; i++)
        {
            var index = Math.Min(arr[i], arr.Length);
            counts[index]++;
        }

        var result = 1;
        for (var num = 2; num < counts.Length; num++)
        {
            result = Math.Min(result + counts[num], num);
        }

        return result;
    }
}