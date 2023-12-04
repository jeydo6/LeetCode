using System;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _2264
{
    public static string LargestGoodInteger(string num)
    {
        var maxDigit = char.MinValue;
        for (var i = 0; i <= num.Length - 3; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
            {
                maxDigit = (char)Math.Max(maxDigit, num[i]);
            }
        }

        return maxDigit == char.MinValue ?
            string.Empty :
            new string(new char[] { maxDigit, maxDigit, maxDigit });
    }
}