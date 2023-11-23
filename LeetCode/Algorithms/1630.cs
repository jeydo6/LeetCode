using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1630
{
    public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new List<bool>();
        for (var i = 0; i < l.Length; i++)
        {
            result.Add(
                Check(nums[l[i]..(r[i] + 1)])
            );
        }

        return result;
    }

    internal static bool Check(int[] nums)
    {
        var minElement = int.MaxValue;
        var maxElement = int.MinValue;

        var set = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            minElement = Math.Min(minElement, nums[i]);
            maxElement = Math.Max(maxElement, nums[i]);
            set.Add(nums[i]);
        }

        if ((maxElement - minElement) % (nums.Length - 1) != 0)
        {
            return false;
        }

        var diff = (maxElement - minElement) / (nums.Length - 1);
        var current = minElement + diff;
        while (current < maxElement)
        {
            if (!set.Contains(current))
            {
                return false;
            }

            current += diff;
        }

        return true;
    }
}