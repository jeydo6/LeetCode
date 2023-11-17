using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1877
{
    public static int MinPairSum(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        for (var i = 0; i < nums.Length / 2; i++)
        {
            result = Math.Max(result, nums[i] + nums[nums.Length - 1 - i]);
        }

        return result;
    }
}