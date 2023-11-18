using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1838
{
    public static int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);
        var result = 0;

        var current = 0L;
        var left = 0;
        for (var right = 0; right < nums.Length; right++)
        {
            var target = nums[right];
            current += target;

            while ((right - left + 1) * target - current > k)
            {
                current -= nums[left];
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}