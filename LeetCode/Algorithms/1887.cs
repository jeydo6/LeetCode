using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1887
{
    public static int ReductionOperations(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        var up = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                up++;
            }

            result += up;
        }

        return result;
    }
}