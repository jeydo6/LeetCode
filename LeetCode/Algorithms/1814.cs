using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1814
{
    private const int Modulo = 1_000_000_007;

    public static int CountNicePairs(int[] nums)
    {
        var array = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            array[i] = nums[i] - Reverse(nums[i]);
        }
        
        var dictionary = new Dictionary<int, int>();
        int result = 0;
        for (var i = 0; i < array.Length; i++)
        {
            var value = dictionary.ContainsKey(array[i]) ? dictionary[array[i]] : 0;
            result = (result + value) % Modulo;
            dictionary[array[i]] = value + 1;
        }
        
        return result;
    }

    private static int Reverse(int num)
    {
        var result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }

        return result;
    }
}